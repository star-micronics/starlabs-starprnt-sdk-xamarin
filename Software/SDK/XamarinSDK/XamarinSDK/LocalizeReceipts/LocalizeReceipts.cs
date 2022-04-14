using StarIoWrapper;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace XamarinSDK.LocalizeReceipts
{
    class LocalizeReceipts : ILocalizeReceipts
    {
        private ILocalizeReceiptsComponent localizeReceiptsComponent;

        private LanguageIndex  languageIndex;
        private PaperSizeIndex paperSizeIndex;

        public string LanguageCode
        {
            get { return this.localizeReceiptsComponent.LanguageCode; }
        }

        public string PaperSize
        {
            get
            {
                string paperSize;

                switch (this.paperSizeIndex)
                {
                    default                     :
//                  case PaperSizeIndex.TwoInch :
                        paperSize = "2\"";
                        break;
                    case PaperSizeIndex.ThreeInch          :
                    case PaperSizeIndex.EscPosThreeInch    :
                    case PaperSizeIndex.DotImpactThreeInch :
                        paperSize = "3\"";
                        break;
                    case PaperSizeIndex.FourInch :
                        paperSize = "4\"";
                        break;
                }

                return paperSize;
            }
        }

        public string ScalePaperSize
        {
            get
            {
                string paperSize;

                switch (this.paperSizeIndex)
                {
                    default                     :
//                  case PaperSizeIndex.TwoInch :
                        paperSize = "3\"";     // 3inch -> 2inch
                        break;
                    case PaperSizeIndex.ThreeInch          :
                    case PaperSizeIndex.EscPosThreeInch    :
                    case PaperSizeIndex.DotImpactThreeInch :
                        paperSize = "4\"";     // 4inch -> 3inch
                        break;
                    case PaperSizeIndex.FourInch :
                        paperSize = "3\"";     // 3inch -> 4inch
                        break;
                }

                return paperSize;
            }
        }

        public LocalizeReceipts(LanguageIndex languageIndex, PaperSizeIndex paperSizeIndex)
        {
            switch (languageIndex)
            {
                default                    :
//              case LanguageIndex.English :
                    this.localizeReceiptsComponent = new EnglishReceiptsComponent();
                    break;
                case LanguageIndex.Japanese :
                    this.localizeReceiptsComponent = new JapaneseReceiptsComponent();
                    break;
                case LanguageIndex.French :
                    this.localizeReceiptsComponent = new FrenchReceiptsComponent();
                    break;
                case LanguageIndex.Portuguese :
                    this.localizeReceiptsComponent = new PortugueseReceiptsComponent();
                    break;
                case LanguageIndex.Spanish :
                    this.localizeReceiptsComponent = new SpanishReceiptsComponent();
                    break;
                case LanguageIndex.German :
                    this.localizeReceiptsComponent = new GermanReceiptsComponent();
                    break;
                case LanguageIndex.Russian :
                    this.localizeReceiptsComponent = new RussianReceiptsComponent();
                    break;
                case LanguageIndex.SimplifiedChinese :
                    this.localizeReceiptsComponent = new SimplifiedChineseReceiptsComponent();
                    break;
                case LanguageIndex.TraditionalChinese :
                    this.localizeReceiptsComponent = new TraditionalChineseReceiptsComponent();
                    break;
            }

            this.languageIndex  = languageIndex;
            this.paperSizeIndex = paperSizeIndex;
        }

        public void AppendPasteTextLabelData(ICommandBuilder commandBuilder, string text, bool utf8)
        {
            this.localizeReceiptsComponent.AppendPasteTextLabelData(commandBuilder, text, utf8);
        }

        public void AppendTextLabelData(ICommandBuilder commandBuilder, bool utf8)
        {
            this.localizeReceiptsComponent.AppendTextLabelData(commandBuilder, utf8);
        }

        public void AppendTextReceiptData(ICommandBuilder commandBuilder, bool utf8)
        {
            switch (this.paperSizeIndex)
            {
                default                     :
//              case PaperSizeIndex.TwoInch :
                    this.localizeReceiptsComponent.Append2inchTextReceiptData(commandBuilder, utf8);
                    break;
                case PaperSizeIndex.ThreeInch :
                    this.localizeReceiptsComponent.Append3inchTextReceiptData(commandBuilder, utf8);
                    break;
                case PaperSizeIndex.FourInch :
                    this.localizeReceiptsComponent.Append4inchTextReceiptData(commandBuilder, utf8);
                    break;
                case PaperSizeIndex.EscPosThreeInch :
                    this.localizeReceiptsComponent.AppendEscPos3inchTextReceiptData(commandBuilder, utf8);
                    break;
                case PaperSizeIndex.DotImpactThreeInch :
                    this.localizeReceiptsComponent.AppendDotImpact3inchTextReceiptData(commandBuilder, utf8);
                    break;
            }
        }

        public Stream CreateCouponImage()
        {
            return this.localizeReceiptsComponent.CreateCouponImage();
        }

        public string CreatePasteTextLabelString()
        {
            return this.localizeReceiptsComponent.CreatePasteTextLabelString();
        }

        public async Task<Stream> CreateRasterReceiptImageAsync()
        {
            Stream stream = null;
            string text;

            switch (this.paperSizeIndex)
            {
                default:
                    //              case PaperSizeIndex.TwoInch :
                    text = this.localizeReceiptsComponent.Create2inchRasterReceiptString();

                    stream = await App.PlatformDepends.CreateBitmapAsync(text, this.languageIndex, this.paperSizeIndex);
                    break;
                case PaperSizeIndex.ThreeInch:
                    text = this.localizeReceiptsComponent.Create3inchRasterReceiptString();

                    stream = await App.PlatformDepends.CreateBitmapAsync(text, this.languageIndex, this.paperSizeIndex);
                    break;
                case PaperSizeIndex.FourInch:
                    text = this.localizeReceiptsComponent.Create4inchRasterReceiptString();

                    stream = await App.PlatformDepends.CreateBitmapAsync(text, this.languageIndex, this.paperSizeIndex);
                    break;
                case PaperSizeIndex.EscPosThreeInch:
                    text = this.localizeReceiptsComponent.CreateEscPos3inchRasterReceiptString();

                    stream = await App.PlatformDepends.CreateBitmapAsync(text, this.languageIndex, this.paperSizeIndex);
                    break;
                case PaperSizeIndex.DotImpactThreeInch:
                    stream = null;
                    break;
            }

            return stream;
        }

        public async Task<Stream> CreateScaleRasterReceiptImageAsync()
        {
            Stream stream = null;
            string text;

            switch (this.paperSizeIndex)
            {
                default:
                    //              case PaperSizeIndex.TwoInch :
                    text = this.localizeReceiptsComponent.Create3inchRasterReceiptString();     // 3inch -> 2inch

                    stream = await App.PlatformDepends.CreateBitmapAsync(text, this.languageIndex, PaperSizeIndex.ThreeInch);
                    break;
                case PaperSizeIndex.ThreeInch:
                case PaperSizeIndex.EscPosThreeInch:
                    text = this.localizeReceiptsComponent.Create4inchRasterReceiptString();     // 4inch -> 3inch

                    stream = await App.PlatformDepends.CreateBitmapAsync(text, this.languageIndex, PaperSizeIndex.FourInch);
                    break;
                case PaperSizeIndex.FourInch:
                    text = this.localizeReceiptsComponent.Create3inchRasterReceiptString();     // 3inch -> 4inch

                    stream = await App.PlatformDepends.CreateBitmapAsync(text, this.languageIndex, PaperSizeIndex.ThreeInch);
                    break;
                case PaperSizeIndex.DotImpactThreeInch:
                    stream = null;
                    break;
            }

            return stream;
        }
    }
}
