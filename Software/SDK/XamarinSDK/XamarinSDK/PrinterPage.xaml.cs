using StarIoWrapper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinSDK
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrinterPage : ContentPage
    {
        private class ListViewItem : IListViewItem
        {
            public string Text { get; set; }

            public Color TextColor { get; set; }

            public string DetailText { get; set; }

            public Color DetailTextColor { get; set; }

            public bool Enabled
            {
                get
                {
                    return enabled;
                }
                set
                {
                    enabled = value;

                    if (enabled)
                    {
                        TextColor = Color.DodgerBlue;
                        DetailText = ">";
                        DetailTextColor = Color.Gray;
                    }
                    else
                    {
                        TextColor = Color.LightGray;
                        DetailText = "";
                        DetailTextColor = Color.LightGray;
                    }
                }
            }
            private bool enabled;

            public Func<byte[]> Function { get; set; }

            public Func<Task<byte[]>> AsyncFunction { get; set; }

            public async Task<byte[]> Execute()
            {
                List<byte> resultList = new List<byte>();

                if(Function != null)
                {
                    resultList.AddRange(Function());
                }

                if(AsyncFunction != null)
                {
                    resultList.AddRange(await AsyncFunction());
                }

                return resultList.ToArray();
            }
        }

        private ContentPageComponent contentPageComponent;

        private ObservableCollection<ListViewItemCollection> observableCollection;

        private ListViewItemCollection listViewItemCollection;

        private LocalizeReceipts.LanguageIndex  languageIndex;
        private LocalizeReceipts.PaperSizeIndex paperSizeIndex;

        public PrinterPage(LocalizeReceipts.LanguageIndex languageIndex, LocalizeReceipts.PaperSizeIndex paperSizeIndex)
        {
            InitializeComponent();

            this.languageIndex  = languageIndex;
            this.paperSizeIndex = paperSizeIndex;

            this.Title = "Printer";

            this.contentPageComponent = new ContentPageComponent(this, this.blind);

            this.observableCollection = new ObservableCollection<ListViewItemCollection>();

            this.listViewItemCollection = new ListViewItemCollection("Like a StarIO-SDK Sample");

            this.observableCollection.Add(this.listViewItemCollection);

            this.listView.ItemsSource = this.observableCollection;

            LocalizeReceipts.ILocalizeReceipts localizeReceipts = new LocalizeReceipts.LocalizeReceipts(this.languageIndex, this.paperSizeIndex);

            string languageCode   = localizeReceipts.LanguageCode;
            string paperSize      = localizeReceipts.PaperSize;
            string scalePaperSize = localizeReceipts.ScalePaperSize;

            Dictionary<StarIoExtEmulation, List<bool>> userInteractionEnabledDictionary = new Dictionary<StarIoExtEmulation, List<bool>>()
            {
                {StarIoExtEmulation.StarPRNT,      new List<bool>() {true,  true,  true,  true,  true,  true,  true}},
                {StarIoExtEmulation.StarLine,      new List<bool>() {true,  true,  true,  true,  true,  true,  true}},
                {StarIoExtEmulation.StarGraphic,   new List<bool>() {false, false, true,  true,  true,  true,  true}},
                {StarIoExtEmulation.EscPos,        new List<bool>() {true,  false, true,  true,  true,  true,  true}},
                {StarIoExtEmulation.EscPosMobile,  new List<bool>() {true,  false, true,  true,  true,  true,  true}},
                {StarIoExtEmulation.StarDotImpact, new List<bool>() {true,  true,  false, false, false, true,  true}},
                {StarIoExtEmulation.StarPRNTL,     new List<bool>() {true,  true,  true,  true,  true,  true,  true}}
            };

            StarIoExtEmulation emulation = Configuration.Emulation;

            List<bool> userInteractionEnabledList = userInteractionEnabledDictionary[emulation];

            this.listViewItemCollection.Add(new ListViewItem()
            {
                Text = languageCode + " " + paperSize + " " + "Text Receipt",
                Enabled = userInteractionEnabledList[0],
                Function = () =>
                {
                    return Functions.PrinterFunctions.CreateTextReceiptData(emulation, localizeReceipts, false);
                }
            });

            this.listViewItemCollection.Add(new ListViewItem()
            {
                Text = languageCode + " " + paperSize + " " + "Text Receipt (UTF8)",
                Enabled = userInteractionEnabledList[1],
                Function = () =>
                {
                    return Functions.PrinterFunctions.CreateTextReceiptData(emulation, localizeReceipts, true);
                }
            });

            this.listViewItemCollection.Add(new ListViewItem()
            {
                Text = languageCode + " " + paperSize + " " + "Raster Receipt",
                Enabled = userInteractionEnabledList[2],
                AsyncFunction = async () =>
                {
                    return await Functions.PrinterFunctions.CreateRasterReceiptData(emulation, localizeReceipts);
                }
            });

            this.listViewItemCollection.Add(new ListViewItem()
            {
                Text = languageCode + " " + scalePaperSize + " " + "Raster Receipt (Both Scale)",
                Enabled = userInteractionEnabledList[3],
                AsyncFunction = async () =>
                {
                    return await Functions.PrinterFunctions.CreateScaleRasterReceiptData(emulation, localizeReceipts, (int)this.paperSizeIndex, true);
                }
            });

            this.listViewItemCollection.Add(new ListViewItem()
            {
                Text = languageCode + " " + scalePaperSize + " " + "Raster Receipt (Scale)",
                Enabled = userInteractionEnabledList[4],
                AsyncFunction = async () =>
                {
                    return await Functions.PrinterFunctions.CreateScaleRasterReceiptData(emulation, localizeReceipts, (int)this.paperSizeIndex, false);
                }
            });

            this.listViewItemCollection.Add(new ListViewItem()
            {
                Text = languageCode + " " + "Raster Coupon",
                Enabled = userInteractionEnabledList[5],
                Function = () =>
                {
                    return Functions.PrinterFunctions.CreateCouponData(emulation, localizeReceipts, (int)this.paperSizeIndex, BitmapConverterRotation.Normal);
                }
            });

            this.listViewItemCollection.Add(new ListViewItem()
            {
                Text = languageCode + " " + "Raster Coupon (Rotation90)",
                Enabled = userInteractionEnabledList[6],
                Function = () =>
                {
                    return Functions.PrinterFunctions.CreateCouponData(emulation, localizeReceipts, (int)this.paperSizeIndex, BitmapConverterRotation.Right90);
                }
            });
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

            if (listViewItem.Enabled)
            {
                byte[] commands = await listViewItem.Execute();

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
