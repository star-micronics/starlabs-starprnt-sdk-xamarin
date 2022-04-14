using System.IO;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinSDK.LocalizeReceipts;

namespace XamarinSDK
{
    public class PlatformDepends : IPlatformDepends
    {
        public string GetExecutingAssembly()
        {
            return DependencyService.Get<IPlatformDepends>().GetExecutingAssembly();
        }

        public FileImageSource RefreshImage
        {
            get
            {
                return DependencyService.Get<IPlatformDepends>().RefreshImage;
            }
        }

        public Task<Stream> CreateBitmapAsync(string text, LanguageIndex languageIndex, PaperSizeIndex paperSizeIndex)
        {
            return DependencyService.Get<IPlatformDepends>().CreateBitmapAsync(text, languageIndex, paperSizeIndex);
        }
    }
}
