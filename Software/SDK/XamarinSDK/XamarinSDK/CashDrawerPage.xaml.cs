using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using StarIoWrapper;

namespace XamarinSDK
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CashDrawerPage : ContentPage
    {
        private class ListViewItem : IListViewItem
        {
            public string Text { get; }

            public Color TextColor { get; }

            public string DetailText { get; }

            public Color DetailTextColor { get; }

            public Func<byte[]> Function { get; }

            public ListViewItem(string text, Func<byte[]> function)
            {
                this.Text            = text;
                this.TextColor       = Color.DodgerBlue;
                this.DetailText      = ">";
                this.DetailTextColor = Color.Gray;
                this.Function        = function;
            }
        }

        private ContentPageComponent contentPageComponent;

        private ObservableCollection<ListViewItemCollection> observableCollection;

        private ListViewItemCollection listViewItemCollection;

        public CashDrawerPage()
        {
            InitializeComponent();

            this.Title = "Cash Drawer";

            this.contentPageComponent = new ContentPageComponent(this, this.blind);

            this.observableCollection = new ObservableCollection<ListViewItemCollection>();

            this.listViewItemCollection = new ListViewItemCollection("Like a StarIO-SDK Sample");

            this.observableCollection.Add(this.listViewItemCollection);

            this.listView.ItemsSource = this.observableCollection;

            StarIoExtEmulation emulation = Configuration.Emulation;

            this.listViewItemCollection.Add(new ListViewItem("Channel1 (Check condition.)",        () => { return Functions.CashDrawerFunctions.CreateData(emulation, PeripheralChannel.No1); }));
            this.listViewItemCollection.Add(new ListViewItem("Channel1 (Do not check condition.)", () => { return Functions.CashDrawerFunctions.CreateData(emulation, PeripheralChannel.No1); }));
            this.listViewItemCollection.Add(new ListViewItem("Channel2 (Check condition.)",        () => { return Functions.CashDrawerFunctions.CreateData(emulation, PeripheralChannel.No2); }));
            this.listViewItemCollection.Add(new ListViewItem("Channel2 (Do not check condition.)", () => { return Functions.CashDrawerFunctions.CreateData(emulation, PeripheralChannel.No2); }));
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

            ListViewItem listViewItem = (ListViewItem) e.Item;

            byte[] commands = listViewItem.Function();

            this.contentPageComponent.UserInteractionEnabled = false;

            try
            {
                string portName     = Configuration.PortName;
                string portSettings = Configuration.PortSettings;

                switch (this.listViewItemCollection.IndexOf(listViewItem))
                {
                    default :
//                  case 0  :
//                  case 2  :
                        Communication.Communication.SendCommands                   (commands, portName, portSettings, 10000, SendCommandsAction);     // 10000mS!!!
                        break;
                    case 1 :
                    case 3 :
                        Communication.Communication.SendCommandsDoNotCheckCondition(commands, portName, portSettings, 10000, SendCommandsAction);     // 10000mS!!!
                        break;
                }
            }
            catch (Exception exception)
            {
                DebugExt.WriteLine(exception.Message);
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
