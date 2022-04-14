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
    class TraditionalChineseReceiptsComponent : ILocalizeReceiptsComponent
    {
        public string LanguageCode
        {
            get { return "zh-TW"; }
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
                encoding = Encoding.GetEncoding("big5");

//              commandBuilder.AppendCodePage(CodePageType.CP1252);
            }

//          commandBuilder.AppendInternational(InternationalType.UK);

            commandBuilder.AppendCharacterSpace(0);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.AppendEmphasis(true);

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("Star Micronics\n"), 3);

            commandBuilder.AppendEmphasis(false);

            commandBuilder.Append(encoding.GetBytes("--------------------------------\n"));

            commandBuilder.AppendMultiple(encoding.GetBytes("電子發票證明聯\n" +
                                                            "103年01-02月\n"   +
                                                            "EV-99999999\n"), 2, 2);

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("2014/01/15 13:00\n"            +
                                                    "隨機碼 : 9999    總計 : 999\n" +
                                                    "賣方 : 99999999\n"             +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

//          commandBuilder.AppendQrCode(encoding      .GetBytes("http://www.star-m.jp/eng/index.html"), QrCodeModel.No2, QrCodeLevel.Q, 5);
//          commandBuilder.AppendQrCode(Encoding.ASCII.GetBytes("http://www.star-m.jp/eng/index.html"), QrCodeModel.No2, QrCodeLevel.Q, 5);
            commandBuilder.AppendQrCode(Encoding.UTF8 .GetBytes("http://www.star-m.jp/eng/index.html"), QrCodeModel.No2, QrCodeLevel.Q, 5);

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("\n"                                   +
                                                    "商品退換請持本聯及銷貨明細表。\n"     +
                                                    "9999999-9999999 999999-999999 9999\n" +
                                                    "\n"));

            commandBuilder.AppendAlignment(encoding.GetBytes("銷貨明細表 　(銷售)\n"), AlignmentPosition.Center);

            commandBuilder.AppendAlignment(encoding.GetBytes("2014-01-15 13:00:02\n"), AlignmentPosition.Right);

            commandBuilder.Append(encoding.GetBytes("\n"                                 +
                                                    "烏龍袋茶2g20入       55 x2 110TX\n" +
                                                    "茉莉烏龍茶2g20入     55 x2 110TX\n" +
                                                    "天仁觀音茶2g*20      55 x2 110TX\n"));

            commandBuilder.AppendEmphasis(encoding.GetBytes("      小　 計 :              330\n" +
                                                            "      總   計 :              330\n"));

            commandBuilder.Append(encoding.GetBytes("--------------------------------\n" +
                                                    "現 金                        400\n" +
                                                    "      找　 零 :               70\n"));

            commandBuilder.AppendEmphasis(encoding.GetBytes(" 101 發票金額 :              330\n"));

            commandBuilder.Append(encoding.GetBytes("2014-01-15 13:00\n" +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

//          commandBuilder.AppendBarcode(encoding      .GetBytes("{BStar."), BarcodeSymbology.Code128, BarcodeWidth.Mode2, 40, true);
//          commandBuilder.AppendBarcode(Encoding.ASCII.GetBytes("{BStar."), BarcodeSymbology.Code128, BarcodeWidth.Mode2, 40, true);
            commandBuilder.AppendBarcode(Encoding.UTF8 .GetBytes("{BStar."), BarcodeSymbology.Code128, BarcodeWidth.Mode2, 40, true);

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("\n"                                   +
                                                    "商品退換、贈品及停車兌換請持本聯。\n" +
                                                    "9999999-9999999 999999-999999 9999\n"));
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
                encoding = Encoding.GetEncoding("big5");

//              commandBuilder.AppendCodePage(CodePageType.CP1252);
            }

//          commandBuilder.AppendInternational(InternationalType.UK);

            commandBuilder.AppendCharacterSpace(0);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.AppendEmphasis(true);

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("Star Micronics\n"), 3);

            commandBuilder.AppendEmphasis(false);

            commandBuilder.Append(encoding.GetBytes("------------------------------------------------\n"));

            commandBuilder.AppendMultiple(encoding.GetBytes("電子發票證明聯\n" +
                                                            "103年01-02月\n"   +
                                                            "EV-99999999\n"), 2, 2);

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("2014/01/15 13:00\n"            +
                                                    "隨機碼 : 9999    總計 : 999\n" +
                                                    "賣方 : 99999999\n"             +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

//          commandBuilder.AppendQrCode(encoding      .GetBytes("http://www.star-m.jp/eng/index.html"), QrCodeModel.No2, QrCodeLevel.Q, 5);
//          commandBuilder.AppendQrCode(Encoding.ASCII.GetBytes("http://www.star-m.jp/eng/index.html"), QrCodeModel.No2, QrCodeLevel.Q, 5);
            commandBuilder.AppendQrCode(Encoding.UTF8 .GetBytes("http://www.star-m.jp/eng/index.html"), QrCodeModel.No2, QrCodeLevel.Q, 5);

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("\n"                                   +
                                                    "商品退換請持本聯及銷貨明細表。\n"     +
                                                    "9999999-9999999 999999-999999 9999\n" +
                                                    "\n"));

            commandBuilder.AppendAlignment(encoding.GetBytes("銷貨明細表 　(銷售)\n"), AlignmentPosition.Center);

            commandBuilder.AppendAlignment(encoding.GetBytes("2014-01-15 13:00:02\n"), AlignmentPosition.Right);

            commandBuilder.Append(encoding.GetBytes("\n"                                          +
                                                    "烏龍袋茶2g20入                55 x2 110TX\n" +
                                                    "茉莉烏龍茶2g20入              55 x2 110TX\n" +
                                                    "天仁觀音茶2g*20               55 x2 110TX\n"));

            commandBuilder.AppendEmphasis(encoding.GetBytes("      小　 計 :                330\n" +
                                                            "      總   計 :                330\n"));

            commandBuilder.Append(encoding.GetBytes("------------------------------------------------\n" +
                                                    "現 金                          400\n"               +
                                                    "      找　 零 :                 70\n"));

            commandBuilder.AppendEmphasis(encoding.GetBytes(" 101 發票金額 :                330\n"));

            commandBuilder.Append(encoding.GetBytes("2014-01-15 13:00\n" +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

//          commandBuilder.AppendBarcode(encoding      .GetBytes("{BStar."), BarcodeSymbology.Code128, BarcodeWidth.Mode2, 40, true);
//          commandBuilder.AppendBarcode(Encoding.ASCII.GetBytes("{BStar."), BarcodeSymbology.Code128, BarcodeWidth.Mode2, 40, true);
            commandBuilder.AppendBarcode(Encoding.UTF8 .GetBytes("{BStar."), BarcodeSymbology.Code128, BarcodeWidth.Mode2, 40, true);

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("\n"                                   +
                                                    "商品退換、贈品及停車兌換請持本聯。\n" +
                                                    "9999999-9999999 999999-999999 9999\n"));
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
                encoding = Encoding.GetEncoding("big5");

//              commandBuilder.AppendCodePage(CodePageType.CP1252);
            }

//          commandBuilder.AppendInternational(InternationalType.UK);

            commandBuilder.AppendCharacterSpace(0);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.AppendEmphasis(true);

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("Star Micronics\n"), 3);

            commandBuilder.AppendEmphasis(false);

            commandBuilder.Append(encoding.GetBytes("---------------------------------------------------------------------\n"));

            commandBuilder.AppendMultiple(encoding.GetBytes("電子發票證明聯\n" +
                                                            "103年01-02月\n"   +
                                                            "EV-99999999\n"), 2, 2);

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("2014/01/15 13:00\n"            +
                                                    "隨機碼 : 9999    總計 : 999\n" +
                                                    "賣方 : 99999999\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

//          commandBuilder.AppendQrCode(encoding      .GetBytes("http://www.star-m.jp/eng/index.html"), QrCodeModel.No2, QrCodeLevel.Q, 5);
//          commandBuilder.AppendQrCode(Encoding.ASCII.GetBytes("http://www.star-m.jp/eng/index.html"), QrCodeModel.No2, QrCodeLevel.Q, 5);
            commandBuilder.AppendQrCode(Encoding.UTF8 .GetBytes("http://www.star-m.jp/eng/index.html"), QrCodeModel.No2, QrCodeLevel.Q, 5);

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("\n"                                   +
                                                    "商品退換請持本聯及銷貨明細表。\n"     +
                                                    "9999999-9999999 999999-999999 9999\n" +
                                                    "\n"));

            commandBuilder.AppendAlignment(encoding.GetBytes("銷貨明細表 　(銷售)\n"), AlignmentPosition.Center);

            commandBuilder.AppendAlignment(encoding.GetBytes("2014-01-15 13:00:02\n"), AlignmentPosition.Right);

            commandBuilder.Append(encoding.GetBytes("\n"                                                              +
                                                    "烏龍袋茶2g20入                                    55 x2 110TX\n" +
                                                    "茉莉烏龍茶2g20入                                  55 x2 110TX\n" +
                                                    "天仁觀音茶2g*20                                   55 x2 110TX\n"));

            commandBuilder.AppendEmphasis(encoding.GetBytes("      小　 計 :                                    330\n" +
                                                            "      總   計 :                                    330\n"));

            commandBuilder.Append(encoding.GetBytes("---------------------------------------------------------------------\n" +
                                                    "現 金                                              400\n"                +
                                                    "      找　 零 :                                     70\n"));

            commandBuilder.AppendEmphasis(encoding.GetBytes(" 101 發票金額 :                                    330\n"));

            commandBuilder.Append(encoding.GetBytes("2014-01-15 13:00\n" +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

//          commandBuilder.AppendBarcode(encoding      .GetBytes("{BStar."), BarcodeSymbology.Code128, BarcodeWidth.Mode2, 40, true);
//          commandBuilder.AppendBarcode(Encoding.ASCII.GetBytes("{BStar."), BarcodeSymbology.Code128, BarcodeWidth.Mode2, 40, true);
            commandBuilder.AppendBarcode(Encoding.UTF8 .GetBytes("{BStar."), BarcodeSymbology.Code128, BarcodeWidth.Mode2, 40, true);

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("\n"                                   +
                                                    "商品退換、贈品及停車兌換請持本聯。\n" +
                                                    "9999999-9999999 999999-999999 9999\n"));
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
                encoding = Encoding.GetEncoding("big5");

//              commandBuilder.AppendCodePage(CodePageType.CP1252);
            }

//          commandBuilder.AppendInternational(InternationalType.UK);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.AppendEmphasis(true);

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("Star Micronics\n"), 2);

            commandBuilder.AppendEmphasis(false);

            commandBuilder.Append(encoding.GetBytes("------------------------------------------\n"));

            commandBuilder.AppendMultipleWidth(encoding.GetBytes("電子發票證明聯\n" +
                                                                 "103年01-02月\n"    +
                                                                 "EV-99999999\n"), 2);

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("2014/01/15 13:00\n"                   +
                                                    "隨機碼 : 9999    總計 : 999\n"        +
                                                    "賣方 : 99999999\n"                    +
                                                    "\n"                                   +
                                                    "商品退換請持本聯及銷貨明細表。\n"     +
                                                    "9999999-9999999 999999-999999 9999\n" +
                                                    "\n"));

            commandBuilder.AppendAlignment(encoding.GetBytes("銷貨明細表 　(銷售)\n"), AlignmentPosition.Center);

            commandBuilder.AppendAlignment(encoding.GetBytes("2014-01-15 13:00:02\n"), AlignmentPosition.Right);

            commandBuilder.Append(encoding.GetBytes("\n"                                       +
                                                    "烏龍袋茶2g20入             55 x2 110TX\n" +
                                                    "茉莉烏龍茶2g20入           55 x2 110TX\n" +
                                                    "天仁觀音茶2g*20            55 x2 110TX\n"));

            commandBuilder.AppendEmphasis(encoding.GetBytes("      小　 計 :             330\n" +
                                                            "      總   計 :             330\n"));

            commandBuilder.Append(encoding.GetBytes("------------------------------------------\n" +
                                                    "現 金                       400\n"            +
                                                    "      找　 零 :              70\n"));

            commandBuilder.AppendEmphasis(encoding.GetBytes(" 101 發票金額 :             330\n"));

            commandBuilder.Append(encoding.GetBytes("2014-01-15 13:00\n"                   +
                                                    "\n"                                   +
                                                    "商品退換、贈品及停車兌換請持本聯。\n" +
                                                    "9999999-9999999 999999-999999 9999\n"));
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
                encoding = Encoding.GetEncoding("big5");

//              commandBuilder.AppendCodePage(CodePageType.CP1252);
            }

//          commandBuilder.AppendInternational(InternationalType.UK);

            commandBuilder.AppendCharacterSpace(0);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.AppendEmphasis(true);

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("Star Micronics\n"), 3);

            commandBuilder.AppendEmphasis(false);

            commandBuilder.Append(encoding.GetBytes("------------------------------------------\n"));

            commandBuilder.AppendMultiple(encoding.GetBytes("電子發票證明聯\n" +
                                                            "103年01-02月\n"   +
                                                            "EV-99999999\n"), 2, 2);

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("2014/01/15 13:00\n"            +
                                                    "隨機碼 : 9999    總計 : 999\n" +
                                                    "賣方 : 99999999\n"             +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

//          commandBuilder.AppendQrCode(encoding      .GetBytes("http://www.star-m.jp/eng/index.html"), QrCodeModel.No2, QrCodeLevel.Q, 5);
//          commandBuilder.AppendQrCode(Encoding.ASCII.GetBytes("http://www.star-m.jp/eng/index.html"), QrCodeModel.No2, QrCodeLevel.Q, 5);
            commandBuilder.AppendQrCode(Encoding.UTF8 .GetBytes("http://www.star-m.jp/eng/index.html"), QrCodeModel.No2, QrCodeLevel.Q, 5);

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("\n"                                   +
                                                    "商品退換請持本聯及銷貨明細表。\n"     +
                                                    "9999999-9999999 999999-999999 9999\n" +
                                                    "\n"));

            commandBuilder.AppendAlignment(encoding.GetBytes("銷貨明細表 　(銷售)\n"), AlignmentPosition.Center);

            commandBuilder.AppendAlignment(encoding.GetBytes("2014-01-15 13:00:02\n"), AlignmentPosition.Right);

            commandBuilder.Append(encoding.GetBytes("\n"                                          +
                                                    "烏龍袋茶2g20入                55 x2 110TX\n" +
                                                    "茉莉烏龍茶2g20入              55 x2 110TX\n" +
                                                    "天仁觀音茶2g*20               55 x2 110TX\n"));

            commandBuilder.AppendEmphasis(encoding.GetBytes("      小　 計 :                330\n" +
                                                            "      總   計 :                330\n"));

            commandBuilder.Append(encoding.GetBytes("------------------------------------------\n" +
                                                    "現 金                          400\n"         +
                                                    "      找　 零 :                 70\n"));

            commandBuilder.AppendEmphasis(encoding.GetBytes(" 101 發票金額 :                330\n"));

            commandBuilder.Append(encoding.GetBytes("2014-01-15 13:00\n" +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

//          commandBuilder.AppendBarcode(encoding      .GetBytes("{BStar."), BarcodeSymbology.Code128, BarcodeWidth.Mode2, 40, true);
//          commandBuilder.AppendBarcode(Encoding.ASCII.GetBytes("{BStar."), BarcodeSymbology.Code128, BarcodeWidth.Mode2, 40, true);
            commandBuilder.AppendBarcode(Encoding.UTF8 .GetBytes("{BStar."), BarcodeSymbology.Code128, BarcodeWidth.Mode2, 40, true);

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("\n"                                   +
                                                    "商品退換、贈品及停車兌換請持本聯。\n" +
                                                    "9999999-9999999 999999-999999 9999\n"));
        }

        public void AppendPasteTextLabelData(ICommandBuilder commandBuilder, string text, bool utf8)
        {
            throw new NotImplementedException();
        }

        public void AppendTextLabelData(ICommandBuilder commandBuilder, bool utf8)
        {
            throw new NotImplementedException();
        }

        public string Create2inchRasterReceiptString()
        {
            return "　　　　Star Micronics\n"             +
                   "-----------------------------\n"      +
                   "        電子發票證明聯\n"             +
                   "        103年01-02月\n"               +
                   "        EV-99999999\n"                +
                   "2014/01/15 13:00\n"                   +
                   "隨機碼 : 9999      總計 : 999\n"      +
                   "賣　方 : 99999999\n"                  +
                   "\n"                                   +
                   "商品退換請持本聯及銷貨明細表。\n"     +
                   "9999999-9999999 999999-999999 9999\n" +
                   "\n"                                   +
                   "\n"                                   +
                   "        銷貨明細表 　(銷售)\n"        +
                   "     2014-01-15 13:00:02\n"           +
                   "\n"                                   +
                   "烏龍袋茶2g20入　   55 x2  110TX\n"    +
                   "茉莉烏龍茶2g20入   55 x2  110TX\n"    +
                   "天仁觀音茶2g*20　  55 x2  110TX\n"    +
                   "     小　　計 :　　         330\n"    +
                   "     總　　計 :　　         330\n"    +
                   "-----------------------------\n"      +
                   "現　金　　　                400\n"    +
                   "     找　　零 :　　          70\n"    +
                   " 101 發票金額 :　　         330\n"    +
                   "2014-01-15 13:00\n"                   +
                   "\n"                                   +
                   "商品退換、贈品及停車兌換請持本聯。\n" +
                   "9999999-9999999 999999-999999 9999\n";
        }

        public string Create3inchRasterReceiptString()
        {
            return "　 　　　  　　Star Micronics\n"           +
                   "---------------------------------------\n" +
                   "              電子發票證明聯\n"            +
                   "              103年01-02月\n"              +
                   "              EV-99999999\n"               +
                   "2014/01/15 13:00\n"                        +
                   "隨機碼 : 9999      總計 : 999\n"           +
                   "賣　方 : 99999999\n"                       +
                   "\n"                                        +
                   "商品退換請持本聯及銷貨明細表。\n"          +
                   "9999999-9999999 999999-999999 9999\n"      +
                   "\n"                                        +
                   "\n"                                        +
                   "         銷貨明細表 　(銷售)\n"            +
                   "                    2014-01-15 13:00:02\n" +
                   "\n"                                        +
                   "烏龍袋茶2g20入　         55 x2    110TX\n" +
                   "茉莉烏龍茶2g20入         55 x2    110TX\n" +
                   "天仁觀音茶2g*20　        55 x2    110TX\n" +
                   "     小　　計 :　　        330\n"          +
                   "     總　　計 :　　        330\n"          +
                   "---------------------------------------\n" +
                   "現　金　　　               400\n"          +
                   "     找　　零 :　　         70\n"          +
                   " 101 發票金額 :　　        330\n"          +
                   "2014-01-15 13:00\n"                        +
                   "\n"                                        +
                   "商品退換、贈品及停車兌換請持本聯。\n"      +
                   "9999999-9999999 999999-999999 9999\n";
        }

        public string Create4inchRasterReceiptString()
        {
            return "　 　　　  　  　       Star Micronics\n"                    +
                   "---------------------------------------------------------\n" +
                   "                       電子發票證明聯\n"                     +
                   "                       103年01-02月\n"                       +
                   "                       EV-99999999\n"                        +
                   "2014/01/15 13:00\n"                                          +
                   "隨機碼 : 9999      總計 : 999\n"                             +
                   "賣　方 : 99999999\n"                                         +
                   "\n"                                                          +
                   "商品退換請持本聯及銷貨明細表。\n"                            +
                   "9999999-9999999 999999-999999 9999\n"                        +
                   "\n"                                                          +
                   "\n"                                                          +
                   "                      銷貨明細表 　(銷售)\n"                 +
                   "                                      2014-01-15 13:00:02\n" +
                   "\n"                                                          +
                   "烏龍袋茶2g20入　                   55 x2        110TX\n"     +
                   "茉莉烏龍茶2g20入                   55 x2        110TX\n"     +
                   "天仁觀音茶2g*20　                  55 x2        110TX\n"     +
                   "     小　　計 :　　                  330\n"                  +
                   "     總　　計 :　　                  330\n"                  +
                   "---------------------------------------------------------\n" +
                   "現　金　　　                         400\n"                  +
                   "     找　　零 :　　                   70\n"                  +
                   " 101 發票金額 :　　                  330\n"                  +
                   "2014-01-15 13:00\n"                                          +
                   "\n"                                                          +
                   "商品退換、贈品及停車兌換請持本聯。\n"                        +
                   "9999999-9999999 999999-999999 9999\n";
        }

        public Stream CreateCouponImage()
        {
            Assembly assembly = typeof(TraditionalChineseReceiptsComponent).GetTypeInfo().Assembly;

            return assembly.GetManifestResourceStream("XamarinSDK.Resources.TraditionalChineseCouponImage.png");
        }

        public string CreateEscPos3inchRasterReceiptString()
        {
            return "　 　  　　Star Micronics\n"           +
                   "-----------------------------------\n" +
                   "           電子發票證明聯\n"           +
                   "           103年01-02月\n"             +
                   "           EV-99999999\n"              +
                   "2014/01/15 13:00\n"                    +
                   "隨機碼 : 9999      總計 : 999\n"       +
                   "賣　方 : 99999999\n"                   +
                   "\n"                                    +
                   "商品退換請持本聯及銷貨明細表。\n"      +
                   "9999999-9999999 999999-999999 9999\n"  +
                   "\n"                                    +
                   "\n"                                    +
                   "         銷貨明細表 　(銷售)\n"        +
                   "            2014-01-15 13:00:02\n"     +
                   "\n"                                    +
                   "烏龍袋茶2g20入　     55 x2    110TX\n" +
                   "茉莉烏龍茶2g20入     55 x2    110TX\n" +
                   "天仁觀音茶2g*20　    55 x2    110TX\n" +
                   "     小　　計 :　　        330\n"      +
                   "     總　　計 :　　        330\n"      +
                   "-----------------------------------\n" +
                   "現　金　　　               400\n"      +
                   "     找　　零 :　　         70\n"      +
                   " 101 發票金額 :　　        330\n"      +
                   "2014-01-15 13:00\n"                    +
                   "\n"                                    +
                   "商品退換、贈品及停車兌換請持本聯。\n"  +
                   "9999999-9999999 999999-999999 9999\n";
        }

        public string CreatePasteTextLabelString()
        {
            throw new NotImplementedException();
        }
    }
}
