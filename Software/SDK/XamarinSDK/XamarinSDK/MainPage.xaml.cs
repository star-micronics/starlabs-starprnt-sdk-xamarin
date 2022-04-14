using StarIoWrapper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinSDK
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        private class ListViewItem : IListViewItem
        {
            public string Text { get; }

            public Color TextColor { get; }

            public string DetailText { get; }

            public Color DetailTextColor { get; }

            public bool Enabled { get; }

            public Func<Task> Function { get; }

            public ListViewItem(string text, Color textColor, Func<Task> function)
            {
                this.Text    = text;
                this.Enabled = true;

                this.DetailText      = ">";
                this.TextColor       = textColor;
                this.DetailTextColor = Color.Gray;

                this.Function = function;
            }

            public ListViewItem(string text, bool enabled, Func<Task> function)
            {
                this.Text    = text;
                this.Enabled = enabled;

                if (this.Enabled)
                {
                    this.DetailText      = ">";
                    this.TextColor       = Color.DodgerBlue;
                    this.DetailTextColor = Color.Gray;
                }
                else
                {
                    this.DetailText      = "";
                    this.TextColor       = Color.LightGray;
                    this.DetailTextColor = Color.LightGray;
                }

                this.Function = function;
            }
        }

        private ContentPageComponent contentPageComponent;

        private ObservableCollection<ListViewItemCollection> observableCollection;

        private ListViewItemCollection listViewItemCollection0;
        private ListViewItemCollection listViewItemCollection1;
        private ListViewItemCollection listViewItemCollection2;
        private ListViewItemCollection listViewItemCollection3;
        private ListViewItemCollection listViewItemCollection4;
        private ListViewItemCollection listViewItemCollection5;

        public MainPage()
        {
            InitializeComponent();

            string version = App.PlatformDepends.GetExecutingAssembly();

            this.Title = "Xamarin SDK Ver." + version;

            this.contentPageComponent = new ContentPageComponent(this, this.blind);

            this.observableCollection = new ObservableCollection<ListViewItemCollection>();

            this.listViewItemCollection0 = new ListViewItemCollection("Destination Device");
            this.listViewItemCollection1 = new ListViewItemCollection("Printer");
            this.listViewItemCollection2 = new ListViewItemCollection("Cash Drawer");
            this.listViewItemCollection3 = new ListViewItemCollection("API");
            this.listViewItemCollection4 = new ListViewItemCollection("Device Status");
            this.listViewItemCollection5 = new ListViewItemCollection("Appendix");

            this.observableCollection.Add(this.listViewItemCollection0);
            this.observableCollection.Add(this.listViewItemCollection1);
            this.observableCollection.Add(this.listViewItemCollection2);
            this.observableCollection.Add(this.listViewItemCollection3);
            this.observableCollection.Add(this.listViewItemCollection4);
            this.observableCollection.Add(this.listViewItemCollection5);

            this.listView.ItemsSource = this.observableCollection;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            this.listViewItemCollection0.Clear();
            this.listViewItemCollection1.Clear();
            this.listViewItemCollection2.Clear();
            this.listViewItemCollection3.Clear();
            this.listViewItemCollection4.Clear();
            this.listViewItemCollection5.Clear();

            bool userInteractionEnabled;

            string modelName = Configuration.ModelName;
            string portName  = Configuration.PortName;

            if (modelName == "")
            {
                this.listViewItemCollection0.Add(new ListViewItem("Unselected State", Color.Red, async () =>
                {
                    await Navigation.PushAsync(new SearchPortPage(), true);
                }));

                userInteractionEnabled = false;
            }
            else
            {
                this.listViewItemCollection0.Add(new ListViewItem(modelName + " " + "(" + portName + ")", Color.Blue, async () =>
                {
                    await Navigation.PushAsync(new SearchPortPage(), true);
                }));

                userInteractionEnabled = true;
            }

            Dictionary<StarIoExtEmulation, List<bool>> userInteractionEnabledDictionary = new Dictionary<StarIoExtEmulation, List<bool>>()
            {
                {StarIoExtEmulation.StarPRNT,      new List<bool>() {userInteractionEnabled, userInteractionEnabled, userInteractionEnabled, userInteractionEnabled}},
                {StarIoExtEmulation.StarLine,      new List<bool>() {userInteractionEnabled, userInteractionEnabled, userInteractionEnabled, userInteractionEnabled}},
                {StarIoExtEmulation.StarGraphic,   new List<bool>() {userInteractionEnabled, userInteractionEnabled, userInteractionEnabled, userInteractionEnabled}},
                {StarIoExtEmulation.EscPos,        new List<bool>() {userInteractionEnabled, userInteractionEnabled, userInteractionEnabled, userInteractionEnabled}},
                {StarIoExtEmulation.EscPosMobile,  new List<bool>() {userInteractionEnabled, false,                  userInteractionEnabled, userInteractionEnabled}},
                {StarIoExtEmulation.StarDotImpact, new List<bool>() {userInteractionEnabled, userInteractionEnabled, userInteractionEnabled, userInteractionEnabled}},
                {StarIoExtEmulation.StarPRNTL,     new List<bool>() {userInteractionEnabled, userInteractionEnabled, userInteractionEnabled, userInteractionEnabled}}
            };

            Dictionary<string, LocalizeReceipts.LanguageIndex> languageDictionary = new Dictionary<string, LocalizeReceipts.LanguageIndex>
            {
                {"English",             LocalizeReceipts.LanguageIndex.English},
                {"Japanese",            LocalizeReceipts.LanguageIndex.Japanese},
                {"French",              LocalizeReceipts.LanguageIndex.French},
                {"Portuguese",          LocalizeReceipts.LanguageIndex.Portuguese},
                {"Spanish",             LocalizeReceipts.LanguageIndex.Spanish},
                {"German",              LocalizeReceipts.LanguageIndex.German},
                {"Russian",             LocalizeReceipts.LanguageIndex.Russian},
                {"Simplified Chinese",  LocalizeReceipts.LanguageIndex.SimplifiedChinese},
                {"Traditional Chinese", LocalizeReceipts.LanguageIndex.TraditionalChinese}
            };

            Dictionary<string, LocalizeReceipts.PaperSizeIndex> paperSizeDictionary = new Dictionary<string, LocalizeReceipts.PaperSizeIndex>
            {
                {"2\" (384dots)", LocalizeReceipts.PaperSizeIndex.TwoInch},
                {"3\" (576dots)", LocalizeReceipts.PaperSizeIndex.ThreeInch},
                {"4\" (832dots)", LocalizeReceipts.PaperSizeIndex.FourInch}
            };

            List<bool> userInteractionEnabledList = userInteractionEnabledDictionary[Configuration.Emulation];

            this.listViewItemCollection1.Add(new ListViewItem("Sample", userInteractionEnabledList[0], async () =>
            {
                try
                {
                    LocalizeReceipts.LanguageIndex languageIndex = languageDictionary[await DisplayActionSheet("Select language.", "Cancel", null, languageDictionary.Keys.ToArray())];

                    LocalizeReceipts.PaperSizeIndex paperSizeIndex;

                    StarIoExtEmulation emulation = Configuration.Emulation;

                    if (emulation == StarIoExtEmulation.EscPos)
                    {
                        paperSizeIndex = LocalizeReceipts.PaperSizeIndex.EscPosThreeInch;
                    }
                    else if (emulation == StarIoExtEmulation.StarDotImpact)
                    {
                        paperSizeIndex = LocalizeReceipts.PaperSizeIndex.DotImpactThreeInch;
                    }
                    else
                    {
                        paperSizeIndex = paperSizeDictionary[await DisplayActionSheet("Select paper size.", "Cancel", null, paperSizeDictionary.Keys.ToArray())];
                    }

                    await Navigation.PushAsync(new PrinterPage(languageIndex, paperSizeIndex), true);
                }
                catch
                {
                }
            }));

            this.listViewItemCollection2.Add(new ListViewItem("Sample", userInteractionEnabledList[1], async () =>
            {
                await Navigation.PushAsync(new CashDrawerPage(), true);
            }));

            this.listViewItemCollection3.Add(new ListViewItem("Sample", userInteractionEnabledList[2], async () =>
            {
                try
                {
                    LocalizeReceipts.PaperSizeIndex paperSizeIndex;

                    StarIoExtEmulation emulation = Configuration.Emulation;

                    if (emulation == StarIoExtEmulation.EscPos)
                    {
                        paperSizeIndex = LocalizeReceipts.PaperSizeIndex.EscPosThreeInch;
                    }
                    else if (emulation == StarIoExtEmulation.StarDotImpact)
                    {
                        paperSizeIndex = LocalizeReceipts.PaperSizeIndex.DotImpactThreeInch;
                    }
                    else
                    {
                        paperSizeIndex = paperSizeDictionary[await DisplayActionSheet("Select paper size.", "Cancel", null, paperSizeDictionary.Keys.ToArray())];
                    }

                    await Navigation.PushAsync(new ApiPage(paperSizeIndex), true);
                }
                catch
                {
                }
            }));

            this.listViewItemCollection4.Add(new ListViewItem("Sample", userInteractionEnabledList[3], async () =>
            {
                await Navigation.PushAsync(new DeviceStatusPage(), true);
            }));

            this.listViewItemCollection5.Add(new ListViewItem("Library Version", true, async () =>
            {
                string message = "StarIO version " + Port.StarIOVersion + Environment.NewLine + Extension.StarIoExtVersion;

                await DisplayAlert("Library Version", message, "OK");
            }));
        }

        public async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ((ListView) sender).SelectedItem = null;

            ListViewItem listViewItem = (ListViewItem) e.Item;

            if (listViewItem.Enabled)
            {
                await listViewItem.Function();
            }
        }
    }
}
