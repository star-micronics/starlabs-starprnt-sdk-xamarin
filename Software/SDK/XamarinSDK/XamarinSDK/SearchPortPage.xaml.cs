using StarIoWrapper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinSDK
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchPortPage : ContentPage
    {
        private class ListViewItem : IListViewItem
        {
            public PortInfo PortInfo { get; }

            public string Text { get; }

            public Color TextColor { get; }

            public string DetailText { get; }

            public Color DetailTextColor { get; }

            public ListViewItem(PortInfo portInfo)
            {
                this.PortInfo = portInfo;

                this.Text            = this.PortInfo.ModelName;
                this.TextColor       = Color.DodgerBlue;
                this.DetailText      = this.PortInfo.PortName;
                this.DetailTextColor = Color.DodgerBlue;
            }
        }

        private ContentPageComponent contentPageComponent;

        private ObservableCollection<ListViewItemCollection> observableCollection;

        private ListViewItemCollection listViewItemCollection;

        private bool didAppear;

        public SearchPortPage()
        {
            InitializeComponent();

            this.Title = "Search Port";

            this.contentPageComponent = new ContentPageComponent(this, this.blind);

            ICommand command = new Command(async () => { await RefreshPortInfo(); }, () => this.contentPageComponent.UserInteractionEnabled);

            ToolbarItems.Add(new ToolbarItem { Text = "Refresh", Icon = App.PlatformDepends.RefreshImage, Priority = 1, Order = ToolbarItemOrder.Primary, Command = command });

            this.observableCollection = new ObservableCollection<ListViewItemCollection>();

            this.listViewItemCollection = new ListViewItemCollection("List");

            this.observableCollection.Add(this.listViewItemCollection);

            this.listView.ItemsSource = this.observableCollection;

            didAppear = false;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            if (this.didAppear == false)
            {
                await RefreshPortInfo();

                didAppear = true;
            }
        }

        protected override bool OnBackButtonPressed()
        {
            bool result = true;

            if (this.contentPageComponent.UserInteractionEnabled)
            {
                result = base.OnBackButtonPressed();
            }

            return result;
        }

        public async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ((ListView) sender).SelectedItem = null;

            ListViewItem listViewItem = (ListViewItem) e.Item;

            string portName   = listViewItem.PortInfo.PortName;
            string modelName  = listViewItem.PortInfo.ModelName;
            string macAddress = listViewItem.PortInfo.MacAddress;

            if (false)     // Ex1. Direct Setting.
            {
                //string portSettings = "";
                //string portSettings = "mini";
                //string portSettings = "escpos";
                //string portSettings = "Portable";

                //StarIoExtEmulation emulation = StarIoExtEmulation.StarPRNT;
                //StarIoExtEmulation emulation = StarIoExtEmulation.StarLine;
                //StarIoExtEmulation emulation = StarIoExtEmulation.StarGraphic;
                //StarIoExtEmulation emulation = StarIoExtEmulation.EscPos;
                //StarIoExtEmulation emulation = StarIoExtEmulation.EscPosMobile;
                //StarIoExtEmulation emulation = StarIoExtEmulation.StarDotImpact;
                //StarIoExtEmulation emulation = StarIoExtEmulation.StarPRNTL;

                //Configuration.PortName = portName;
                //Configuration.ModelName = modelName;
                //Configuration.MacAddress = macAddress;
                //Configuration.PortSettings = portSettings;
                //Configuration.Emulation = emulation;
                //Configuration.CashDrawerOpenActiveHigh = true;

                //await Navigation.PopAsync(true);
            }
            else if (false)     // Ex2. Direct Setting.
            {
                //ModelIndex modelIndex = ModelIndex.MCPrint2;
                //ModelIndex modelIndex = ModelIndex.MCPrint3;
                //ModelIndex modelIndex = ModelIndex.MPOP;
                //ModelIndex modelIndex = ModelIndex.FVP10;
                //ModelIndex modelIndex = ModelIndex.TSP100;
                //ModelIndex modelIndex = ModelIndex.TSP650II;
                //ModelIndex modelIndex = ModelIndex.TSP700II;
                //ModelIndex modelIndex = ModelIndex.TSP800II;
                //ModelIndex modelIndex = ModelIndex.SM_S210I;
                //ModelIndex modelIndex = ModelIndex.SM_S220I;
                //ModelIndex modelIndex = ModelIndex.SM_S230I;
                //ModelIndex modelIndex = ModelIndex.SM_T300I;
                //ModelIndex modelIndex = ModelIndex.SM_T400I;
                //ModelIndex modelIndex = ModelIndex.BSC10;
                //ModelIndex modelIndex = ModelIndex.SM_S210I_StarPRNT;
                //ModelIndex modelIndex = ModelIndex.SM_S220I_StarPRNT;
                //ModelIndex modelIndex = ModelIndex.SM_S230I_StarPRNT;
                //ModelIndex modelIndex = ModelIndex.SM_T300I_StarPRNT;
                //ModelIndex modelIndex = ModelIndex.SM_T400I_StarPRNT;
                //ModelIndex modelIndex = ModelIndex.SM_L200;
                //ModelIndex modelIndex = ModelIndex.SP700;
                //ModelIndex modelIndex = ModelIndex.SM_L300;

                //string portSettings = ModelCapability.PortSettingsAtModelIndex(modelIndex);
                //StarIoExtEmulation emulation = ModelCapability.EmulationAtModelIndex(modelIndex);

                //Configuration.PortName = portName;
                //Configuration.ModelName = modelName;
                //Configuration.MacAddress = macAddress;
                //Configuration.PortSettings = portSettings;
                //Configuration.Emulation = emulation;
                //Configuration.CashDrawerOpenActiveHigh = true;

                //await Navigation.PopAsync(true);
            }
            else if (false)     // Ex3. Indirect Setting.
            {
                //ModelIndex modelIndex = ModelCapability.ModelIndexAtModelName(modelName);

                //string portSettings = ModelCapability.PortSettingsAtModelIndex(modelIndex);
                //StarIoExtEmulation emulation = ModelCapability.EmulationAtModelIndex(modelIndex);

                //Configuration.PortName = portName;
                //Configuration.ModelName = modelName;
                //Configuration.MacAddress = macAddress;
                //Configuration.PortSettings = portSettings;
                //Configuration.Emulation = emulation;
                //Configuration.CashDrawerOpenActiveHigh = true;

                //await Navigation.PopAsync(true);
            }
            else     // Ex4. Indirect Setting.
            {
                ModelIndex modelIndex = ModelCapability.ModelIndexAtModelName(modelName);

                if (modelIndex != ModelIndex.None)
                {
                    if (! await DisplayAlert("Confirm.", "Is your printer " + ModelCapability.TitleAtModelIndex(modelIndex) + "?", "YES", "NO"))
                    {
                        modelIndex = ModelIndex.None;
                    }
                }

                if (modelIndex == ModelIndex.None)
                {
                    List<string> buttonList = new List<string>();

                    for (int i = 0; i < ModelCapability.ModelIndexCount; i++)
                    {
                        buttonList.Add(ModelCapability.TitleAtModelIndex(ModelCapability.ModelIndexAtIndex(i)));
                    }

                    int index = buttonList.IndexOf(await DisplayActionSheet("What is your printer?", "Cancel", null, buttonList.ToArray()));

                    if (index >= 0)
                    {
                        modelIndex = ModelCapability.ModelIndexAtIndex(index);
                    }
                }

                if (modelIndex != ModelIndex.None)
                {
                    bool cashDrawerOpenActiveHigh = true;

                    if (ModelCapability.CashDrawerOpenActiveAtModelIndex(modelIndex))
                    {
                        List<string> buttonsList = new List<string>(new string[] {"High when Open", "Low when Open"});

                        switch (buttonsList.IndexOf(await DisplayActionSheet("Select CashDrawer Open Status.", "Cancel", null, buttonsList.ToArray())))
                        {
                            default :
                                modelIndex = ModelIndex.None;
                                break;
                            case 0 :
                                cashDrawerOpenActiveHigh = true;
                                break;
                            case 1 :
                                cashDrawerOpenActiveHigh = false;
                                break;
                        }
                    }

                    if (modelIndex != ModelIndex.None)
                    {
                        Configuration.PortName                 = portName;
                        Configuration.ModelName                = modelName;
                        Configuration.MacAddress               = macAddress;
                        Configuration.PortSettings             = ModelCapability.PortSettingsAtModelIndex(modelIndex);
                        Configuration.Emulation                = ModelCapability.EmulationAtModelIndex   (modelIndex);
                        Configuration.CashDrawerOpenActiveHigh = cashDrawerOpenActiveHigh;

                        await Navigation.PopAsync(true);
                    }
                }
            }
        }

        public async Task RefreshPortInfo()
        {
            Dictionary<string, string> targetDictionary;

            if (Device.RuntimePlatform == Device.iOS)
            {
                targetDictionary = new Dictionary<string, string>
                {
                    {"LAN",                  "TCP:"},
                    {"Bluetooth",            "BT:"},
                    {"Bluetooth Low Energy", "BLE:"},
                    {"USB",                  "USB:"},
                    {"All",                  ""}
                };
            }
            else
            {
                targetDictionary = new Dictionary<string, string>
                {
                    {"LAN",       "TCP:"},
                    {"Bluetooth", "BT:"},
                    {"USB",       "USB:"},
                    {"All",       ""}
                };
            }

            try
            {
                string target = targetDictionary[await DisplayActionSheet("Select Interface.", "Cancel", null, targetDictionary.Keys.ToArray())];

                this.contentPageComponent.UserInteractionEnabled = false;

                listViewItemCollection.Clear();

                try
                {
                    if (target == "")
                    {
                        Communication.Communication.SearchPrinter        (SearchPrinterAction);
                    }
                    else
                    {
                        Communication.Communication.SearchPrinter(target, SearchPrinterAction);
                    }
                }
                catch (Exception exception)
                {
                    DebugExt.WriteLine(exception.Message);
                }
            }
            catch
            {
                await Navigation.PopAsync(true);
            }
        }

        public void SearchPrinterAction(IList<PortInfo> portInfoList)
        {
            foreach (PortInfo portInfo in portInfoList)
            {
                ListViewItem listViewItem = new ListViewItem(portInfo);

                this.listViewItemCollection.Add(listViewItem);
            }

            this.contentPageComponent.UserInteractionEnabled = true;
        }
    }
}
