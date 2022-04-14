using Android.Graphics;
using Android.Text;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinSDK.Droid;
using XamarinSDK.LocalizeReceipts;

[assembly: Dependency(typeof(PlatformDepends))]

namespace XamarinSDK.Droid
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
            return await Task.Run(() =>
            {
                return CreateBitmap(text, languageIndex, paperSizeIndex);
            });            
        }

        private Stream CreateBitmap(string text, LanguageIndex languageIndex, PaperSizeIndex paperSizeIndex)
        {
            Dictionary<LanguageIndex, Dictionary<PaperSizeIndex, int>> sizeDictionary = new Dictionary<LanguageIndex, Dictionary<PaperSizeIndex, int>>()
            {
                { LanguageIndex.English,            new Dictionary<PaperSizeIndex, int>() { { PaperSizeIndex.TwoInch, 22 }, { PaperSizeIndex.ThreeInch, 25 }, { PaperSizeIndex.FourInch, 23 }, { PaperSizeIndex.EscPosThreeInch, 24 } } },
                { LanguageIndex.Japanese,           new Dictionary<PaperSizeIndex, int>() { { PaperSizeIndex.TwoInch, 22 }, { PaperSizeIndex.ThreeInch, 24 }, { PaperSizeIndex.FourInch, 24 }, { PaperSizeIndex.EscPosThreeInch, 24 } } },
                { LanguageIndex.French,             new Dictionary<PaperSizeIndex, int>() { { PaperSizeIndex.TwoInch, 24 }, { PaperSizeIndex.ThreeInch, 25 }, { PaperSizeIndex.FourInch, 25 }, { PaperSizeIndex.EscPosThreeInch, 24 } } },
                { LanguageIndex.Portuguese,         new Dictionary<PaperSizeIndex, int>() { { PaperSizeIndex.TwoInch, 24 }, { PaperSizeIndex.ThreeInch, 24 }, { PaperSizeIndex.FourInch, 24 }, { PaperSizeIndex.EscPosThreeInch, 24 } } },
                { LanguageIndex.Spanish,            new Dictionary<PaperSizeIndex, int>() { { PaperSizeIndex.TwoInch, 22 }, { PaperSizeIndex.ThreeInch, 24 }, { PaperSizeIndex.FourInch, 24 }, { PaperSizeIndex.EscPosThreeInch, 24 } } },
                { LanguageIndex.German,             new Dictionary<PaperSizeIndex, int>() { { PaperSizeIndex.TwoInch, 24 }, { PaperSizeIndex.ThreeInch, 24 }, { PaperSizeIndex.FourInch, 24 }, { PaperSizeIndex.EscPosThreeInch, 24 } } },
                { LanguageIndex.Russian,            new Dictionary<PaperSizeIndex, int>() { { PaperSizeIndex.TwoInch, 22 }, { PaperSizeIndex.ThreeInch, 25 }, { PaperSizeIndex.FourInch, 25 }, { PaperSizeIndex.EscPosThreeInch, 24 } } },
                { LanguageIndex.SimplifiedChinese,  new Dictionary<PaperSizeIndex, int>() { { PaperSizeIndex.TwoInch, 22 }, { PaperSizeIndex.ThreeInch, 24 }, { PaperSizeIndex.FourInch, 24 }, { PaperSizeIndex.EscPosThreeInch, 24 } } },
                { LanguageIndex.TraditionalChinese, new Dictionary<PaperSizeIndex, int>() { { PaperSizeIndex.TwoInch, 22 }, { PaperSizeIndex.ThreeInch, 24 }, { PaperSizeIndex.FourInch, 24 }, { PaperSizeIndex.EscPosThreeInch, 24 } } }
            };

            Paint paint = new Paint();

            paint.TextSize = sizeDictionary[languageIndex][paperSizeIndex];

            Typeface typeface = Typeface.Create(Typeface.Monospace, TypefaceStyle.Normal);

            paint.SetTypeface(typeface);

            paint.GetTextBounds(text, 0, text.Length, new Rect());

            TextPaint textPaint = new TextPaint(paint);

            StaticLayout staticLayout = new StaticLayout(text, textPaint, (int)paperSizeIndex, Android.Text.Layout.Alignment.AlignNormal, 1, 0, false);

            Bitmap bitmap = Bitmap.CreateBitmap(staticLayout.Width, staticLayout.Height, Bitmap.Config.Argb8888);

            Canvas canvas = new Canvas(bitmap);

            canvas.DrawColor(Android.Graphics.Color.White);

            canvas.Translate(0, 0);

            staticLayout.Draw(canvas);

            MemoryStream memoryStream = new MemoryStream();

            bitmap.Compress(Bitmap.CompressFormat.Png, 100, memoryStream);

            memoryStream.Seek(0, SeekOrigin.Begin);

            return memoryStream;
        }
    }
}