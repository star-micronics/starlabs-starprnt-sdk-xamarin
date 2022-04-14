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
    class EnglishReceiptsComponent : ILocalizeReceiptsComponent
    {
        public string LanguageCode
        {
            get { return "En"; }
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
//              encoding = Encoding.ASCII;
                encoding = Encoding.UTF8;

                commandBuilder.AppendCodePage(CodePageType.CP998);
            }

            commandBuilder.AppendInternational(InternationalType.USA);

            commandBuilder.AppendCharacterSpace(0);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("Star Clothing Boutique\n" +
                                                    "123 Star Road\n"          +
                                                    "City, State 12345\n"      +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("Date:MM/DD/YYYY    Time:HH:MM PM\n" +
                                                    "--------------------------------\n" +
                                                    "\n"));

            commandBuilder.AppendEmphasis(encoding.GetBytes("SALE\n"));

            commandBuilder.Append(encoding.GetBytes("SKU         Description    Total\n" +
                                                    "300678566   PLAIN T-SHIRT  10.99\n" +
                                                    "300692003   BLACK DENIM    29.99\n" +
                                                    "300651148   BLUE DENIM     29.99\n" +
                                                    "300642980   STRIPED DRESS  49.99\n" +
                                                    "300638471   BLACK BOOTS    35.99\n" +
                                                    "\n"                                 +
                                                    "Subtotal                  156.95\n" +
                                                    "Tax                         0.00\n" +
                                                    "--------------------------------\n"));

            commandBuilder.Append(encoding.GetBytes("Total     "));

            commandBuilder.AppendMultiple(encoding.GetBytes("   $156.95\n"), 2, 2);

            commandBuilder.Append(encoding.GetBytes("--------------------------------\n" +
                                                    "\n"                                 +
                                                    "Charge\n"                           +
                                                    "159.95\n"                           +
                                                    "Visa XXXX-XXXX-XXXX-0123\n"         +
                                                    "\n"));

            commandBuilder.AppendInvert(encoding.GetBytes("Refunds and Exchanges\n"));

            commandBuilder.Append(encoding.GetBytes("Within "));

            commandBuilder.AppendUnderLine(encoding.GetBytes("30 days"));

            commandBuilder.Append(encoding.GetBytes(" with receipt\n"));

            commandBuilder.Append(encoding.GetBytes("And tags attached\n" +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

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
//              encoding = Encoding.ASCII;
                encoding = Encoding.UTF8;

                commandBuilder.AppendCodePage(CodePageType.CP998);
            }

            commandBuilder.AppendInternational(InternationalType.USA);

            commandBuilder.AppendCharacterSpace(0);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("Star Clothing Boutique\n" +
                                                    "123 Star Road\n"          +
                                                    "City, State 12345\n"      +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("Date:MM/DD/YYYY                    Time:HH:MM PM\n" +
                                                    "------------------------------------------------\n" +
                                                    "\n"));

            commandBuilder.AppendEmphasis(encoding.GetBytes("SALE \n"));

            commandBuilder.Append(encoding.GetBytes("SKU               Description              Total\n" +
                                                    "300678566         PLAIN T-SHIRT            10.99\n" +
                                                    "300692003         BLACK DENIM              29.99\n" +
                                                    "300651148         BLUE DENIM               29.99\n" +
                                                    "300642980         STRIPED DRESS            49.99\n" +
                                                    "300638471         BLACK BOOTS              35.99\n" +
                                                    "\n"                                                 +
                                                    "Subtotal                                  156.95\n" +
                                                    "Tax                                         0.00\n" +
                                                    "------------------------------------------------\n"));

            commandBuilder.Append(encoding.GetBytes("Total                       "));

            commandBuilder.AppendMultiple(encoding.GetBytes("   $156.95\n"), 2, 2);

            commandBuilder.Append(encoding.GetBytes("------------------------------------------------\n" +
                                                    "\n"                                                 +
                                                    "Charge\n"                                           +
                                                    "159.95\n"                                           +
                                                    "Visa XXXX-XXXX-XXXX-0123\n"                         +
                                                    "\n"));

            commandBuilder.AppendInvert(encoding.GetBytes("Refunds and Exchanges\n"));

            commandBuilder.Append(encoding.GetBytes("Within "));

            commandBuilder.AppendUnderLine(encoding.GetBytes("30 days"));

            commandBuilder.Append(encoding.GetBytes(" with receipt\n"));

            commandBuilder.Append(encoding.GetBytes("And tags attached\n" +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

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
//              encoding = Encoding.ASCII;
                encoding = Encoding.UTF8;

                commandBuilder.AppendCodePage(CodePageType.CP998);
            }

            commandBuilder.AppendInternational(InternationalType.USA);

            commandBuilder.AppendCharacterSpace(0);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("Star Clothing Boutique\n" +
                                                    "123 Star Road\n"          +
                                                    "City, State 12345\n"      +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("Date:MM/DD/YYYY                                         Time:HH:MM PM\n" +
                                                    "---------------------------------------------------------------------\n" +
                                                    "\n"));

            commandBuilder.AppendEmphasis(encoding.GetBytes("SALE \n"));

            commandBuilder.Append(encoding.GetBytes("SKU                        Description                          Total\n" +
                                                    "300678566                  PLAIN T-SHIRT                        10.99\n" +
                                                    "300692003                  BLACK DENIM                          29.99\n" +
                                                    "300651148                  BLUE DENIM                           29.99\n" +
                                                    "300642980                  STRIPED DRESS                        49.99\n" +
                                                    "300638471                  BLACK BOOTS                          35.99\n" +
                                                    "\n"                                                                      +
                                                    "Subtotal                                                       156.95\n" +
                                                    "Tax                                                              0.00\n" +
                                                    "---------------------------------------------------------------------\n"));

            commandBuilder.Append(encoding.GetBytes("Total                                            "));

            commandBuilder.AppendMultiple(encoding.GetBytes("   $156.95\n"), 2, 2);

            commandBuilder.Append(encoding.GetBytes("---------------------------------------------------------------------\n" +
                                                    "\n"                                                                      +
                                                    "Charge\n"                                                                +
                                                    "159.95\n"                                                                +
                                                    "Visa XXXX-XXXX-XXXX-0123\n"                                              +
                                                    "\n"));

            commandBuilder.AppendInvert(encoding.GetBytes("Refunds and Exchanges\n"));

            commandBuilder.Append(encoding.GetBytes("Within "));

            commandBuilder.AppendUnderLine(encoding.GetBytes("30 days"));

            commandBuilder.Append(encoding.GetBytes(" with receipt\n"));

            commandBuilder.Append(encoding.GetBytes("And tags attached\n" +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

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
//              encoding = Encoding.ASCII;
                encoding = Encoding.UTF8;

                commandBuilder.AppendCodePage(CodePageType.CP998);
            }

            commandBuilder.AppendInternational(InternationalType.USA);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("Star Clothing Boutique\n" +
                                                    "123 Star Road\n"          +
                                                    "City, State 12345\n"      +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("Date:MM/DD/YYYY              Time:HH:MM PM\n" +
                                                    "------------------------------------------\n" +
                                                    "\n"));

            commandBuilder.AppendEmphasis(encoding.GetBytes("SALE \n"));

            commandBuilder.Append(encoding.GetBytes("SKU             Description          Total\n" +
                                                    "300678566       PLAIN T-SHIRT        10.99\n" +
                                                    "300692003       BLACK DENIM          29.99\n" +
                                                    "300651148       BLUE DENIM           29.99\n" +
                                                    "300642980       STRIPED DRESS        49.99\n" +
                                                    "300638471       BLACK BOOTS          35.99\n" +
                                                    "\n"                                           +
                                                    "Subtotal                            156.95\n" +
                                                    "Tax                                   0.00\n" +
                                                    "------------------------------------------\n" +
                                                    "Total                              $156.95\n" +
                                                    "------------------------------------------\n" +
                                                    "\n"                                           +
                                                    "Charge\n"                                     +
                                                    "159.95\n"                                     +
                                                    "Visa XXXX-XXXX-XXXX-0123\n"                   +
                                                    "\n"));

            commandBuilder.AppendInvert(encoding.GetBytes("Refunds and Exchanges\n"));

            commandBuilder.Append(encoding.GetBytes("Within"));

            commandBuilder.AppendUnderLine(encoding.GetBytes(" 30 days"));

            commandBuilder.Append(encoding.GetBytes(" with receipt\n"));
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
//              encoding = Encoding.ASCII;
                encoding = Encoding.UTF8;

                commandBuilder.AppendCodePage(CodePageType.CP998);
            }

            commandBuilder.AppendInternational(InternationalType.USA);

            commandBuilder.AppendCharacterSpace(0);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("Star Clothing Boutique\n" +
                                                    "123 Star Road\n"          +
                                                    "City, State 12345\n"      +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("Date:MM/DD/YYYY              Time:HH:MM PM\n" +
                                                    "------------------------------------------\n" +
                                                    "\n"));

            commandBuilder.AppendEmphasis(encoding.GetBytes("SALE \n"));

            commandBuilder.Append(encoding.GetBytes("SKU            Description           Total\n" +
                                                    "300678566      PLAIN T-SHIRT         10.99\n" +
                                                    "300692003      BLACK DENIM           29.99\n" +
                                                    "300651148      BLUE DENIM            29.99\n" +
                                                    "300642980      STRIPED DRESS         49.99\n" +
                                                    "300638471      BLACK BOOTS           35.99\n" +
                                                    "\n"                                           +
                                                    "Subtotal                            156.95\n" +
                                                    "Tax                                   0.00\n" +
                                                    "------------------------------------------\n"));

            commandBuilder.Append(encoding.GetBytes("Total                 "));

            commandBuilder.AppendMultiple(encoding.GetBytes("   $156.95\n"), 2, 2);

            commandBuilder.Append(encoding.GetBytes("------------------------------------------\n" +
                                                    "\n"                                           +
                                                    "Charge\n"                                     +
                                                    "159.95\n"                                     +
                                                    "Visa XXXX-XXXX-XXXX-0123\n"                   +
                                                    "\n"));

            commandBuilder.AppendInvert(encoding.GetBytes("Refunds and Exchanges\n"));

            commandBuilder.Append(encoding.GetBytes("Within "));

            commandBuilder.AppendUnderLine(encoding.GetBytes("30 days"));

            commandBuilder.Append(encoding.GetBytes(" with receipt\n"));

            commandBuilder.Append(encoding.GetBytes("And tags attached\n" +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

//          commandBuilder.AppendBarcode(encoding      .GetBytes("{BStar."), BarcodeSymbology.Code128, BarcodeWidth.Mode2, 40, true);
//          commandBuilder.AppendBarcode(Encoding.ASCII.GetBytes("{BStar."), BarcodeSymbology.Code128, BarcodeWidth.Mode2, 40, true);
            commandBuilder.AppendBarcode(Encoding.UTF8 .GetBytes("{BStar."), BarcodeSymbology.Code128, BarcodeWidth.Mode2, 40, true);
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
//              encoding = Encoding.ASCII;
                encoding = Encoding.UTF8;

                commandBuilder.AppendCodePage(CodePageType.CP998);
            }

            commandBuilder.AppendInternational(InternationalType.USA);

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
//              encoding = Encoding.ASCII;
                encoding = Encoding.UTF8;

                commandBuilder.AppendCodePage(CodePageType.CP998);
            }

            commandBuilder.AppendInternational(InternationalType.USA);

            commandBuilder.AppendCharacterSpace(0);

            commandBuilder.AppendUnitFeed(20 * 2);

            commandBuilder.AppendMultipleHeight(2);

            commandBuilder.Append(encoding.GetBytes("Star Micronics America, Inc."));

            commandBuilder.AppendUnitFeed(64);

            commandBuilder.Append(encoding.GetBytes("65 Clyde Road Suite G"));

            commandBuilder.AppendUnitFeed(64);

            commandBuilder.Append(encoding.GetBytes("Somerset, NJ 08873-9997 U.S.A"));

            commandBuilder.AppendUnitFeed(64);

            commandBuilder.AppendMultipleHeight(1);
        }

        public string Create2inchRasterReceiptString()
        {
            string text = "   Star Clothing Boutique\n"     +
                          "        123 Star Road\n"         +
                          "      City, State 12345\n"       +
                          "\n"                              +
                          "Date:MM/DD/YYYY Time:HH:MM PM\n" +
                          "-----------------------------\n" +
                          "SALE\n"                          +
                          "SKU       Description   Total\n" +
                          "300678566 PLAIN T-SHIRT 10.99\n" +
                          "300692003 BLACK DENIM   29.99\n" +
                          "300651148 BLUE DENIM    29.99\n" +
                          "300642980 STRIPED DRESS 49.99\n" +
                          "30063847  BLACK BOOTS   35.99\n" +
                          "\n"                              +
                          "Subtotal               156.95\n" +
                          "Tax                      0.00\n" +
                          "-----------------------------\n" +
                          "Total                 $156.95\n" +
                          "-----------------------------\n" +
                          "\n"                              +
                          "Charge\n"                        +
                          "159.95\n"                        +
                          "Visa XXXX-XXXX-XXXX-0123\n"      +
                          "Refunds and Exchanges\n"         +
                          "Within 30 days with receipt\n"   +
                          "And tags attached\n";

            return text;
        }

        public string Create3inchRasterReceiptString()
        {
            return "        Star Clothing Boutique\n"         +
                   "             123 Star Road\n"             +
                   "           City, State 12345\n"           +
                   "\n"                                       +
                   "Date:MM/DD/YYYY          Time:HH:MM PM\n" +
                   "--------------------------------------\n" +
                   "SALE\n"                                   +
                   "SKU            Description       Total\n" +
                   "300678566      PLAIN T-SHIRT     10.99\n" +
                   "300692003      BLACK DENIM       29.99\n" +
                   "300651148      BLUE DENIM        29.99\n" +
                   "300642980      STRIPED DRESS     49.99\n" +
                   "30063847       BLACK BOOTS       35.99\n" +
                   "\n"                                       +
                   "Subtotal                        156.95\n" +
                   "Tax                               0.00\n" +
                   "--------------------------------------\n" +
                   "Total                          $156.95\n" +
                   "--------------------------------------\n" +
                   "\n"                                       +
                   "Charge\n"                                 +
                   "159.95\n"                                 +
                   "Visa XXXX-XXXX-XXXX-0123\n"               +
                   "Refunds and Exchanges\n"                  +
                   "Within 30 days with receipt\n"            +
                   "And tags attached\n";
        }

        public string Create4inchRasterReceiptString()
        {
            return "                   Star Clothing Boutique\n"                 +
                   "                        123 Star Road\n"                     +
                   "                      City, State 12345\n"                   +
                   "\n"                                                          +
                   "Date:MM/DD/YYYY                             Time:HH:MM PM\n" +
                   "---------------------------------------------------------\n" +
                   "SALE\n"                                                      +
                   "SKU                     Description                 Total\n" +
                   "300678566               PLAIN T-SHIRT               10.99\n" +
                   "300692003               BLACK DENIM                 29.99\n" +
                   "300651148               BLUE DENIM                  29.99\n" +
                   "300642980               STRIPED DRESS               49.99\n" +
                   "300638471               BLACK BOOTS                 35.99\n" +
                   "\n"                                                          +
                   "Subtotal                                           156.95\n" +
                   "Tax                                                  0.00\n" +
                   "---------------------------------------------------------\n" +
                   "Total                                             $156.95\n" +
                   "---------------------------------------------------------\n" +
                   "\n"                                                          +
                   "Charge\n"                                                    +
                   "159.95\n"                                                    +
                   "Visa XXXX-XXXX-XXXX-0123\n"                                  +
                   "Refunds and Exchanges\n"                                     +
                   "Within 30 days with receipt\n"                               +
                   "And tags attached\n";
        }

        public Stream CreateCouponImage()
        {
            Assembly assembly = typeof(GermanReceiptsComponent).GetTypeInfo().Assembly;

            return assembly.GetManifestResourceStream("XamarinSDK.Resources.EnglishCouponImage.png");
        }

        public string CreateEscPos3inchRasterReceiptString()
        {
            return "      Star Clothing Boutique\n"        +
                   "           123 Star Road\n"            +
                   "         City, State 12345\n"          +
                   "\n"                                    +
                   "Date:MM/DD/YYYY       Time:HH:MM PM\n" +
                   "-----------------------------------\n" +
                   "SALE\n"                                +
                   "SKU          Description      Total\n" +
                   "300678566    PLAIN T-SHIRT    10.99\n" +
                   "300692003    BLACK DENIM      29.99\n" +
                   "300651148    BLUE DENIM       29.99\n" +
                   "300642980    STRIPED DRESS    49.99\n" +
                   "30063847     BLACK BOOTS      35.99\n" +
                   "\n"                                    +
                   "Subtotal                     156.95\n" +
                   "Tax                            0.00\n" +
                   "-----------------------------------\n" +
                   "Total                       $156.95\n" +
                   "-----------------------------------\n" +
                   "\n"                                    +
                   "Charge\n"                              +
                   "159.95\n"                              +
                   "Visa XXXX-XXXX-XXXX-0123\n"            +
                   "Refunds and Exchanges\n"               +
                   "Within 30 days with receipt\n"         +
                   "And tags attached\n";
        }

        public string CreatePasteTextLabelString()
        {
            return "Star Micronics America, Inc.\n" +
                   "65 Clyde Road Suite G\n"        +
                   "Somerset, NJ 08873-9997 U.S.A";
        }
    }
}
