using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using StarIoWrapper;

namespace XamarinSDK
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ApiPage : ContentPage
    {
        private class ListViewItem : IListViewItem
        {
            public string Text { get; }

            public Color TextColor { get; }

            public string DetailText { get; }

            public Color DetailTextColor { get; }

            public Func<Task<byte[]>> AsyncFunction { get; }

            public Func<byte[]> SyncFunction { get; }

            public ListViewItem(string text, Func<Task<byte[]>> function)
            {
                this.Text            = text;
                this.TextColor       = Color.DodgerBlue;
                this.DetailText      = ">";
                this.DetailTextColor = Color.Gray;

                this.AsyncFunction = function;
                this.SyncFunction  = null;
            }

            public ListViewItem(string text, Func<byte[]> function)
            {
                this.Text            = text;
                this.TextColor       = Color.DodgerBlue;
                this.DetailText      = ">";
                this.DetailTextColor = Color.Gray;

                this.AsyncFunction = null;
                this.SyncFunction  = function;
            }
        }

        private ContentPageComponent contentPageComponent;

        private ObservableCollection<ListViewItemCollection> observableCollection;

        private ListViewItemCollection listViewItemCollection;

        private LocalizeReceipts.PaperSizeIndex paperSizeIndex;

        public ApiPage(LocalizeReceipts.PaperSizeIndex paperSizeIndex)
        {
            InitializeComponent();

            this.paperSizeIndex = paperSizeIndex;

            this.Title = "API";

            this.contentPageComponent = new ContentPageComponent(this, this.blind);

            this.observableCollection = new ObservableCollection<ListViewItemCollection>();

            this.listViewItemCollection = new ListViewItemCollection("Sample");

            this.observableCollection.Add(this.listViewItemCollection);

            this.listView.ItemsSource = this.observableCollection;

            StarIoExtEmulation emulation = Configuration.Emulation;

            this.listViewItemCollection.Add(new ListViewItem("Generic",           () => { return Functions.ApiFunctions.CreateGenericData(emulation); }));
            this.listViewItemCollection.Add(new ListViewItem("Font Style",        () => { return Functions.ApiFunctions.CreateFontStyleData(emulation); }));
            this.listViewItemCollection.Add(new ListViewItem("Initialization",    () => { return Functions.ApiFunctions.CreateInitializationData(emulation); }));
            this.listViewItemCollection.Add(new ListViewItem("Code Page",         () => { return Functions.ApiFunctions.CreateCodePageData(emulation); }));
            this.listViewItemCollection.Add(new ListViewItem("International",     () => { return Functions.ApiFunctions.CreateInternationalData(emulation); }));
            this.listViewItemCollection.Add(new ListViewItem("Feed",              () => { return Functions.ApiFunctions.CreateFeedData(emulation); }));
            this.listViewItemCollection.Add(new ListViewItem("Character Space",   () => { return Functions.ApiFunctions.CreateCharacterSpaceData(emulation); }));
            this.listViewItemCollection.Add(new ListViewItem("Line Space",        () => { return Functions.ApiFunctions.CreateLineSpaceData(emulation); }));
            this.listViewItemCollection.Add(new ListViewItem("Emphasis",          () => { return Functions.ApiFunctions.CreateEmphasisData(emulation); }));
            this.listViewItemCollection.Add(new ListViewItem("Invert",            () => { return Functions.ApiFunctions.CreateInvertData(emulation); }));
            this.listViewItemCollection.Add(new ListViewItem("Under Line",        () => { return Functions.ApiFunctions.CreateUnderLineData(emulation); }));
            this.listViewItemCollection.Add(new ListViewItem("Multiple",          () => { return Functions.ApiFunctions.CreateMultipleData(emulation); }));
            this.listViewItemCollection.Add(new ListViewItem("Absolute Position", () => { return Functions.ApiFunctions.CreateAbsolutePositionData(emulation); }));
            this.listViewItemCollection.Add(new ListViewItem("Alignment",         () => { return Functions.ApiFunctions.CreateAlignmentData(emulation); }));
            this.listViewItemCollection.Add(new ListViewItem("Logo",              () => { return Functions.ApiFunctions.CreateLogoData(emulation); }));
            this.listViewItemCollection.Add(new ListViewItem("Cut Paper",         () => { return Functions.ApiFunctions.CreateCutPaperData(emulation); }));
            this.listViewItemCollection.Add(new ListViewItem("Peripheral",        () => { return Functions.ApiFunctions.CreatePeripheralData(emulation); }));
            this.listViewItemCollection.Add(new ListViewItem("Sound",             () => { return Functions.ApiFunctions.CreateSoundData(emulation); }));
            this.listViewItemCollection.Add(new ListViewItem("Bitmap",            () => { return Functions.ApiFunctions.CreateBitmapData(emulation, (int) this.paperSizeIndex); }));
            this.listViewItemCollection.Add(new ListViewItem("Barcode",           () => { return Functions.ApiFunctions.CreateBarcodeData(emulation); }));
            this.listViewItemCollection.Add(new ListViewItem("PDF417",            () => { return Functions.ApiFunctions.CreatePdf417Data(emulation); }));
            this.listViewItemCollection.Add(new ListViewItem("QR Code",           () => { return Functions.ApiFunctions.CreateQrCodeData(emulation); }));

            this.listViewItemCollection.Add(new ListViewItem("Black Mark", async () =>
            {
                Dictionary<string, Func<byte[]>> functionDictionary = new Dictionary<string, Func<byte[]>>
                {
                    {"Invalid",              () => { return Functions.ApiFunctions.CreateBlackMarkData(emulation, BlackMarkType.Invalid); }},
                    {"Valid",                () => { return Functions.ApiFunctions.CreateBlackMarkData(emulation, BlackMarkType.Valid); }},
                    {"Valid with Detection", () => { return Functions.ApiFunctions.CreateBlackMarkData(emulation, BlackMarkType.ValidWithDetection); }}
                };

                string[] buttons = functionDictionary.Keys.ToArray();

                try
                {
                    return functionDictionary[await DisplayActionSheet("Select black mark type.", "Cancel", null, buttons)]();
                }
                catch
                {
                }

                return null;
            }));

            this.listViewItemCollection.Add(new ListViewItem("Page Mode", () => { return Functions.ApiFunctions.CreatePageModeData(emulation, (int) this.paperSizeIndex); }));
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

            byte[] commands;

            if (listViewItem.SyncFunction == null)
            {
                commands = await listViewItem.AsyncFunction();
            }
            else
            {
                commands = listViewItem.SyncFunction();
            }

            if (commands != null)
            {
                this.contentPageComponent.UserInteractionEnabled = false;

                try
                {
                    string portName     = Configuration.PortName;
                    string portSettings = Configuration.PortSettings;

                    Communication.Communication.SendCommands(commands, portName, portSettings, 10000, SendCommandsAction);     // 10000mS!!!
                }
                catch (Exception exception)
                {
                    DebugExt.WriteLine(exception.Message);
                }
            }
        }

        public void SendCommandsAction(Communication.Result result)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                DisplayAlert(result.ToString(), null, "OK");
            });

            this.contentPageComponent.UserInteractionEnabled = true;
        }
    }
}
