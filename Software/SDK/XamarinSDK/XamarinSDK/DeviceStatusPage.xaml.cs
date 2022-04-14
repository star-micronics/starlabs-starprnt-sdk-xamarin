using StarIoWrapper;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinSDK
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeviceStatusPage : ContentPage
    {
        private class ListViewItem : IListViewItem
        {
            public string Text { get; }

            public Color TextColor { get; }

            public string DetailText { get; }

            public Color DetailTextColor { get; }

            public ListViewItem(string text, string detailText, Color detailTextColor)
            {
                this.Text            = text;
                this.TextColor       = Color.Black;
                this.DetailText      = detailText;
                this.DetailTextColor = detailTextColor;
            }

            public ListViewItem(string text, bool value, string[] detailTexts, Color[] detailTextColors)
            {
                this.Text      = text;
                this.TextColor = Color.Black;

                if (value)
                {
                    this.DetailText      = detailTexts[0];
                    this.DetailTextColor = detailTextColors[0];
                }
                else
                {
                    this.DetailText      = detailTexts[1];
                    this.DetailTextColor = detailTextColors[1];
                }
            }
        }

        private ContentPageComponent contentPageComponent;

        private ObservableCollection<ListViewItemCollection> observableCollection;

        private ListViewItemCollection listViewItemCollection;

        private bool didAppear;

        public DeviceStatusPage()
        {
            InitializeComponent();

            this.Title = "Device Status";

            this.contentPageComponent = new ContentPageComponent(this, this.blind);

            ICommand command = new Command(() => { RefreshDeviceStatus(); }, () => this.contentPageComponent.UserInteractionEnabled);

            ToolbarItems.Add(new ToolbarItem { Text = "Refresh", Icon = App.PlatformDepends.RefreshImage, Priority = 1, Order = ToolbarItemOrder.Primary, Command = command });

            this.observableCollection = new ObservableCollection<ListViewItemCollection>();

            this.listViewItemCollection = new ListViewItemCollection("Device Status");

            this.observableCollection.Add(this.listViewItemCollection);

            this.listView.ItemsSource = this.observableCollection;

            didAppear = false;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (this.didAppear == false)
            {
                RefreshDeviceStatus();

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

        public void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ((ListView) sender).SelectedItem = null;
        }

        public void RefreshDeviceStatus()
        {
            this.contentPageComponent.UserInteractionEnabled = false;

            listViewItemCollection.Clear();

            try
            {
                string portName     = Configuration.PortName;
                string portSettings = Configuration.PortSettings;

                Communication.Communication.GetDeviceStatus(portName, portSettings, 10000, GetDeviceStatusAction);     // 10000mS!!!
            }
            catch (Exception exception)
            {
                DebugExt.WriteLine(exception.Message);
            }
        }

        public void GetDeviceStatusAction(Communication.Result result, IPrinterStatus printerStatus)
        {
            if (result == Communication.Result.Success)
            {
                this.listViewItemCollection.Add(new ListViewItem("Online", printerStatus.Offline,   new string[] {"Offline", "Online"}, new Color[] {Color.Red, Color.Blue}));
                this.listViewItemCollection.Add(new ListViewItem("Cover",  printerStatus.CoverOpen, new string[] {"Open",    "Closed"}, new Color[] {Color.Red, Color.Blue}));

                if (printerStatus.ReceiptPaperEmpty)
                {
                    this.listViewItemCollection.Add(new ListViewItem("Paper", "Empty",      Color.Red));
                }
                else if (printerStatus.ReceiptPaperNearEmptyInner ||
                         printerStatus.ReceiptPaperNearEmptyOuter)
                {
                    this.listViewItemCollection.Add(new ListViewItem("Paper", "Near Empty", Color.Orange));
                }
                else
                {
                    this.listViewItemCollection.Add(new ListViewItem("Paper", "Ready",      Color.Blue));
                }

                if (Configuration.CashDrawerOpenActiveHigh)
                {
                    this.listViewItemCollection.Add(new ListViewItem("Cash Drawer",   printerStatus.CompulsionSwitch, new string[] {"Open", "Closed"}, new Color[] {Color.Red, Color.Blue}));
                }
                else
                {
                    this.listViewItemCollection.Add(new ListViewItem("Cash Drawer", ! printerStatus.CompulsionSwitch, new string[] {"Open", "Closed"}, new Color[] {Color.Red, Color.Blue}));
                }

                this.listViewItemCollection.Add(new ListViewItem("Head Temperature",      printerStatus.OverTemp,            new string[] {"High",   "Normal"}, new Color[] {Color.Red, Color.Blue}));
                this.listViewItemCollection.Add(new ListViewItem("Non Recoverable Error", printerStatus.UnrecoverableError,  new string[] {"Occurs", "Ready"},  new Color[] {Color.Red, Color.Blue}));
                this.listViewItemCollection.Add(new ListViewItem("Paper Cutter",          printerStatus.CutterError,         new string[] {"Error",  "Ready"},  new Color[] {Color.Red, Color.Blue}));
                this.listViewItemCollection.Add(new ListViewItem("Head Thermistor",       printerStatus.HeadThermistorError, new string[] {"Error",  "Normal"}, new Color[] {Color.Red, Color.Blue}));
                this.listViewItemCollection.Add(new ListViewItem("Voltage",               printerStatus.VoltageError,        new string[] {"Error",  "Normal"}, new Color[] {Color.Red, Color.Blue}));
            }
            else
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    DisplayAlert(result.ToString(), null, "OK");
                });
            }

            this.contentPageComponent.UserInteractionEnabled = true;
        }
    }
}
