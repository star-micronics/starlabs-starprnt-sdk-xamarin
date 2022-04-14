using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Graphics.Imaging;
using Windows.Storage.Streams;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Xamarin.Forms;
using XamarinSDK.LocalizeReceipts;
using XamarinSDK.UWP;

[assembly: Dependency(typeof(PlatformDepends))]

namespace XamarinSDK.UWP
{
    public class PlatformDepends : IPlatformDepends
    {
        public FileImageSource RefreshImage
        {
            get
            {
                return new FileImageSource { File = "Assets/Refresh_Image.png" };
            }
        }

        public string GetExecutingAssembly()
        {
            return typeof(PlatformDepends).GetTypeInfo().Assembly.GetName().Version.ToString();
        }

        public async Task<Stream> CreateBitmapAsync(string text, LanguageIndex languageIndex, PaperSizeIndex paperSizeIndex)
        {
            Dictionary<LanguageIndex, Dictionary<PaperSizeIndex, int>> sizeDictionary = new Dictionary<LanguageIndex, Dictionary<PaperSizeIndex, int>>()
            {
                { LanguageIndex.English,            new Dictionary<PaperSizeIndex, int>() { { PaperSizeIndex.TwoInch, 26 }, { PaperSizeIndex.ThreeInch, 30 }, { PaperSizeIndex.FourInch, 29 }, { PaperSizeIndex.EscPosThreeInch, 28 } } },
                { LanguageIndex.Japanese,           new Dictionary<PaperSizeIndex, int>() { { PaperSizeIndex.TwoInch, 24 }, { PaperSizeIndex.ThreeInch, 25 }, { PaperSizeIndex.FourInch, 26 }, { PaperSizeIndex.EscPosThreeInch, 24 } } },
                { LanguageIndex.French,             new Dictionary<PaperSizeIndex, int>() { { PaperSizeIndex.TwoInch, 29 }, { PaperSizeIndex.ThreeInch, 30 }, { PaperSizeIndex.FourInch, 30 }, { PaperSizeIndex.EscPosThreeInch, 28 } } },
                { LanguageIndex.Portuguese,         new Dictionary<PaperSizeIndex, int>() { { PaperSizeIndex.TwoInch, 29 }, { PaperSizeIndex.ThreeInch, 29 }, { PaperSizeIndex.FourInch, 29 }, { PaperSizeIndex.EscPosThreeInch, 29 } } },
                { LanguageIndex.Spanish,            new Dictionary<PaperSizeIndex, int>() { { PaperSizeIndex.TwoInch, 29 }, { PaperSizeIndex.ThreeInch, 30 }, { PaperSizeIndex.FourInch, 29 }, { PaperSizeIndex.EscPosThreeInch, 29 } } },
                { LanguageIndex.German,             new Dictionary<PaperSizeIndex, int>() { { PaperSizeIndex.TwoInch, 29 }, { PaperSizeIndex.ThreeInch, 30 }, { PaperSizeIndex.FourInch, 29 }, { PaperSizeIndex.EscPosThreeInch, 29 } } },
                { LanguageIndex.Russian,            new Dictionary<PaperSizeIndex, int>() { { PaperSizeIndex.TwoInch, 22 }, { PaperSizeIndex.ThreeInch, 25 }, { PaperSizeIndex.FourInch, 26 }, { PaperSizeIndex.EscPosThreeInch, 23 } } },
                { LanguageIndex.SimplifiedChinese,  new Dictionary<PaperSizeIndex, int>() { { PaperSizeIndex.TwoInch, 24 }, { PaperSizeIndex.ThreeInch, 28 }, { PaperSizeIndex.FourInch, 29 }, { PaperSizeIndex.EscPosThreeInch, 27 } } },
                { LanguageIndex.TraditionalChinese, new Dictionary<PaperSizeIndex, int>() { { PaperSizeIndex.TwoInch, 24 }, { PaperSizeIndex.ThreeInch, 29 }, { PaperSizeIndex.FourInch, 29 }, { PaperSizeIndex.EscPosThreeInch, 29 } } }
            };

            Dictionary<LanguageIndex, FontFamily> fontDictionary = new Dictionary<LanguageIndex, FontFamily>()
            {
                { LanguageIndex.English,            new FontFamily("MS Gothic")   },
                { LanguageIndex.Japanese,           new FontFamily("MS Gothic")   },
                { LanguageIndex.French,             new FontFamily("MS Gothic")   },
                { LanguageIndex.Portuguese,         new FontFamily("MS Gothic")   },
                { LanguageIndex.Spanish,            new FontFamily("MS Gothic")   },
                { LanguageIndex.German,             new FontFamily("MS Gothic")   },
                { LanguageIndex.Russian,            new FontFamily("Courier New") },
                { LanguageIndex.SimplifiedChinese,  new FontFamily("MS Gothic")   },
                { LanguageIndex.TraditionalChinese, new FontFamily("MS Gothic")   }
            };

            Windows.UI.Xaml.Controls.Grid grid = new Windows.UI.Xaml.Controls.Grid();

            Windows.UI.Xaml.Controls.RowDefinition rowDefinition = new Windows.UI.Xaml.Controls.RowDefinition();
            grid.RowDefinitions.Add(rowDefinition);

            TextBlock textdata = new TextBlock();
            textdata.Text = text;
            textdata.FontSize = sizeDictionary[languageIndex][paperSizeIndex];
            textdata.FontFamily = fontDictionary[languageIndex];
            textdata.Width = (uint)paperSizeIndex;
            textdata.TextWrapping = TextWrapping.Wrap;

            Windows.UI.Xaml.Controls.Grid.SetRow(textdata, 0);

            grid.Children.Add(textdata);

            StackPanel panel = new StackPanel();
            panel.Background = new SolidColorBrush(Colors.White);
            panel.VerticalAlignment = VerticalAlignment.Top;
            panel.Orientation = Orientation.Horizontal;
            panel.Children.Add(grid);

            Popup popup = new Popup();

            double h = Window.Current.Bounds.Height;
            double w = Window.Current.Bounds.Width;
            popup.HorizontalOffset = -h * 2;
            popup.VerticalOffset = -w * 2;
            popup.Child = panel;
            popup.IsOpen = true;

            RenderTargetBitmap renderTargetBitmap = new RenderTargetBitmap();
            await renderTargetBitmap.RenderAsync(panel);
            popup.IsOpen = false;
            IBuffer pixelBuffer = await renderTargetBitmap.GetPixelsAsync();

            byte[] pixels = pixelBuffer.ToArray();

            InMemoryRandomAccessStream stream = new InMemoryRandomAccessStream();
            BitmapEncoder encoder = await BitmapEncoder.CreateAsync(BitmapEncoder.PngEncoderId, stream);
            encoder.SetPixelData(
                BitmapPixelFormat.Bgra8,
                BitmapAlphaMode.Ignore,
                (uint)renderTargetBitmap.PixelWidth,
                (uint)renderTargetBitmap.PixelHeight,
                72,
                72,
                pixels);

            encoder.BitmapTransform.Rotation = BitmapRotation.None;
            encoder.BitmapTransform.InterpolationMode = BitmapInterpolationMode.Cubic;
            await encoder.FlushAsync();

            return stream.AsStream();
        }
    }
}
