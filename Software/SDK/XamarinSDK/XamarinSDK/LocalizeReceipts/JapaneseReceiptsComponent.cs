using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using StarIoWrapper;

namespace XamarinSDK.LocalizeReceipts
{
    class JapaneseReceiptsComponent : ILocalizeReceiptsComponent
    {
        public string LanguageCode
        {
            get { return "Ja"; }
        }

        public void Append2inchTextReceiptData(ICommandBuilder commandBuilder, bool utf8)
        {
            Encoding encoding;

            if (utf8)
            {
                encoding = Encoding.UTF8;

                commandBuilder.AppendCodePage(CodePageType.UTF8);
            }
            else
            {
                encoding = Encoding.GetEncoding("Shift_JIS");

                commandBuilder.AppendCodePage(CodePageType.CP932);
            }

            commandBuilder.AppendInternational(InternationalType.Japan);

            commandBuilder.AppendCharacterSpace(0);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.AppendEmphasis(true);

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("スター電機\n"), 3);

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("修理報告書　兼領収書\n"), 2);

            commandBuilder.AppendEmphasis(false);

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("--------------------------------\n" +
                                                    "発行日時：YYYY年MM月DD日HH時MM分\n" +
                                                    "TEL：054-347-XXXX\n" +
                                                    "\n" +
                                                    "         ｲｹﾆｼ  ｼｽﾞｺ   ｻﾏ\n" +
                                                    "お名前：池西　静子　様\n" +
                                                    "御住所：静岡市清水区七ツ新屋\n" +
                                                    "　　　　５３６番地\n" +
                                                    "伝票番号：No.12345-67890\n" +
                                                    "\n" +
                                                    "　この度は修理をご用命頂き有難うございます。\n" +
                                                    " 今後も故障など発生した場合はお気軽にご連絡ください。\n" +
                                                    "\n" +
                                                    "品名／型名　数量　金額　備考\n" +
                                                    "--------------------------------\n" +
                                                    "制御基板　　   1 10,000  配達\n" +
                                                    "操作スイッチ   1  3,800  配達\n" +
                                                    "パネル　　　   1  2,000  配達\n" +
                                                    "技術料　　　   1 15,000\n" +
                                                    "出張費用　　   1  5,000\n" +
                                                    "--------------------------------\n" +
                                                    "\n" +
                                                    "             小計      \\ 35,800\n" +
                                                    "             内税      \\  1,790\n" +
                                                    "             合計      \\ 37,590\n" +
                                                    "\n" +
                                                    "　お問合わせ番号　12345-67890\n" +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            //          commandBuilder.AppendBarcode(encoding      .GetBytes("{BStar."), BarcodeSymbology.Code128, BarcodeWidth.Mode2, 40, true);
            //          commandBuilder.AppendBarcode(Encoding.ASCII.GetBytes("{BStar."), BarcodeSymbology.Code128, BarcodeWidth.Mode2, 40, true);
            commandBuilder.AppendBarcode(Encoding.UTF8.GetBytes("{BStar."), BarcodeSymbology.Code128, BarcodeWidth.Mode2, 40, true);
        }

        public void Append3inchTextReceiptData(ICommandBuilder commandBuilder, bool utf8)
        {
            Encoding encoding;

            if (utf8)
            {
                encoding = Encoding.UTF8;

                commandBuilder.AppendCodePage(CodePageType.UTF8);
            }
            else
            {
                encoding = Encoding.GetEncoding("Shift_JIS");

                commandBuilder.AppendCodePage(CodePageType.CP932);
            }

            commandBuilder.AppendInternational(InternationalType.Japan);

            commandBuilder.AppendCharacterSpace(0);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.AppendEmphasis(true);

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("スター電機\n"), 3);

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("修理報告書　兼領収書\n"), 2);

            commandBuilder.AppendEmphasis(false);

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("------------------------------------------------\n" +
                                                    "発行日時：YYYY年MM月DD日HH時MM分\n" +
                                                    "TEL：054-347-XXXX\n" +
                                                    "\n" +
                                                    "           ｲｹﾆｼ  ｼｽﾞｺ   ｻﾏ\n" +
                                                    "　お名前：池西　静子　様\n" +
                                                    "　御住所：静岡市清水区七ツ新屋\n" +
                                                    "　　　　　５３６番地\n" +
                                                    "　伝票番号：No.12345-67890\n" +
                                                    "\n" +
                                                    "　この度は修理をご用命頂き有難うございます。\n" +
                                                    " 今後も故障など発生した場合はお気軽にご連絡ください。\n" +
                                                    "\n" +
                                                    "品名／型名　          数量      金額　   備考\n" +
                                                    "------------------------------------------------\n" +
                                                    "制御基板　          　  1      10,000     配達\n" +
                                                    "操作スイッチ            1       3,800     配達\n" +
                                                    "パネル　　          　  1       2,000     配達\n" +
                                                    "技術料　          　　  1      15,000\n" +
                                                    "出張費用　　            1       5,000\n" +
                                                    "------------------------------------------------\n" +
                                                    "\n" +
                                                    "                            小計       \\ 35,800\n" +
                                                    "                            内税       \\  1,790\n" +
                                                    "                            合計       \\ 37,590\n" +
                                                    "\n" +
                                                    "　お問合わせ番号　　12345-67890\n" +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            //          commandBuilder.AppendBarcode(encoding      .GetBytes("{BStar."), BarcodeSymbology.Code128, BarcodeWidth.Mode2, 40, true);
            //          commandBuilder.AppendBarcode(Encoding.ASCII.GetBytes("{BStar."), BarcodeSymbology.Code128, BarcodeWidth.Mode2, 40, true);
            commandBuilder.AppendBarcode(Encoding.UTF8.GetBytes("{BStar."), BarcodeSymbology.Code128, BarcodeWidth.Mode2, 40, true);
        }

        public void Append4inchTextReceiptData(ICommandBuilder commandBuilder, bool utf8)
        {
            Encoding encoding;

            if (utf8)
            {
                encoding = Encoding.UTF8;

                commandBuilder.AppendCodePage(CodePageType.UTF8);
            }
            else
            {
                encoding = Encoding.GetEncoding("Shift_JIS");

                commandBuilder.AppendCodePage(CodePageType.CP932);
            }

            commandBuilder.AppendInternational(InternationalType.Japan);

            commandBuilder.AppendCharacterSpace(0);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.AppendEmphasis(true);

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("スター電機\n"), 3);

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("修理報告書　兼領収書\n"), 2);

            commandBuilder.AppendEmphasis(false);

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("---------------------------------------------------------------------\n" +
                                                    "発行日時：YYYY年MM月DD日HH時MM分\n" +
                                                    "TEL：054-347-XXXX\n" +
                                                    "\n" +
                                                    "           ｲｹﾆｼ  ｼｽﾞｺ   ｻﾏ\n" +
                                                    "　お名前：池西　静子　様\n" +
                                                    "　御住所：静岡市清水区七ツ新屋\n" +
                                                    "　　　　　５３６番地\n" +
                                                    "　伝票番号：No.12345-67890\n" +
                                                    "\n" +
                                                    "この度は修理をご用命頂き有難うございます。\n" +
                                                    " 今後も故障など発生した場合はお気軽にご連絡ください。\n" +
                                                    "\n" +
                                                    "品名／型名　                 数量             金額　          備考\n" +
                                                    "---------------------------------------------------------------------\n" +
                                                    "制御基板　　                   1             10,000            配達\n" +
                                                    "操作スイッチ                   1              3,800            配達\n" +
                                                    "パネル　　　                   1              2,000            配達\n" +
                                                    "技術料　　　                   1             15,000\n" +
                                                    "出張費用　　                   1              5,000\n" +
                                                    "---------------------------------------------------------------------\n" +
                                                    "\n" +
                                                    "                                                 小計       \\ 35,800\n" +
                                                    "                                                 内税       \\  1,790\n" +
                                                    "                                                 合計       \\ 37,590\n" +
                                                    "\n" +
                                                    "　お問合わせ番号　　12345-67890\n" +
                                                    "\n" +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            //          commandBuilder.AppendBarcode(encoding      .GetBytes("{BStar."), BarcodeSymbology.Code128, BarcodeWidth.Mode2, 40, true);
            //          commandBuilder.AppendBarcode(Encoding.ASCII.GetBytes("{BStar."), BarcodeSymbology.Code128, BarcodeWidth.Mode2, 40, true);
            commandBuilder.AppendBarcode(Encoding.UTF8.GetBytes("{BStar."), BarcodeSymbology.Code128, BarcodeWidth.Mode2, 40, true);
        }

        public void AppendDotImpact3inchTextReceiptData(ICommandBuilder commandBuilder, bool utf8)
        {
            Encoding encoding;

            if (utf8)
            {
                encoding = Encoding.UTF8;

                commandBuilder.AppendCodePage(CodePageType.UTF8);
            }
            else
            {
                encoding = Encoding.GetEncoding("Shift_JIS");

                commandBuilder.AppendCodePage(CodePageType.CP932);
            }

            commandBuilder.AppendInternational(InternationalType.Japan);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.AppendEmphasis(true);

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("スター電機\n" +
                                                                  "修理報告書　兼領収書\n"), 2);

            commandBuilder.AppendEmphasis(false);

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("------------------------------------------\n" +
                                                    "発行日時：YYYY年MM月DD日HH時MM分\n" +
                                                    "TEL：054-347-XXXX\n" +
                                                    "\n" +
                                                    "        ｲｹﾆｼ  ｼｽﾞｺ  ｻﾏ\n" +
                                                    "　お名前：池西  静子　様\n" +
                                                    "　御住所：静岡市清水区七ツ新屋\n" +
                                                    "　　　　　５３６番地\n" +
                                                    "　伝票番号：No.12345-67890\n" +
                                                    "\n" +
                                                    "　この度は修理をご用命頂き有難うございます。\n" +
                                                    " 今後も故障など発生した場合はお気軽にご連絡ください。\n" +
                                                    "\n" +
                                                    "品名／型名　     数量      金額　     備考\n" +
                                                    "------------------------------------------\n" +
                                                    "制御基板　　       1      10,000     配達\n" +
                                                    "操作スイッチ       1       3,800     配達\n" +
                                                    "パネル　　　       1       2,000     配達\n" +
                                                    "技術料　　　       1      15,000\n" +
                                                    "出張費用　　       1       5,000\n" +
                                                    "------------------------------------------\n" +
                                                    "\n" +
                                                    "                       小計       \\ 35,800\n" +
                                                    "                       内税       \\  1,790\n" +
                                                    "                       合計       \\ 37,590\n" +
                                                    "\n" +
                                                    "　お問合わせ番号　　12345-67890\n"));
        }

        public void AppendEscPos3inchTextReceiptData(ICommandBuilder commandBuilder, bool utf8)
        {
            Encoding encoding;

            if (utf8)
            {
                encoding = Encoding.UTF8;

                commandBuilder.AppendCodePage(CodePageType.UTF8);
            }
            else
            {
                encoding = Encoding.GetEncoding("Shift_JIS");

                commandBuilder.AppendCodePage(CodePageType.CP932);
            }

            commandBuilder.AppendInternational(InternationalType.Japan);

            commandBuilder.AppendCharacterSpace(0);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.AppendEmphasis(true);

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("スター電機\n"), 3);

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("修理報告書　兼領収書\n"), 2);

            commandBuilder.AppendEmphasis(false);

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("------------------------------------------\n" +
                                                    "発行日時：YYYY年MM月DD日HH時MM分\n" +
                                                    "TEL：054-347-XXXX\n" +
                                                    "\n" +
                                                    "           ｲｹﾆｼ  ｼｽﾞｺ   ｻﾏ\n" +
                                                    "　お名前：池西　静子　様\n" +
                                                    "　御住所：静岡市清水区七ツ新屋\n" +
                                                    "　　　　　５３６番地\n" +
                                                    "　伝票番号：No.12345-67890\n" +
                                                    "\n" +
                                                    "　この度は修理をご用命頂き有難うございます。\n" +
                                                    " 今後も故障など発生した場合はお気軽にご連絡ください。\n" +
                                                    "\n" +
                                                    "品名／型名        数量      金額　   備考\n" +
                                                    "------------------------------------------\n" +
                                                    "制御基板　          1     10,000     配達\n" +
                                                    "操作スイッチ        1      3,800     配達\n" +
                                                    "パネル　　          1      2,000     配達\n" +
                                                    "技術料　            1     15,000\n" +
                                                    "出張費用　　        1      5,000\n" +
                                                    "------------------------------------------\n" +
                                                    "\n" +
                                                    "                      小計       \\ 35,800\n" +
                                                    "                      内税       \\  1,790\n" +
                                                    "                      合計       \\ 37,590\n" +
                                                    "\n" +
                                                    "　お問合わせ番号　　12345-67890\n" +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            //          commandBuilder.AppendBarcode(encoding      .GetBytes("{BStar."), BarcodeSymbology.Code128, BarcodeWidth.Mode2, 40, true);
            //          commandBuilder.AppendBarcode(Encoding.ASCII.GetBytes("{BStar."), BarcodeSymbology.Code128, BarcodeWidth.Mode2, 40, true);
            commandBuilder.AppendBarcode(Encoding.UTF8.GetBytes("{BStar."), BarcodeSymbology.Code128, BarcodeWidth.Mode2, 40, true);
        }

        public void AppendPasteTextLabelData(ICommandBuilder commandBuilder, string text, bool utf8)
        {
            Encoding encoding;

            if (utf8)
            {
                encoding = Encoding.UTF8;

                commandBuilder.AppendCodePage(CodePageType.UTF8);
            }
            else
            {
                encoding = Encoding.GetEncoding("Shift_JIS");

                commandBuilder.AppendCodePage(CodePageType.CP932);
            }

            commandBuilder.AppendInternational(InternationalType.Japan);

            commandBuilder.AppendCharacterSpace(0);

            commandBuilder.Append(encoding.GetBytes(text));
        }

        public void AppendTextLabelData(ICommandBuilder commandBuilder, bool utf8)
        {
            Encoding encoding;

            if (utf8)
            {
                encoding = Encoding.UTF8;

                commandBuilder.AppendCodePage(CodePageType.UTF8);
            }
            else
            {
                encoding = Encoding.GetEncoding("Shift_JIS");

                commandBuilder.AppendCodePage(CodePageType.CP932);
            }

            commandBuilder.AppendInternational(InternationalType.Japan);

            commandBuilder.AppendCharacterSpace(0);

            commandBuilder.AppendUnitFeed(20 * 2);

            commandBuilder.AppendMultipleHeight(2);

            commandBuilder.Append(encoding.GetBytes("〒422-8654"));

            commandBuilder.AppendUnitFeed(64);

            commandBuilder.Append(encoding.GetBytes("静岡県静岡市駿河区中吉田20番10号"));

            commandBuilder.AppendUnitFeed(64);

            commandBuilder.Append(encoding.GetBytes("スター精密株式会社"));

            commandBuilder.AppendUnitFeed(64);

            commandBuilder.AppendMultipleHeight(1);
        }

        public string Create2inchRasterReceiptString()
        {
            return "　　　　　　スター電機\n" +
                   "　　　　修理報告書　兼領収書\n" +
                   "----------------------------\n" +
                   "発行日時：YYYY年MM月DD日HH時MM分\n" +
                   "TEL：054-347-XXXX\n" +
                   "\n" +
                   "　　　　　ｲｹﾆｼ  ｼｽﾞｺ  ｻﾏ\n" +
                   "　お名前：池西　静子　様\n" +
                   "　御住所：静岡市清水区七ツ新屋\n" +
                   "　　　　　５３６番地\n" +
                   "　伝票番号：No.12345-67890\n" +
                   "\n" +
                   "　この度は修理をご用命頂き有難うございます。\n" +
                   " 今後も故障など発生した場合はお気軽にご連絡ください。\n" +
                   "\n" +
                   "品名／型名　 数量　　金額\n" +
                   "----------------------------\n" +
                   "制御基板　　　１　　１０，０００\n" +
                   "操作スイッチ　１　　　３，０００\n" +
                   "パネル　　　　１　　　２，０００\n" +
                   "技術料　　　　１　　１５，０００\n" +
                   "出張費用　　　１　　　５，０００\n" +
                   "----------------------------\n" +
                   "\n" +
                   "　　　　　　小計　¥ ３５，８００\n" +
                   "　　　　　　内税　¥ 　１，７９０\n" +
                   "　　　　　　合計　¥ ３７，５９０\n" +
                   "\n" +
                   "　お問合わせ番号　　12345-67890\n";
        }

        public string Create3inchRasterReceiptString()
        {
            return "　　　　　　　　　　スター電機\n" +
                   "　　　　　　　　修理報告書　兼領収書\n" +
                   "---------------------------------------\n" +
                   "発行日時：YYYY年MM月DD日HH時MM分\n" +
                   "TEL：054-347-XXXX\n" +
                   "\n" +
                   "　　　　　ｲｹﾆｼ  ｼｽﾞｺ  ｻﾏ\n" +
                   "　お名前：池西　静子　様\n" +
                   "　御住所：静岡市清水区七ツ新屋\n" +
                   "　　　　　５３６番地\n" +
                   "　伝票番号：No.12345-67890\n" +
                   "\n" +
                   "　この度は修理をご用命頂き有難うございます。\n" +
                   " 今後も故障など発生した場合はお気軽にご連絡ください。\n" +
                   "\n" +
                   "品名／型名　　　　数量　　　金額　　　　備考\n" +
                   "---------------------------------------\n" +
                   "制御基板　　　　　　１　１０，０００　　配達\n" +
                   "操作スイッチ　　　　１　　３，８００　　配達\n" +
                   "パネル　　　　　　　１　　２，０００　　配達\n" +
                   "技術料　　　　　　　１　１５，０００\n" +
                   "出張費用　　　　　　１　　５，０００\n" +
                   "---------------------------------------\n" +
                   "\n" +
                   "　　　　　　　　　　　　小計　¥ ３５，８００\n" +
                   "　　　　　　　　　　　　内税　¥ 　１，７９０\n" +
                   "　　　　　　　　　　　　合計　¥ ３７，５９０\n" +
                   "\n" +
                   "　お問合わせ番号　　12345-67890\n";
        }

        public string Create4inchRasterReceiptString()
        {
            return "　　　　　　　　　　　　　　　スター電機\n" +
                   "　　　　　　　　　　　　　修理報告書　兼領収書\n" +
                   "---------------------------------------------------------\n" +
                   "発行日時：YYYY年MM月DD日HH時MM分\n" +
                   "TEL：054-347-XXXX\n" +
                   "\n" +
                   "　　　　　ｲｹﾆｼ  ｼｽﾞｺ  ｻﾏ\n" +
                   "　お名前：池西　静子　様\n" +
                   "　御住所：静岡市清水区七ツ新屋\n" +
                   "　　　　　５３６番地\n" +
                   "　伝票番号：No.12345-67890\n" +
                   "\n" +
                   "　この度は修理をご用命頂き有難うございます。\n" +
                   " 今後も故障など発生した場合はお気軽にご連絡ください。\n" +
                   "\n" +
                   "品名／型名　　　　　　　　　数量　　　　　　金額　　　　　　備考\n" +
                   "---------------------------------------------------------\n" +
                   "制御基板　　　　　　　　　　　１　　　　１０，０００　　　　配達\n" +
                   "操作スイッチ　　　　　　　　　１　　　　　３，８００　　　　配達\n" +
                   "パネル　　　　　　　　　　　　１　　　　　２，０００　　　　配達\n" +
                   "技術料　　　　　　　　　　　　１　　　　１５，０００\n" +
                   "出張費用　　　　　　　　　　　１　　　　　５，０００\n" +
                   "---------------------------------------------------------\n" +
                   "\n" +
                   "　　　　　　　　　　　　　　　　　　　　　　小計　¥ ３５，８００\n" +
                   "　　　　　　　　　　　　　　　　　　　　　　内税　¥ 　１，７９０\n" +
                   "　　　　　　　　　　　　　　　　　　　　　　合計　¥ ３７，５９０\n" +
                   "\n" +
                   "　お問合わせ番号　　12345-67890\n";
        }

        public Stream CreateCouponImage()
        {
            Assembly assembly = typeof(JapaneseReceiptsComponent).GetTypeInfo().Assembly;

            return assembly.GetManifestResourceStream("XamarinSDK.Resources.JapaneseCouponImage.png");
        }

        public string CreateEscPos3inchRasterReceiptString()
        {
            return "　　　　　　　 スター電機\n" +
                   "　　　　　 修理報告書　兼領収書\n" +
                   "-----------------------------------\n" +
                   "発行日時：YYYY年MM月DD日HH時MM分\n" +
                   "TEL：054-347-XXXX\n" +
                   "\n" +
                   "　　　　　ｲｹﾆｼ  ｼｽﾞｺ  ｻﾏ\n" +
                   "　お名前：池西　静子　様\n" +
                   "　御住所：静岡市清水区七ツ新屋\n" +
                   "　　　　　５３６番地\n" +
                   "　伝票番号：No.12345-67890\n" +
                   "\n" +
                   "　この度は修理をご用命頂き有難うございます。\n" +
                   " 今後も故障など発生した場合はお気軽にご連絡ください。\n" +
                   "\n" +
                   "品名／型名　　　数量　　　金額　　　　備考\n" +
                   "-----------------------------------\n" +
                   "制御基板　　     １　１０，０００　　配達\n" +
                   "操作スイッチ     １　　３，８００　　配達\n" +
                   "パネル　　　     １　　２，０００　　配達\n" +
                   "技術料　　　     １　１５，０００\n" +
                   "出張費用　　     １　　５，０００\n" +
                   "-----------------------------------\n" +
                   "\n" +
                   "　　　　　　　　　　　小計　¥ ３５，８００\n" +
                   "　　　　　　　　　　　内税　¥ 　１，７９０\n" +
                   "　　　　　　　　　　　合計　¥ ３７，５９０\n" +
                   "\n" +
                   "　お問合わせ番号　　12345-67890\n";
        }

        public string CreatePasteTextLabelString()
        {
            return "〒422-8654\n" +
                   "静岡県静岡市駿河区中吉田20番10号\n" +
                   "スター精密株式会社";
        }
    }
}
