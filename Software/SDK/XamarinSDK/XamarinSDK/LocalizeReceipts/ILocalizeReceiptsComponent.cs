using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StarIoWrapper;

namespace XamarinSDK.LocalizeReceipts
{
    interface ILocalizeReceiptsComponent
    {
        void Append2inchTextReceiptData(ICommandBuilder commandBuilder, bool utf8);
        void Append3inchTextReceiptData(ICommandBuilder commandBuilder, bool utf8);
        void Append4inchTextReceiptData(ICommandBuilder commandBuilder, bool utf8);

        string Create2inchRasterReceiptString();
        string Create3inchRasterReceiptString();
        string Create4inchRasterReceiptString();

        Stream CreateCouponImage();

        string CreateEscPos3inchRasterReceiptString();

        void AppendEscPos3inchTextReceiptData(ICommandBuilder commandBuilder, bool utf8);

        void AppendDotImpact3inchTextReceiptData(ICommandBuilder commandBuilder, bool utf8);

        void AppendTextLabelData(ICommandBuilder commandBuilder, bool utf8);

        string CreatePasteTextLabelString();

        void AppendPasteTextLabelData(ICommandBuilder commandBuilder, string text, bool utf8);

        string LanguageCode { get; }
    }
}
