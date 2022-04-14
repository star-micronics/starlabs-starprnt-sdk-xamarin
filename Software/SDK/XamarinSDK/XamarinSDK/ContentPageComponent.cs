using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinSDK
{
    class ContentPageComponent
    {
        private ContentPage contentPage;
        private ContentView blind;

        private bool userInteractionEnabled;

        public bool UserInteractionEnabled
        {
            get { return this.userInteractionEnabled; }

            set
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    NavigationPage.SetHasBackButton(this.contentPage, value);

                    this.blind.IsVisible = ! value;

                    this.userInteractionEnabled = value;

                    foreach (ToolbarItem item in this.contentPage.ToolbarItems)
                    {
                        ((Command) item.Command).ChangeCanExecute();
                    }
                });
            }
        }

        public ContentPageComponent(ContentPage contentPage, ContentView blind)
        {
            this.contentPage = contentPage;
            this.blind       = blind;

            this.userInteractionEnabled = true;
        }
    }
}
