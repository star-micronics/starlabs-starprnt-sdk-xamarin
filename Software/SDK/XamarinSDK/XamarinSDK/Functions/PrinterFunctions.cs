using StarIoWrapper;
using System.IO;
using System.Threading.Tasks;

namespace XamarinSDK.Functions
{
    class PrinterFunctions
    {
        public static byte[] CreateTextReceiptData(StarIoExtEmulation emulation, LocalizeReceipts.ILocalizeReceipts localizeReceipts, bool utf8)
        {
            ICommandBuilder commandBuilder = Extension.CreateCommandBuilder(emulation);

            commandBuilder.BeginDocument();

            localizeReceipts.AppendTextReceiptData(commandBuilder, utf8);

            commandBuilder.AppendCutPaper(CutPaperAction.PartialCutWithFeed);

            commandBuilder.EndDocument();

            return commandBuilder.Commands;
        }

        public async static Task<byte[]> CreateRasterReceiptData(StarIoExtEmulation emulation, LocalizeReceipts.ILocalizeReceipts localizeReceipts)
        {
            Stream stream = await localizeReceipts.CreateRasterReceiptImageAsync();

            ICommandBuilder commandBuilder = Extension.CreateCommandBuilder(emulation);

            commandBuilder.BeginDocument();

            commandBuilder.AppendBitmap(stream, false);

            commandBuilder.AppendCutPaper(CutPaperAction.PartialCutWithFeed);

            commandBuilder.EndDocument();

            return commandBuilder.Commands;
        }

        public async static Task<byte[]> CreateScaleRasterReceiptData(StarIoExtEmulation emulation, LocalizeReceipts.ILocalizeReceipts localizeReceipts, int width, bool bothScale)
        {
            Stream stream = await localizeReceipts.CreateScaleRasterReceiptImageAsync();

            ICommandBuilder commandBuilder = Extension.CreateCommandBuilder(emulation);

            commandBuilder.BeginDocument();

            commandBuilder.AppendBitmap(stream, false, width, bothScale);

            commandBuilder.AppendCutPaper(CutPaperAction.PartialCutWithFeed);

            commandBuilder.EndDocument();

            return commandBuilder.Commands;
        }

        public static byte[] CreateCouponData(StarIoExtEmulation emulation, LocalizeReceipts.ILocalizeReceipts localizeReceipts, int width, BitmapConverterRotation rotation)
        {
            Stream stream = localizeReceipts.CreateCouponImage();

            ICommandBuilder commandBuilder = Extension.CreateCommandBuilder(emulation);

            commandBuilder.BeginDocument();

            commandBuilder.AppendBitmap(stream, false, width, true, rotation);

            commandBuilder.AppendCutPaper(CutPaperAction.PartialCutWithFeed);

            commandBuilder.EndDocument();

            return commandBuilder.Commands;
        }

        public static byte[] CreateTextBlackMarkData(StarIoExtEmulation emulation, LocalizeReceipts.ILocalizeReceipts localizeReceipts, BlackMarkType type, bool utf8)
        {
            ICommandBuilder commandBuilder = Extension.CreateCommandBuilder(emulation);

            commandBuilder.BeginDocument();

            commandBuilder.AppendBlackMark(type);

            localizeReceipts.AppendTextLabelData(commandBuilder, utf8);

            commandBuilder.AppendCutPaper(CutPaperAction.PartialCutWithFeed);

//          commandBuilder.AppendBlackMark(BlackMarkType.Invalid);

            commandBuilder.EndDocument();

            return commandBuilder.Commands;
        }

        public static byte[] CreatePasteTextBlackMarkData(StarIoExtEmulation emulation, LocalizeReceipts.ILocalizeReceipts localizeReceipts, string text, bool doubleHeight, BlackMarkType type, bool utf8)
        {
            ICommandBuilder commandBuilder = Extension.CreateCommandBuilder(emulation);

            commandBuilder.BeginDocument();

            commandBuilder.AppendBlackMark(type);

            if (doubleHeight)
            {
                commandBuilder.AppendMultipleHeight(2);

                localizeReceipts.AppendPasteTextLabelData(commandBuilder, text, utf8);

                commandBuilder.AppendMultipleHeight(1);
            }
            else
            {
                localizeReceipts.AppendPasteTextLabelData(commandBuilder, text, utf8);
            }

            commandBuilder.AppendCutPaper(CutPaperAction.PartialCutWithFeed);

//          commandBuilder.AppendBlackMark(BlackMarkType.Invalid);

            commandBuilder.EndDocument();

            return commandBuilder.Commands;
        }

        public static byte[] CreateTextPageModeData(StarIoExtEmulation emulation, LocalizeReceipts.ILocalizeReceipts localizeReceipts, Rectangle rectangle, BitmapConverterRotation rotation, bool utf8)
        {
            ICommandBuilder commandBuilder = Extension.CreateCommandBuilder(emulation);

            commandBuilder.BeginDocument();

            commandBuilder.BeginPageMode(rectangle, rotation);

            localizeReceipts.AppendTextLabelData(commandBuilder, utf8);

            commandBuilder.EndPageMode();

            commandBuilder.AppendCutPaper(CutPaperAction.PartialCutWithFeed);

            commandBuilder.EndDocument();

            return commandBuilder.Commands;
        }
    }
}
