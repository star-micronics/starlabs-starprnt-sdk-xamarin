using StarIoWrapper;
using System.IO;
using System.Threading.Tasks;

namespace XamarinSDK.LocalizeReceipts
{
    public enum LanguageIndex
    {
        English = 0,
        Japanese,
        French,
        Portuguese,
        Spanish,
        German,
        Russian,
        SimplifiedChinese,
        TraditionalChinese
    }

    public enum PaperSizeIndex
    {
        TwoInch            = 384,
        ThreeInch          = 576,
        FourInch           = 832,
        EscPosThreeInch    = 512,
        DotImpactThreeInch = 210
    }

    interface ILocalizeReceipts
    {
        void AppendTextReceiptData(ICommandBuilder commandBuilder, bool utf8);

        Task<Stream> CreateRasterReceiptImageAsync();

        Task<Stream> CreateScaleRasterReceiptImageAsync();

        Stream CreateCouponImage();

        void AppendTextLabelData(ICommandBuilder commandBuilder, bool utf8);

        string CreatePasteTextLabelString();

        void AppendPasteTextLabelData(ICommandBuilder commandBuilder, string text, bool utf8);

        string LanguageCode { get; }

        string PaperSize { get; }

        string ScalePaperSize { get; }
    }
}
