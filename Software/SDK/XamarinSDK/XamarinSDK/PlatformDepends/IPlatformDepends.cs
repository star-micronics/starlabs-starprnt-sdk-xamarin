using System.IO;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinSDK.LocalizeReceipts;

namespace XamarinSDK
{
    public interface IPlatformDepends
    {
        FileImageSource RefreshImage { get; }

        string GetExecutingAssembly();

        Task<Stream> CreateBitmapAsync(string text, LanguageIndex languageIndex, PaperSizeIndex paperSizeIndex);
    }
}
