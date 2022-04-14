using CoreGraphics;
using Foundation;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using UIKit;
using Xamarin.Forms;
using XamarinSDK.iOS;
using XamarinSDK.LocalizeReceipts;

[assembly: Dependency(typeof(PlatformDepends))]

namespace XamarinSDK.iOS
{
    public class PlatformDepends : IPlatformDepends
    {
        public FileImageSource RefreshImage
        {
            get
            {
                return null;
            }
        }

        public string GetExecutingAssembly()
        {
            return typeof(PlatformDepends).GetTypeInfo().Assembly.GetName().Version.ToString();
        }

        public async Task<Stream> CreateBitmapAsync(string text, LanguageIndex languageIndex, PaperSizeIndex paperSizeIndex)
        {
            Stream bitmap = CreateBitmap(text, languageIndex, paperSizeIndex);

            return await Task.Run(() =>
            {
                return bitmap;
            });
        }

        public Stream CreateBitmap(string text, LanguageIndex languageIndex, PaperSizeIndex paperSizeIndex)
        {
            Dictionary<LanguageIndex, Dictionary<PaperSizeIndex, int>> sizeDictionary = new Dictionary<LanguageIndex, Dictionary<PaperSizeIndex, int>>()
            {
                { LanguageIndex.English,            new Dictionary<PaperSizeIndex, int>() { { PaperSizeIndex.TwoInch, 10 * 2 }, { PaperSizeIndex.ThreeInch, 12 * 2 }, { PaperSizeIndex.FourInch, 12 * 2 }, { PaperSizeIndex.EscPosThreeInch, 12 * 2 } } },
                { LanguageIndex.Japanese,           new Dictionary<PaperSizeIndex, int>() { { PaperSizeIndex.TwoInch, 11 * 2 }, { PaperSizeIndex.ThreeInch, 12 * 2 }, { PaperSizeIndex.FourInch, 12 * 2 }, { PaperSizeIndex.EscPosThreeInch, 12 * 2 } } },
                { LanguageIndex.French,             new Dictionary<PaperSizeIndex, int>() { { PaperSizeIndex.TwoInch, 12 * 2 }, { PaperSizeIndex.ThreeInch, 12 * 2 }, { PaperSizeIndex.FourInch, 12 * 2 }, { PaperSizeIndex.EscPosThreeInch, 12 * 2 } } },
                { LanguageIndex.Portuguese,         new Dictionary<PaperSizeIndex, int>() { { PaperSizeIndex.TwoInch, 12 * 2 }, { PaperSizeIndex.ThreeInch, 12 * 2 }, { PaperSizeIndex.FourInch, 12 * 2 }, { PaperSizeIndex.EscPosThreeInch, 12 * 2 } } },
                { LanguageIndex.Spanish,            new Dictionary<PaperSizeIndex, int>() { { PaperSizeIndex.TwoInch, 12 * 2 }, { PaperSizeIndex.ThreeInch, 12 * 2 }, { PaperSizeIndex.FourInch, 12 * 2 }, { PaperSizeIndex.EscPosThreeInch, 12 * 2 } } },
                { LanguageIndex.German,             new Dictionary<PaperSizeIndex, int>() { { PaperSizeIndex.TwoInch, 12 * 2 }, { PaperSizeIndex.ThreeInch, 12 * 2 }, { PaperSizeIndex.FourInch, 12 * 2 }, { PaperSizeIndex.EscPosThreeInch, 12 * 2 } } },
                { LanguageIndex.Russian,            new Dictionary<PaperSizeIndex, int>() { { PaperSizeIndex.TwoInch, 11 * 2 }, { PaperSizeIndex.ThreeInch, 12 * 2 }, { PaperSizeIndex.FourInch, 12 * 2 }, { PaperSizeIndex.EscPosThreeInch, 12 * 2 } } },
                { LanguageIndex.SimplifiedChinese,  new Dictionary<PaperSizeIndex, int>() { { PaperSizeIndex.TwoInch, 11 * 2 }, { PaperSizeIndex.ThreeInch, 12 * 2 }, { PaperSizeIndex.FourInch, 12 * 2 }, { PaperSizeIndex.EscPosThreeInch, 12 * 2 } } },
                { LanguageIndex.TraditionalChinese, new Dictionary<PaperSizeIndex, int>() { { PaperSizeIndex.TwoInch, 11 * 2 }, { PaperSizeIndex.ThreeInch, 12 * 2 }, { PaperSizeIndex.FourInch, 12 * 2 }, { PaperSizeIndex.EscPosThreeInch, 12 * 2 } } }
            };

            NSString nativeText = new NSString(text);

            UIFont font = UIFont.FromName("Menlo", sizeDictionary[languageIndex][paperSizeIndex]);

            UIStringAttributes stringAttributes = new UIStringAttributes
            {
                Font = font,
                ForegroundColor = UIColor.Black
            };

            CGSize size = NSExtendedStringDrawing.GetBoundingRect(nativeText,
                                                                  new CGSize((int)paperSizeIndex, 10000),
                                                                  NSStringDrawingOptions.UsesLineFragmentOrigin | NSStringDrawingOptions.TruncatesLastVisibleLine,
                                                                  stringAttributes,
                                                                  null).Size;

            if (UIScreen.MainScreen.RespondsToSelector(new ObjCRuntime.Selector("scale")))
            {
                if (UIScreen.MainScreen.Scale == 2.0)
                {
                    UIGraphics.BeginImageContextWithOptions(size, false, 1.0f);
                }
                else
                {
                    UIGraphics.BeginImageContext(size);
                }
            }
            else
            {
                UIGraphics.BeginImageContext(size);
            }

            CGContext context = UIGraphics.GetCurrentContext();

            UIColor.White.SetColor();

            CGRect rect = new CGRect(0, 0, size.Width + 1, size.Height + 1);

            context.FillRect(rect);

            NSDictionary attributes = new NSDictionary("NSForegroundColorAttributeName", UIColor.Black, "NSFontAttributeName", font);

            (new NSAttributedString(nativeText, stringAttributes)).DrawString(rect);

            UIImage image = UIGraphics.GetImageFromCurrentImageContext();

            UIGraphics.EndImageContext();

            return image.AsPNG().AsStream();
        }
    }
}