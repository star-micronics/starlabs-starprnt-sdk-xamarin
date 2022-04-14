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
    class SimplifiedChineseReceiptsComponent : ILocalizeReceiptsComponent
    {
        public string LanguageCode
        {
            get { return "zh-CN"; }
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
                encoding = Encoding.GetEncoding("gb2312");
//              encoding = Encoding.GetEncoding("GB18030");

//              commandBuilder.AppendCodePage(CodePageType.CP1252);
            }

//          commandBuilder.AppendInternational(InternationalType.UK);

            commandBuilder.AppendCharacterSpace(0);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.AppendEmphasis(true);

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("STAR便利店\n"), 3);

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("欢迎光临\n"), 2);

            commandBuilder.AppendEmphasis(false);

            commandBuilder.Append(encoding.GetBytes("Unit 1906-08, 19/F,\n"   +
                                                    "Enterprise Square 2,\n"  +
                                                    "3 Sheung Yuet Road,\n"   +
                                                    "Kowloon Bay, KLN\n"      +
                                                    "\n"                      +
                                                    "Tel : (852) 2795 2335\n" +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("货品名称           数量     价格\n" +
                                                    "--------------------------------\n" +
                                                    "\n"                                 +
                                                    "罐装可乐\n"                         +
                                                    "* Coke                 1    7.00\n" +
                                                    "纸包柠檬茶\n"                       +
                                                    "* Lemon Tea            2   10.00\n" +
                                                    "热狗\n"                             +
                                                    "* Hot Dog              1   10.00\n" +
                                                    "薯片(50克装)\n"                     +
                                                    "* Potato Chips(50g)    1   11.00\n" +
                                                    "--------------------------------\n" +
                                                    "\n"                                 +
                                                    "              总数 :       38.00\n" +
                                                    "              现金 :       38.00\n" +
                                                    "              找赎 :        0.00\n" +
                                                    "\n"                                 +
                                                    "卡号码 Card No.       : 88888888\n" +
                                                    "卡余额 Remaining Val.    : 88.00\n" +
                                                    "机号   Device No.       : 1234F1\n" +
                                                    "\n"                                 +
                                                    "\n"                                 +
                                                    "DD/MM/YYYY  HH:MM:SS\n"             +
                                                    "交易编号 : 88888\n"                 +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("收银机 : 001  收银员 : 180\n" +
                                                    "\n"));

//          commandBuilder.AppendBarcode(encoding      .GetBytes("{BStar."), BarcodeSymbology.Code128, BarcodeWidth.Mode2, 40, true);
//          commandBuilder.AppendBarcode(Encoding.ASCII.GetBytes("{BStar."), BarcodeSymbology.Code128, BarcodeWidth.Mode2, 40, true);
            commandBuilder.AppendBarcode(Encoding.UTF8 .GetBytes("{BStar."), BarcodeSymbology.Code128, BarcodeWidth.Mode2, 40, true);
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
                encoding = Encoding.GetEncoding("gb2312");
//              encoding = Encoding.GetEncoding("GB18030");

//              commandBuilder.AppendCodePage(CodePageType.CP1252);
            }

//          commandBuilder.AppendInternational(InternationalType.UK);

            commandBuilder.AppendCharacterSpace(0);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.AppendEmphasis(true);

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("STAR便利店\n"), 3);

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("欢迎光临\n"), 2);

            commandBuilder.AppendEmphasis(false);

            commandBuilder.Append(encoding.GetBytes("Unit 1906-08, 19/F, Enterprise Square 2,\n" +
                                                    "　3 Sheung Yuet Road, Kowloon Bay, KLN\n"   +
                                                    "\n"                                         +
                                                    "Tel : (852) 2795 2335\n"                    +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("货品名称   　            数量   　   价格\n"        +
                                                    "------------------------------------------------\n" +
                                                    "\n"                                                 +
                                                    "罐装可乐\n"                                         +
                                                    "* Coke                      1        7.00\n"        +
                                                    "纸包柠檬茶\n"                                       +
                                                    "* Lemon Tea                 2       10.00\n"        +
                                                    "热狗\n"                                             +
                                                    "* Hot Dog                   1       10.00\n"        +
                                                    "薯片(50克装)\n"                                     +
                                                    "* Potato Chips(50g)         1       11.00\n"        +
                                                    "------------------------------------------------\n" +
                                                    "\n"                                                 +
                                                    "                         总数 :     38.00\n"        +
                                                    "                         现金 :     38.00\n"        +
                                                    "                         找赎 :      0.00\n"        +
                                                    "\n"                                                 +
                                                    "卡号码 Card No.       : 88888888\n"                 +
                                                    "卡余额 Remaining Val. : 88.00\n"                    +
                                                    "机号   Device No.     : 1234F1\n"                   +
                                                    "\n"                                                 +
                                                    "\n"                                                 +
                                                    "DD/MM/YYYY  HH:MM:SS  交易编号 : 88888\n"           +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("收银机 : 001  收银员 : 180\n"));

//          commandBuilder.AppendBarcode(encoding      .GetBytes("{BStar."), BarcodeSymbology.Code128, BarcodeWidth.Mode2, 40, true);
//          commandBuilder.AppendBarcode(Encoding.ASCII.GetBytes("{BStar."), BarcodeSymbology.Code128, BarcodeWidth.Mode2, 40, true);
            commandBuilder.AppendBarcode(Encoding.UTF8 .GetBytes("{BStar."), BarcodeSymbology.Code128, BarcodeWidth.Mode2, 40, true);
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
                encoding = Encoding.GetEncoding("gb2312");
//              encoding = Encoding.GetEncoding("GB18030");

//              commandBuilder.AppendCodePage(CodePageType.CP1252);
            }

//          commandBuilder.AppendInternational(InternationalType.UK);

            commandBuilder.AppendCharacterSpace(0);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.AppendEmphasis(true);

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("STAR便利店\n"), 3);

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("欢迎光临\n"), 2);

            commandBuilder.AppendEmphasis(false);

            commandBuilder.Append(encoding.GetBytes("Unit 1906-08, 19/F, Enterprise Square 2,\n" +
                                                    "　3 Sheung Yuet Road, Kowloon Bay, KLN\n"   +
                                                    "\n"                                         +
                                                    "Tel : (852) 2795 2335\n"                    +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("货品名称   　                      数量        　         价格\n"   +
                                                    "----------------------------------------------------------------\n" +
                                                    "\n"                                                                 +
                                                    "罐装可乐\n"                                                         +
                                                    "* Coke                               1                    7.00\n"   +
                                                    "纸包柠檬茶\n"                                                       +
                                                    "* Lemon Tea                          2                   10.00\n"   +
                                                    "热狗\n"                                                             +
                                                    "* Hot Dog                            1                   10.00\n"   +
                                                    "薯片(50克装)\n"                                                     +
                                                    "* Potato Chips(50g)                  1                   11.00\n"   +
                                                    "----------------------------------------------------------------\n" +
                                                    "\n"                                                                 +
                                                    "                                   总数 :                38.00\n"   +
                                                    "                                   现金 :                38.00\n"   +
                                                    "                                   找赎 :                 0.00\n"   +
                                                    "\n"                                                                 +
                                                    "卡号码 Card No.                   : 88888888\n"                     +
                                                    "卡余额 Remaining Val.             : 88.00\n"                        +
                                                    "机号   Device No.                 : 1234F1\n"                       +
                                                    "\n"                                                                 +
                                                    "\n"                                                                 +
                                                    "DD/MM/YYYY  HH:MM:SS        交易编号 : 88888\n"                     +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("收银机 : 001  收银员 : 180\n"));

//          commandBuilder.AppendBarcode(encoding      .GetBytes("{BStar."), BarcodeSymbology.Code128, BarcodeWidth.Mode2, 40, true);
//          commandBuilder.AppendBarcode(Encoding.ASCII.GetBytes("{BStar."), BarcodeSymbology.Code128, BarcodeWidth.Mode2, 40, true);
            commandBuilder.AppendBarcode(Encoding.UTF8 .GetBytes("{BStar."), BarcodeSymbology.Code128, BarcodeWidth.Mode2, 40, true);
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
                encoding = Encoding.GetEncoding("gb2312");
//              encoding = Encoding.GetEncoding("GB18030");

//              commandBuilder.AppendCodePage(CodePageType.CP1252);
            }

//          commandBuilder.AppendInternational(InternationalType.UK);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.AppendEmphasis(true);

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("STAR便利店\n" +
                                                                  "欢迎光临\n"), 2);

            commandBuilder.AppendEmphasis(false);

            commandBuilder.Append(encoding.GetBytes("Unit 1906-08, 19/F, Enterprise Square 2,\n" +
                                                    "　3 Sheung Yuet Road, Kowloon Bay, KLN\n"   +
                                                    "\n"                                         +
                                                    "Tel : (852) 2795 2335\n"                    +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("货品名称   　          数量  　   价格\n"     +
                                                    "------------------------------------------\n" +
                                                    "\n"                                           +
                                                    "罐装可乐\n"                                   +
                                                    "* Coke                   1        7.00\n"     +
                                                    "纸包柠檬茶\n"                                 +
                                                    "* Lemon Tea              2       10.00\n"     +
                                                    "热狗\n"                                       +
                                                    "* Hot Dog                1       10.00\n"     +
                                                    "薯片(50克装)\n"                               +
                                                    "* Potato Chips(50g)      1       11.00\n"     +
                                                    "------------------------------------------\n" +
                                                    "\n"                                           +
                                                    "                      总数 :     38.00\n"     +
                                                    "                      现金 :     38.00\n"     +
                                                    "                      找赎 :      0.00\n"     +
                                                    "\n"                                           +
                                                    "卡号码 Card No.       : 88888888\n"           +
                                                    "卡余额 Remaining Val. : 88.00\n"              +
                                                    "机号   Device No.     : 1234F1\n"             +
                                                    "\n"                                           +
                                                    "\n"                                           +
                                                    "DD/MM/YYYY  HH:MM:SS  交易编号 : 88888\n"     +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("收银机 : 001  收银员 : 180\n"));
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
                encoding = Encoding.GetEncoding("gb2312");
//              encoding = Encoding.GetEncoding("GB18030");

//              commandBuilder.AppendCodePage(CodePageType.CP1252);
            }

//          commandBuilder.AppendInternational(InternationalType.UK);

            commandBuilder.AppendCharacterSpace(0);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.AppendEmphasis(true);

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("STAR便利店\n"), 3);

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("欢迎光临\n"), 2);

            commandBuilder.AppendEmphasis(false);

            commandBuilder.Append(encoding.GetBytes("Unit 1906-08, 19/F, Enterprise Square 2,\n" +
                                                    "　3 Sheung Yuet Road, Kowloon Bay, KLN\n"   +
                                                    "\n"                                         +
                                                    "Tel : (852) 2795 2335\n"                    +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("货品名称   　        数量   　 价格\n"        +
                                                    "------------------------------------------\n" +
                                                    "\n"                                           +
                                                    "罐装可乐\n"                                   +
                                                    "* Coke                  1      7.00\n"        +
                                                    "纸包柠檬茶\n"                                 +
                                                    "* Lemon Tea             2     10.00\n"        +
                                                    "热狗\n"                                       +
                                                    "* Hot Dog               1     10.00\n"        +
                                                    "薯片(50克装)\n"                               +
                                                    "* Potato Chips(50g)     1     11.00\n"        +
                                                    "------------------------------------------\n" +
                                                    "\n"                                           +
                                                    "                   总数 :     38.00\n"        +
                                                    "                   现金 :     38.00\n"        +
                                                    "                   找赎 :      0.00\n"        +
                                                    "\n"                                           +
                                                    "卡号码 Card No.       : 88888888\n"           +
                                                    "卡余额 Remaining Val. : 88.00\n"              +
                                                    "机号   Device No.     : 1234F1\n"             +
                                                    "\n"                                           +
                                                    "\n"                                           +
                                                    "DD/MM/YYYY  HH:MM:SS  交易编号 : 88888\n"     +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("收银机 : 001  收银员 : 180\n"));

//          commandBuilder.AppendBarcode(encoding      .GetBytes("{BStar."), BarcodeSymbology.Code128, BarcodeWidth.Mode2, 40, true);
//          commandBuilder.AppendBarcode(Encoding.ASCII.GetBytes("{BStar."), BarcodeSymbology.Code128, BarcodeWidth.Mode2, 40, true);
            commandBuilder.AppendBarcode(Encoding.UTF8 .GetBytes("{BStar."), BarcodeSymbology.Code128, BarcodeWidth.Mode2, 40, true);
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
            return "　  　　STAR便利店\n"              +
                   "           欢迎光临\n"             +
                   "\n"                                +
                   "Unit 1906-08,19/F,\n"              +
                   "  Enterprise Square 2,\n"          +
                   "  3 Sheung Yuet Road,\n"           +
                   "  Kowloon Bay, KLN\n"              +
                   "\n"                                +
                   "Tel: (852) 2795 2335\n"            +
                   "\n"                                +
                   "货品名称            数量   价格\n" +
                   "-----------------------------\n"   +
                   "罐装可乐\n"                        +
                   "* Coke              1    7.00\n"   +
                   "纸包柠檬茶\n"                      +
                   "* Lemon Tea         2   10.00\n"   +
                   "热狗\n"                            +
                   "* Hot Dog           1   10.00\n"   +
                   "薯片(50克装)\n"                    +
                   "* Potato Chips(50g) 1   11.00\n"   +
                   "-----------------------------\n"   +
                   "\n"                                +
                   "               总　数 :  38.00\n"  +
                   "               现　金 :  38.00\n"  +
                   "               找　赎 :   0.00\n"  +
                   "\n"                                +
                   "卡号码 Card No. :    88888888\n"   +
                   "卡余额 Remaining Val. : 88.00\n"   +
                   "机号　 Device No. :    1234F1\n"   +
                   "\n"                                +
                   "DD/MM/YYYY HH:MM:SS\n"             +
                   "交易编号: 88888\n"                 +
                   "\n"                                +
                   "         收银机:001  收银员:180\n";
        }

        public string Create3inchRasterReceiptString()
        {
            return "　　　　　　  　　STAR便利店\n"             +
                   "                欢迎光临\n"                 +
                   "\n"                                         +
                   "Unit 1906-08,19/F,Enterprise Square 2,\n"   +
                   "  3 Sheung Yuet Road, Kowloon Bay, KLN\n"   +
                   "\n"                                         +
                   "Tel: (852) 2795 2335\n"                     +
                   "\n"                                         +
                   "货品名称                 数量   　  价格\n" +
                   "---------------------------------------\n"  +
                   "罐装可乐\n"                                 +
                   "* Coke                   1        7.00\n"   +
                   "纸包柠檬茶\n"                               +
                   "* Lemon Tea              2       10.00\n"   +
                   "热狗\n"                                     +
                   "* Hot Dog                1       10.00\n"   +
                   "薯片(50克装)\n"                             +
                   "* Potato Chips(50g)      1       11.00\n"   +
                   "---------------------------------------\n"  +
                   "\n"                                         +
                   "                        总　数 :  38.00\n"  +
                   "                        现　金 :  38.00\n"  +
                   "                        找　赎 :   0.00\n"  +
                   "\n"                                         +
                   "卡号码 Card No.        :       88888888\n"  +
                   "卡余额 Remaining Val.  :       88.00\n"     +
                   "机号　 Device No.      :       1234F1\n"    +
                   "\n"                                         +
                   "DD/MM/YYYY   HH:MM:SS   交易编号: 88888\n"  +
                   "\n"                                         +
                   "          收银机:001  收银员:180\n";
        }

        public string Create4inchRasterReceiptString()
        {
            return "　　　　　　  　　         STAR便利店\n"                     +
                   "                          欢迎光临\n"                        +
                   "\n"                                                          +
                   "     Unit 1906-08,19/F,Enterprise Square 2,\n"               +
                   "                3 Sheung Yuet Road, Kowloon Bay, KLN\n"      +
                   "\n"                                                          +
                   "Tel: (852) 2795 2335\n"                                      +
                   "\n"                                                          +
                   "货品名称                               数量          价格\n" +
                   "---------------------------------------------------------\n" +
                   "罐装可乐\n"                                                  +
                   "* Coke                                 1            7.00\n"  +
                   "纸包柠檬茶\n"                                                +
                   "* Lemon Tea                            2           10.00\n"  +
                   "热狗\n"                                                      +
                   "* Hot Dog                              1           10.00\n"  +
                   "薯片(50克装)\n"                                              +
                   "* Potato Chips(50g)                    1           11.00\n"  +
                   "---------------------------------------------------------\n" +
                   "\n"                                                          +
                   "                                          总　数 :  38.00\n" +
                   "                                          现　金 :  38.00\n" +
                   "                                          找　赎 :   0.00\n" +
                   "\n"                                                          +
                   "卡号码 Card No.        :       88888888\n"                   +
                   "卡余额 Remaining Val.  :       88.00\n"                      +
                   "机号　 Device No.      :       1234F1\n"                     +
                   "\n"                                                          +
                   "DD/MM/YYYY              HH:MM:SS          交易编号: 88888\n" +
                   "\n"                                                          +
                   "                   收银机:001  收银员:180\n";
        }

        public Stream CreateCouponImage()
        {
            Assembly assembly = typeof(SimplifiedChineseReceiptsComponent).GetTypeInfo().Assembly;

            return assembly.GetManifestResourceStream("XamarinSDK.Resources.SimplifiedChineseCouponImage.png");
        }

        public string CreateEscPos3inchRasterReceiptString()
        {
            return "　　　　　　　STAR便利店\n"              +
                   "              欢迎光临\n"                +
                   "\n"                                      +
                   "Unit 1906-08,19/F,\n"                    +
                   "  Enterprise Square 2,\n"                +
                   "  3 Sheung Yuet Road,\n"                 +
                   "  Kowloon Bay, KLN\n"                    +
                   "\n"                                      +
                   "Tel: (852) 2795 2335\n"                  +
                   "\n"                                      +
                   "货品名称              数量   　  价格\n" +
                   "-----------------------------------\n"   +
                   "罐装可乐\n"                              +
                   "* Coke                1        7.00\n"   +
                   "纸包柠檬茶\n"                            +
                   "* Lemon Tea           2       10.00\n"   +
                   "热狗\n"                                  +
                   "* Hot Dog             1       10.00\n"   +
                   "薯片(50克装)\n"                          +
                   "* Potato Chips(50g)   1       11.00\n"   +
                   "-----------------------------------\n"   +
                   "\n"                                      +
                   "                     总　数 :  38.00\n"  +
                   "                     现　金 :  38.00\n"  +
                   "                     找　赎 :   0.00\n"  +
                   "\n"                                      +
                   "卡号码 Card No.        :    88888888\n"  +
                   "卡余额 Remaining Val.  :    88.00\n"     +
                   "机号　 Device No.      :    1234F1\n"    +
                   "\n"                                      +
                   "DD/MM/YYYY HH:MM:SS  交易编号: 88888\n"  +
                   "\n"                                      +
                   "          收银机:001  收银员:180\n";
        }

        public string CreatePasteTextLabelString()
        {
            throw new NotImplementedException();
        }
    }
}
