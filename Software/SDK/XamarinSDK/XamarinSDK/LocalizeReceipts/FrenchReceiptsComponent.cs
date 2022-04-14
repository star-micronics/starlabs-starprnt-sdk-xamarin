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
    class FrenchReceiptsComponent : ILocalizeReceiptsComponent
    {
        public string LanguageCode
        {
            get { return "Fr"; }
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
                encoding = Encoding.GetEncoding("Windows-1252");

                commandBuilder.AppendCodePage(CodePageType.CP1252);
            }

            commandBuilder.AppendInternational(InternationalType.France);

            commandBuilder.AppendCharacterSpace(0);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("Star Micronics Communications\n"), 2);

            commandBuilder.Append(encoding.GetBytes("AVENUE LA MOTTE PICQUET\n" +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("--------------------------------\n" +
                                                    "Date   : MM/DD/YYYY\n"              +
                                                    "Heure  : HH:MM\n"                   +
                                                    "Boutique: OLUA23    Caisse: 0001\n" +
                                                    "Conseiller: 002970  Ticket: 3881\n" +
                                                    "--------------------------------\n" +
                                                    "\n"                                 +
                                                    "Vous avez été servi par : Souad\n"  +
                                                    "\n"                                 +
                                                    "CAC IPHONE\n"                       +
                                                    "3700615033581 1 X 19.99€  19.99€\n" +
                                                    "\n"                                 +
                                                    "dont contribution\n"                +
                                                    " environnementale :\n"              +
                                                    "CAC IPHONE                 0.01€\n" +
                                                    "--------------------------------\n" +
                                                    "1 Piéce(s) Total :        19.99€\n" +
                                                    "Mastercard Visa  :        19.99€\n" +
                                                    "\n"                                 +
                                                    "Taux TVA    Montant H.T.   T.V.A\n" +
                                                    "  20%          16.66€      3.33€\n" +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("Merci de votre visite et.\n" +
                                                    "à bientôt.\n"                +
                                                    "Conservez votre ticket il\n" +
                                                    "vous sera demandé pour\n"    +
                                                    "tout échange.\n"             +
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
                encoding = Encoding.GetEncoding("Windows-1252");

                commandBuilder.AppendCodePage(CodePageType.CP1252);
            }

            commandBuilder.AppendInternational(InternationalType.France);

            commandBuilder.AppendCharacterSpace(0);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

//          commandBuilder.Append(encoding.GetBytes("[If loaded.. Logo1 goes here]\n"));
//
//          commandBuilder.AppendLogo(LogoSize.Normal, 1);

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("Star Micronics Communications\n"), 2);

            commandBuilder.Append(encoding.GetBytes("AVENUE LA MOTTE PICQUET\n" +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("------------------------------------------------\n" +
                                                    "Date: MM/DD/YYYY    Heure: HH:MM\n"                 +
                                                    "Boutique: OLUA23    Caisse: 0001\n"                 +
                                                    "Conseiller: 002970  Ticket: 3881\n"                 +
                                                    "------------------------------------------------\n" +
                                                    "\n"                                                 +
                                                    "Vous avez été servi par : Souad\n"                  +
                                                    "\n"                                                 +
                                                    "CAC IPHONE\n"                                       +
                                                    "3700615033581   1    X     19.99€         19.99€\n" +
                                                    "\n"                                                 +
                                                    "dont contribution environnementale :\n"             +
                                                    "CAC IPHONE                                 0.01€\n" +
                                                    "------------------------------------------------\n" +
                                                    "1 Piéce(s) Total :                        19.99€\n" +
                                                    "Mastercard Visa  :                        19.99€\n" +
                                                    "\n"                                                 +
                                                    "Taux TVA    Montant H.T.   T.V.A\n"                 +
                                                    "  20%          16.66€      3.33€\n"                 +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("Merci de votre visite et. à bientôt.\n" +
                                                    "Conservez votre ticket il\n"            +
                                                    "vous sera demandé pour tout échange.\n"));

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
                encoding = Encoding.GetEncoding("Windows-1252");

                commandBuilder.AppendCodePage(CodePageType.CP1252);
            }

            commandBuilder.AppendInternational(InternationalType.France);

            commandBuilder.AppendCharacterSpace(0);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

//          commandBuilder.Append(encoding.GetBytes("[If loaded.. Logo1 goes here]\n"));
//
//          commandBuilder.AppendLogo(LogoSize.Normal, 1);

            commandBuilder.AppendMultiple(encoding.GetBytes("Star Micronics Communications\n"), 2, 2);

            commandBuilder.Append(encoding.GetBytes("AVENUE LA MOTTE PICQUET\n" +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("---------------------------------------------------------------------\n" +
                                                    "Date: MM/DD/YYYY    Heure: HH:MM\n"                                      +
                                                    "Boutique: OLUA23    Caisse: 0001\n"                                      +
                                                    "Conseiller: 002970  Ticket: 3881\n"                                      +
                                                    "---------------------------------------------------------------------\n" +
                                                    "\n"                                                                      +
                                                    "Vous avez été servi par : Souad\n"                                       +
                                                    "\n"                                                                      +
                                                    "CAC IPHONE\n"                                                            +
                                                    "3700615033581   1    X     19.99€                              19.99€\n" +
                                                    "\n"                                                                      +
                                                    "dont contribution environnementale :\n"                                  +
                                                    "CAC IPHONE                                                      0.01€\n" +
                                                    "---------------------------------------------------------------------\n" +
                                                    "1 Piéce(s) Total :                                             19.99€\n" +
                                                    "Mastercard Visa  :                                             19.99€\n" +
                                                    "\n"                                                                      +
                                                    "Taux TVA    Montant H.T.   T.V.A\n"                                      +
                                                    "  20%          16.66€      3.33€\n"                                      +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("Merci de votre visite et. à bientôt.\n" +
                                                    "Conservez votre ticket il\n"            +
                                                    "vous sera demandé pour tout échange.\n"));

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
                encoding = Encoding.GetEncoding("Windows-1252");

                commandBuilder.AppendCodePage(CodePageType.CP1252);
            }

            commandBuilder.AppendInternational(InternationalType.France);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

//          commandBuilder.Append(encoding.GetBytes("[If loaded.. Logo1 goes here]\n"));
//
//          commandBuilder.AppendLogo(LogoSize.Normal, 1);

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("Star Micronics Communications\n"), 2);

            commandBuilder.Append(encoding.GetBytes("AVENUE LA MOTTE PICQUET\n" +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("------------------------------------------\n" +
                                                    "Date: MM/DD/YYYY    Heure: HH:MM\n"           +
                                                    "Boutique: OLUA23    Caisse: 0001\n"           +
                                                    "Conseiller: 002970  Ticket: 3881\n"           +
                                                    "------------------------------------------\n" +
                                                    "\n"                                           +
                                                    "Vous avez été servi par : Souad\n"            +
                                                    "\n"                                           +
                                                    "CAC IPHONE\n"                                 +
                                                    "3700615033581 1 X 19.99€            19.99€\n" +
                                                    "\n"                                           +
                                                    "dont contribution environnementale :\n"       +
                                                    "CAC IPHONE                           0.01€\n" +
                                                    "------------------------------------------\n" +
                                                    "1 Piéce(s) Total :                  19.99€\n" +
                                                    "Mastercard Visa  :                  19.99€\n" +
                                                    "\n"                                           +
                                                    "Taux TVA    Montant H.T.   T.V.A\n"           +
                                                    "  20%          16.66€      3.33€\n"           +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("Merci de votre visite et. à bientôt.\n" +
                                                    "Conservez votre ticket il\n"            +
                                                    "vous sera demandé pour tout échange.\n"));
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
                encoding = Encoding.GetEncoding("Windows-1252");

                commandBuilder.AppendCodePage(CodePageType.CP1252);
            }

            commandBuilder.AppendInternational(InternationalType.France);

            commandBuilder.AppendCharacterSpace(0);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

//          commandBuilder.Append(encoding.GetBytes("[If loaded.. Logo1 goes here]\n"));
//
//          commandBuilder.AppendLogo(LogoSize.Normal, 1);

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("Star Micronics Communications\n"), 2);

            commandBuilder.Append(encoding.GetBytes("AVENUE LA MOTTE PICQUET\n" +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("------------------------------------------\n" +
                                                    "Date: MM/DD/YYYY    Heure: HH:MM\n"           +
                                                    "Boutique: OLUA23    Caisse: 0001\n"           +
                                                    "Conseiller: 002970  Ticket: 3881\n"           +
                                                    "------------------------------------------\n" +
                                                    "\n"                                           +
                                                    "Vous avez été servi par : Souad\n"            +
                                                    "\n"                                           +
                                                    "CAC IPHONE\n"                                 +
                                                    "3700615033581   1    X   19.99€     19.99€\n" +
                                                    "\n"                                           +
                                                    "dont contribution environnementale :\n"       +
                                                    "CAC IPHONE                           0.01€\n" +
                                                    "------------------------------------------\n" +
                                                    "1 Piéce(s) Total :                  19.99€\n" +
                                                    "Mastercard Visa  :                  19.99€\n" +
                                                    "\n"                                           +
                                                    "Taux TVA    Montant H.T.   T.V.A\n"           +
                                                    "  20%          16.66€      3.33€\n"           +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("Merci de votre visite et. à bientôt.\n" +
                                                    "Conservez votre ticket il\n"            +
                                                    "vous sera demandé pour tout échange.\n"));

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
            return "      Star Micronics\n"       +
                   "      Communications\n"       +
                   "      AVENUE LA MOTTE\n"      +
                   " PICQUET City, State 12345\n" +
                   "\n"                           +
                   "--------------------------\n" +
                   "Date: MM/DD/YYYY\n"           +
                   "Time:HH:MM PM\n"              +
                   "Boutique: OLUA23\n"           +
                   "Caisse: 0001\n"               +
                   "Conseiller: 002970\n"         +
                   "Ticket: 3881\n"               +
                   "--------------------------\n" +
                   "Vous avez été servi par :\n"  +
                   "                     Souad\n" +
                   "CAC IPHONE\n"                 +
                   "3700615033581 1 X   19.99€\n" +
                   "                    19.99€\n" +
                   "dont contribution\n"          +
                   " environnementale :\n"        +
                   "CAC IPHONE           0.01€\n" +
                   "--------------------------\n" +
                   " 1 Piéce(s) Total : 19.99€\n" +
                   "\n"                           +
                   "  Mastercard Visa : 19.99€\n" +
                   "Taux TVA Montant H.T.\n"      +
                   "     20%       16.66€\n"      +
                   "T.V.A\n"                      +
                   "3.33€\n"                      +
                   "Merci de votre visite et.\n"  +
                   "à bientôt.\n"                 +
                   "Conservez votre ticket il\n"  +
                   "vous sera demandé pour\n"     +
                   "tout échange.\n";
        }

        public string Create3inchRasterReceiptString()
        {
            return "      Star Micronics Communications\n"    +
                   "             AVENUE LA MOTTE\n"           +
                   "        PICQUET City, State 12345\n"      +
                   "\n"                                       +
                   "--------------------------------------\n" +
                   "     Date: MM/DD/YYYY    Time:HH:MM PM\n" +
                   "        Boutique: OLUA23  Caisse: 0001\n" +
                   "      Conseiller: 002970  Ticket: 3881\n" +
                   "--------------------------------------\n" +
                   "Vous avez été servi par : Souad\n"        +
                   "CAC IPHONE\n"                             +
                   "3700615033581   1 X 19.99€      19.99€\n" +
                   "dont contribution environnementale :\n"   +
                   "CAC IPHONE                       0.01€\n" +
                   "--------------------------------------\n" +
                   "  1 Piéce(s)    Total :         19.99€\n" +
                   "\n"                                       +
                   "        Mastercard Visa  :      19.99€\n" +
                   "          Taux TVA  Montant H.T. T.V.A\n" +
                   "               20%       16.66€  3.33€\n" +
                   "  Merci de votre visite et. à bientôt.\n" +
                   "   Conservez votre ticket il vous sera\n" +
                   "            demandé pour tout échange.\n";
        }

        public string Create4inchRasterReceiptString()
        {
            return "             Star Micronics Communications\n"              +
                   "       AVENUE LA MOTTE PICQUET City, State 12345\n"        +
                   "\n"                                                        +
                   "-------------------------------------------------------\n" +
                   "                      Date: MM/DD/YYYY    Time:HH:MM PM\n" +
                   "                  Boutique: OLUA23         Caisse: 0001\n" +
                   "                Conseiller: 002970         Ticket: 3881\n" +
                   "-------------------------------------------------------\n" +
                   "Vous avez été servi par : Souad\n"                         +
                   "CAC IPHONE\n"                                              +
                   "3700615033581      1  X  19.99€                  19.99€\n" +
                   "dont contribution environnementale :\n"                    +
                   "CAC IPHONE                                        0.01€\n" +
                   "-------------------------------------------------------\n" +
                   "        1 Piéce(s)    Total :                    19.99€\n" +
                   "\n"                                                        +
                   "        Mastercard Visa  :                       19.99€\n" +
                   "                           Taux TVA  Montant H.T. T.V.A\n" +
                   "                              20%         16.66€  3.33€\n" +
                   "                   Merci de votre visite et. à bientôt.\n" +
                   " Conservez votre ticket il vous sera demandé pour\n"       +
                   " tout échange.\n";
        }

        public Stream CreateCouponImage()
        {
            Assembly assembly = typeof(FrenchReceiptsComponent).GetTypeInfo().Assembly;

            return assembly.GetManifestResourceStream("XamarinSDK.Resources.FrenchCouponImage.png");
        }

        public string CreateEscPos3inchRasterReceiptString()
        {
            return "   Star Micronics Communications\n"    +
                   "           AVENUE LA MOTTE\n"          +
                   "      PICQUET City, State 12345\n"     +
                   "\n"                                    +
                   "-----------------------------------\n" +
                   "  Date: MM/DD/YYYY    Time:HH:MM PM\n" +
                   "     Boutique: OLUA23  Caisse: 0001\n" +
                   "   Conseiller: 002970  Ticket: 3881\n" +
                   "-----------------------------------\n" +
                   "Vous avez été servi par : Souad\n"     +
                   "CAC IPHONE\n"                          +
                   "3700615033581  1 X 19.99€    19.99€\n" +
                   "dont contribution environnementale:\n" +
                   "CAC IPHONE                    0.01€\n" +
                   "-----------------------------------\n" +
                   "  1 Piéce(s)    Total :      19.99€\n" +
                   "\n"                                    +
                   "     Mastercard Visa  :      19.99€\n" +
                   "       Taux TVA  Montant H.T. T.V.A\n" +
                   "            20%       16.66€  3.33€\n" +
                   "Merci de votre visite et.\n"           +
                   "à bientôt.\n"                          +
                   "Conservez votre ticket il vous sera\n" +
                   "demandé pour tout échange.\n";
        }

        public string CreatePasteTextLabelString()
        {
            throw new NotImplementedException();
        }
    }
}
