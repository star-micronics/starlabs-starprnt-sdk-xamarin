using System.Text;

namespace XamarinSDK.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            LoadApplication(new XamarinSDK.App());
        }
    }
}
