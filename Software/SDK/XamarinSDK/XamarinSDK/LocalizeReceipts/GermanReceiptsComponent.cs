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
    class GermanReceiptsComponent : ILocalizeReceiptsComponent
    {
        public string LanguageCode
        {
            get { return "De"; }
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

            commandBuilder.AppendInternational(InternationalType.Germany);

            commandBuilder.AppendCharacterSpace(0);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.AppendMultiple(encoding.GetBytes("STAR\n" +
                                                            "Supermarkt\n"), 2, 2);

            commandBuilder.Append(encoding.GetBytes("\n"                        +
                                                    "Das Internet von seiner\n" +
                                                    "genussvollsten Seite\n"    +
                                                    "\n"));

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("www.Star-EMEM.com\n"), 2);

            commandBuilder.Append(encoding.GetBytes("Gebührenfrei Rufnummer:\n"));

            commandBuilder.AppendEmphasis(encoding.GetBytes("08006646701\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("--------------------------------\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Right);

            commandBuilder.AppendEmphasis(encoding.GetBytes("EUR\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("Schmand 24%                 0.42\n" +
                                                    "Kefir                       0.79\n" +
                                                    "Haarspray                   1.79\n" +
                                                    "Gurken ST                   0.59\n" +
                                                    "Mandelknacker               1.59\n" +
                                                    "Mandelknacker               1.59\n" +
                                                    "Nussecken                   1.69\n" +
                                                    "Nussecken                   1.69\n" +
                                                    "Clemen.1kg NZ               1.49\n" +
                                                    "2X\n"                               +
                                                    "Zitronen ST                 1.18\n" +
                                                    "4X\n"                               +
                                                    "Grapefruit                  3.16\n" +
                                                    "Party Garnelen              9.79\n" +
                                                    "Apfelsaft                   1.39\n" +
                                                    "Lauchzw./Schl.B             0.49\n" +
                                                    "Butter                      1.19\n" +
                                                    "Profi-Haartrockner         27.99\n" +
                                                    "Mozarella 45%               0.59\n" +
                                                    "Mozarella 45%               0.59\n" +
                                                    "Bruschetta Brot             0.59\n" +
                                                    "Weizenmehl                  0.39\n" +
                                                    "Jodsalz                     0.19\n" +
                                                    "Eier M braun Bod            1.79\n" +
                                                    "Schlagsahne                 1.69\n" +
                                                    "Schlagsahne                 1.69\n" +
                                                    "\n"                                 +
                                                    "Rueckgeld              EUR  0.00\n" +
                                                    "\n"                                 +
                                                    "19.00% MwSt.               13.14\n" +
                                                    "NETTO-UMSATZ               82.33\n" +
                                                    "--------------------------------\n" +
                                                    "KontoNr:  0551716000 / 0 / 0512\n"  +
                                                    "BLZ:      58862159\n"               +
                                                    "Trace-Nr: 027929\n"                 +
                                                    "Beleg:    7238\n"                   +
                                                    "--------------------------------\n" +
                                                    "Kas: 003/006    Bon  0377 PC01 P\n" +
                                                    "Dat: 30.03.2015 Zeit 18:06:01 43\n" +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("USt–ID:    DE125580123\n" +
                                                    "\n"));

            commandBuilder.AppendEmphasis(encoding.GetBytes("Vielen dank\n"        +
                                                            "für Ihren Einkauf!\n" +
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

            commandBuilder.AppendInternational(InternationalType.Germany);

            commandBuilder.AppendCharacterSpace(0);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.AppendMultiple(encoding.GetBytes("STAR\n" +
                                                            "Supermarkt\n"), 2, 2);

            commandBuilder.Append(encoding.GetBytes("\n"                                             +
                                                    "Das Internet von seiner genussvollsten Seite\n" +
                                                    "\n"));

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("www.Star-EMEM.com\n"), 2);

            commandBuilder.Append(encoding.GetBytes("Gebührenfrei Rufnummer:\n"));

            commandBuilder.AppendEmphasis(encoding.GetBytes("08006646701\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("------------------------------------------------\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Right);

            commandBuilder.AppendEmphasis(encoding.GetBytes("EUR\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("Schmand 24%                                 0.42\n" +
                                                    "Kefir                                       0.79\n" +
                                                    "Haarspray                                   1.79\n" +
                                                    "Gurken ST                                   0.59\n" +
                                                    "Mandelknacker                               1.59\n" +
                                                    "Mandelknacker                               1.59\n" +
                                                    "Nussecken                                   1.69\n" +
                                                    "Nussecken                                   1.69\n" +
                                                    "Clemen.1kg NZ                               1.49\n" +
                                                    "2X\n"                                               +
                                                    "Zitronen ST                                 1.18\n" +
                                                    "4X\n"                                               +
                                                    "Grapefruit                                  3.16\n" +
                                                    "Party Garnelen                              9.79\n" +
                                                    "Apfelsaft                                   1.39\n" +
                                                    "Lauchzw./Schl.B                             0.49\n" +
                                                    "Butter                                      1.19\n" +
                                                    "Profi-Haartrockner                         27.99\n" +
                                                    "Mozarella 45%                               0.59\n" +
                                                    "Mozarella 45%                               0.59\n" +
                                                    "Bruschetta Brot                             0.59\n" +
                                                    "Weizenmehl                                  0.39\n" +
                                                    "Jodsalz                                     0.19\n" +
                                                    "Eier M braun Bod                            1.79\n" +
                                                    "Schlagsahne                                 1.69\n" +
                                                    "Schlagsahne                                 1.69\n" +
                                                    "\n"                                                 +
                                                    "Rueckgeld                              EUR  0.00\n" +
                                                    "\n"                                                 +
                                                    "19.00% MwSt.                               13.14\n" +
                                                    "NETTO-UMSATZ                               82.33\n" +
                                                    "------------------------------------------------\n" +
                                                    "KontoNr:  0551716000 / 0 / 0512\n"                  +
                                                    "BLZ:      58862159\n"                               +
                                                    "Trace-Nr: 027929\n"                                 +
                                                    "Beleg:    7238\n"                                   +
                                                    "------------------------------------------------\n" +
                                                    "Kas: 003/006    Bon  0377 PC01 P\n"                 +
                                                    "Dat: 30.03.2015 Zeit 18:06:01 43\n"                 +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("USt–ID:    DE125580123\n" +
                                                    "\n"));

            commandBuilder.AppendEmphasis(encoding.GetBytes("Vielen dank\n"        +
                                                            "für Ihren Einkauf!\n" +
                                                            "\n"));

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

            commandBuilder.AppendInternational(InternationalType.Germany);

            commandBuilder.AppendCharacterSpace(0);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.AppendMultiple(encoding.GetBytes("STAR\n" +
                                                            "Supermarkt\n"), 2, 2);

            commandBuilder.Append(encoding.GetBytes("\n"                                             +
                                                    "Das Internet von seiner genussvollsten Seite\n" +
                                                    "\n"));

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("www.Star-EMEM.com\n"), 2);

            commandBuilder.Append(encoding.GetBytes("Gebührenfrei Rufnummer:\n"));

            commandBuilder.AppendEmphasis(encoding.GetBytes("08006646701\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("---------------------------------------------------------------------\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Right);

            commandBuilder.AppendEmphasis(encoding.GetBytes("EUR\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("Schmand 24%                                                      0.42\n" +
                                                    "Kefir                                                            0.79\n" +
                                                    "Haarspray                                                        1.79\n" +
                                                    "Gurken ST                                                        0.59\n" +
                                                    "Mandelknacker                                                    1.59\n" +
                                                    "Mandelknacker                                                    1.59\n" +
                                                    "Nussecken                                                        1.69\n" +
                                                    "Nussecken                                                        1.69\n" +
                                                    "Clemen.1kg NZ                                                    1.49\n" +
                                                    "2X\n"                                                                    +
                                                    "Zitronen ST                                                      1.18\n" +
                                                    "4X\n"                                                                    +
                                                    "Grapefruit                                                       3.16\n" +
                                                    "Party Garnelen                                                   9.79\n" +
                                                    "Apfelsaft                                                        1.39\n" +
                                                    "Lauchzw./Schl.B                                                  0.49\n" +
                                                    "Butter                                                           1.19\n" +
                                                    "Profi-Haartrockner                                              27.99\n" +
                                                    "Mozarella 45%                                                    0.59\n" +
                                                    "Mozarella 45%                                                    0.59\n" +
                                                    "Bruschetta Brot                                                  0.59\n" +
                                                    "Weizenmehl                                                       0.39\n" +
                                                    "Jodsalz                                                          0.19\n" +
                                                    "Eier M braun Bod                                                 1.79\n" +
                                                    "Schlagsahne                                                      1.69\n" +
                                                    "Schlagsahne                                                      1.69\n" +
                                                    "\n"                                                                      +
                                                    "Rueckgeld                                                   EUR  0.00\n" +
                                                    "\n"                                                                      +
                                                    "19.00% MwSt.                                                    13.14\n" +
                                                    "NETTO-UMSATZ                                                    82.33\n" +
                                                    "---------------------------------------------------------------------\n" +
                                                    "KontoNr:  0551716000 / 0 / 0512\n"                                       +
                                                    "BLZ:      58862159\n"                                                    +
                                                    "Trace-Nr: 027929\n"                                                      +
                                                    "Beleg:    7238\n"                                                        +
                                                    "---------------------------------------------------------------------\n" +
                                                    "Kas: 003/006    Bon  0377 PC01 P\n"                                      +
                                                    "Dat: 30.03.2015 Zeit 18:06:01 43\n"                                      +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("USt–ID:    DE125580123\n" +
                                                    "\n"));

            commandBuilder.AppendEmphasis(encoding.GetBytes("Vielen dank\n"        +
                                                            "für Ihren Einkauf!\n" +
                                                            "\n"));

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

            commandBuilder.AppendInternational(InternationalType.Germany);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.AppendMultiple(encoding.GetBytes("STAR\n" +
                                                            "Supermarkt\n"), 2, 2);

            commandBuilder.Append(encoding.GetBytes("\n"                        +
                                                    "Das Internet von seiner\n" +
                                                    "genussvollsten Seite\n"    +
                                                    "\n"));

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("www.Star-EMEM.com\n"), 2);

            commandBuilder.Append(encoding.GetBytes("Gebührenfrei Rufnummer:\n"));

            commandBuilder.AppendEmphasis(encoding.GetBytes("08006646701\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("------------------------------------------\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Right);

            commandBuilder.AppendEmphasis(encoding.GetBytes("EUR\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("Schmand 24%                           0.42\n" +
                                                    "Kefir                                 0.79\n" +
                                                    "Haarspray                             1.79\n" +
                                                    "Gurken ST                             0.59\n" +
                                                    "Mandelknacker                         1.59\n" +
                                                    "Mandelknacker                         1.59\n" +
                                                    "Nussecken                             1.69\n" +
                                                    "Nussecken                             1.69\n" +
                                                    "Clemen.1kg NZ                         1.49\n" +
                                                    "2X\n"                                         +
                                                    "Zitronen ST                           1.18\n" +
                                                    "4X\n"                                         +
                                                    "Grapefruit                            3.16\n" +
                                                    "Party Garnelen                        9.79\n" +
                                                    "Apfelsaft                             1.39\n" +
                                                    "Lauchzw./Schl.B                       0.49\n" +
                                                    "Butter                                1.19\n" +
                                                    "Profi-Haartrockner                   27.99\n" +
                                                    "Mozarella 45%                         0.59\n" +
                                                    "Mozarella 45%                         0.59\n" +
                                                    "Bruschetta Brot                       0.59\n" +
                                                    "Weizenmehl                            0.39\n" +
                                                    "Jodsalz                               0.19\n" +
                                                    "Eier M braun Bod                      1.79\n" +
                                                    "Schlagsahne                           1.69\n" +
                                                    "Schlagsahne                           1.69\n" +
                                                    "\n"                                           +
                                                    "Rueckgeld                        EUR  0.00\n" +
                                                    "\n"                                           +
                                                    "19.00% MwSt.                         13.14\n" +
                                                    "NETTO-UMSATZ                         82.33\n" +
                                                    "------------------------------------------\n" +
                                                    "KontoNr:  0551716000 / 0 / 0512\n"            +
                                                    "BLZ:      58862159\n"                         +
                                                    "Trace-Nr: 027929\n"                           +
                                                    "Beleg:    7238\n"                             +
                                                    "------------------------------------------\n" +
                                                    "Kas: 003/006    Bon  0377 PC01 P\n"           +
                                                    "Dat: 30.03.2015 Zeit 18:06:01 43\n"           +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("USt–ID:    DE125580123\n" +
                                                    "\n"));

            commandBuilder.AppendEmphasis(encoding.GetBytes("Vielen dank\n" +
                                                            "für Ihren Einkauf!\n"));
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

            commandBuilder.AppendInternational(InternationalType.Germany);

            commandBuilder.AppendCharacterSpace(0);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.AppendMultiple(encoding.GetBytes("STAR\n" +
                                                            "Supermarkt\n"), 2, 2);

            commandBuilder.Append(encoding.GetBytes("\n"                        +
                                                    "Das Internet von seiner\n" +
                                                    "genussvollsten Seite\n"    +
                                                    "\n"));

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("www.Star-EMEM.com\n"), 2);

            commandBuilder.Append(encoding.GetBytes("Gebührenfrei Rufnummer:\n"));

            commandBuilder.AppendEmphasis(encoding.GetBytes("08006646701\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("------------------------------------------\n"));

            commandBuilder.AppendEmphasis(encoding.GetBytes("                                       EUR\n"));

            commandBuilder.Append(encoding.GetBytes("Schmand 24%                           0.42\n" +
                                                    "Kefir                                 0.79\n" +
                                                    "Haarspray                             1.79\n" +
                                                    "Gurken ST                             0.59\n" +
                                                    "Mandelknacker                         1.59\n" +
                                                    "Mandelknacker                         1.59\n" +
                                                    "Nussecken                             1.69\n" +
                                                    "Nussecken                             1.69\n" +
                                                    "Clemen.1kg NZ                         1.49\n" +
                                                    "2X\n"                                         +
                                                    "Zitronen ST                           1.18\n" +
                                                    "4X\n"                                         +
                                                    "Grapefruit                            3.16\n" +
                                                    "Party Garnelen                        9.79\n" +
                                                    "Apfelsaft                             1.39\n" +
                                                    "Lauchzw./Schl.B                       0.49\n" +
                                                    "Butter                                1.19\n" +
                                                    "Profi-Haartrockner                   27.99\n" +
                                                    "Mozarella 45%                         0.59\n" +
                                                    "Mozarella 45%                         0.59\n" +
                                                    "Bruschetta Brot                       0.59\n" +
                                                    "Weizenmehl                            0.39\n" +
                                                    "Jodsalz                               0.19\n" +
                                                    "Eier M braun Bod                      1.79\n" +
                                                    "Schlagsahne                           1.69\n" +
                                                    "Schlagsahne                           1.69\n" +
                                                    "\n"                                           +
                                                    "Rueckgeld                        EUR  0.00\n" +
                                                    "\n"                                           +
                                                    "19.00% MwSt.                         13.14\n" +
                                                    "NETTO-UMSATZ                         82.33\n" +
                                                    "------------------------------------------\n" +
                                                    "KontoNr:  0551716000 / 0 / 0512\n"            +
                                                    "BLZ:      58862159\n"                         +
                                                    "Trace-Nr: 027929\n"                           +
                                                    "Beleg:    7238\n"                             +
                                                    "------------------------------------------\n" +
                                                    "Kas: 003/006    Bon  0377 PC01 P\n"           +
                                                    "Dat: 30.03.2015 Zeit 18:06:01 43\n"           +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("USt–ID:    DE125580123\n" +
                                                    "\n"));

            commandBuilder.AppendEmphasis(encoding.GetBytes("Vielen dank\n"        +
                                                            "für Ihren Einkauf!\n" +
                                                            "\n"));

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
            return "           STAR\n"            +
                   "        Supermarkt\n"         +
                   "\n"                           +
                   " Das Internet von seiner\n"   +
                   "   genussvollsten Seite\n"    +
                   "\n"                           +
                   "    www.Star-EMEM.com\n"      +
                   " Gebührenfrei Rufnummer:\n"   +
                   "       08006646701\n"         +
                   "--------------------------\n" +
                   "                       EUR\n" +
                   "Schmand 24%           0.42\n" +
                   "Kefir                 0.79\n" +
                   "Haarspray             1.79\n" +
                   "Gurken ST             0.59\n" +
                   "Mandelknacker         1.59\n" +
                   "Mandelknacker         1.59\n" +
                   "Nussecken             1.69\n" +
                   "Nussecken             1.69\n" +
                   "Clemen.1kg NZ         1.49\n" +
                   "2X\n"                         +
                   "Zitronen ST           1.18\n" +
                   "4X\n"                         +
                   "Grapefruit            3.16\n" +
                   "Party Garnelen        9.79\n" +
                   "Apfelsaft             1.39\n" +
                   "Lauchzw./Schl.B       0.49\n" +
                   "Butter                1.19\n" +
                   "Profi-Haartrockner   27.99\n" +
                   "Mozarella 45%         0.59\n" +
                   "Mozarella 45%         0.59\n" +
                   "Bruschetta Brot       0.59\n" +
                   "Weizenmehl            0.39\n" +
                   "Jodsalz               0.19\n" +
                   "Eier M braun Bod      1.79\n" +
                   "Schlagsahne           1.69\n" +
                   "Schlagsahne           1.69\n" +
                   "\n"                           +
                   "Rueckgeld        EUR  0.00\n" +
                   "\n"                           +
                   "19.00% MwSt.         13.14\n" +
                   "NETTO-UMSATZ         82.33\n" +
                   "--------------------------\n" +
                   "KontoNr: 0551716000/0/0512\n" +
                   "BLZ:     58862159\n"          +
                   "Trace-Nr:027929\n"            +
                   "Beleg:   7238\n"              +
                   "--------------------------\n" +
                   "Kas:003/006 Bon0377 PC01 P\n" +
                   "Dat:30.03.2015\n"             +
                   "Zeit18:06:01            43\n" +
                   "\n"                           +
                   "  USt–ID:    DE125580123\n"   +
                   "\n"                           +
                   "       Vielen dank\n"         +
                   "    für Ihren Einkauf!\n";
        }

        public string Create3inchRasterReceiptString()
        {
            return "                 STAR\n"                  +
                   "              Supermarkt\n"               +
                   "\n"                                       +
                   "       Das Internet von seiner\n"         +
                   "         genussvollsten Seite\n"          +
                   "\n"                                       +
                   "          www.Star-EMEM.com\n"            +
                   "       Gebührenfrei Rufnummer:\n"         +
                   "             08006646701\n"               +
                   "--------------------------------------\n" +
                   "                                   EUR\n" +
                   "Schmand 24%                       0.42\n" +
                   "Kefir                             0.79\n" +
                   "Haarspray                         1.79\n" +
                   "Gurken ST                         0.59\n" +
                   "Mandelknacker                     1.59\n" +
                   "Mandelknacker                     1.59\n" +
                   "Nussecken                         1.69\n" +
                   "Nussecken                         1.69\n" +
                   "Clemen.1kg NZ                     1.49\n" +
                   "2X\n"                                     +
                   "Zitronen ST                       1.18\n" +
                   "4X\n"                                     +
                   "Grapefruit                        3.16\n" +
                   "Party Garnelen                    9.79\n" +
                   "Apfelsaft                         1.39\n" +
                   "Lauchzw./Schl.B                   0.49\n" +
                   "Butter                            1.19\n" +
                   "Profi-Haartrockner               27.99\n" +
                   "Mozarella 45%                     0.59\n" +
                   "Mozarella 45%                     0.59\n" +
                   "Bruschetta Brot                   0.59\n" +
                   "Weizenmehl                        0.39\n" +
                   "Jodsalz                           0.19\n" +
                   "Eier M braun Bod                  1.79\n" +
                   "Schlagsahne                       1.69\n" +
                   "Schlagsahne                       1.69\n" +
                   "\n"                                       +
                   "Rueckgeld                    EUR  0.00\n" +
                   "\n"                                       +
                   "19.00% MwSt.                     13.14\n" +
                   "NETTO-UMSATZ                     82.33\n" +
                   "--------------------------------------\n" +
                   "KontoNr:  0551716000 / 0 / 0512\n"        +
                   "BLZ:      58862159\n"                     +
                   "Trace-Nr: 027929\n"                       +
                   "Beleg:    7238\n"                         +
                   "--------------------------------------\n" +
                   "Kas: 003/006    Bon  0377 PC01 P\n"       +
                   "Dat: 30.03.2015 Zeit 18:06:01 43\n"       +
                   "\n"                                       +
                   "        USt–ID:    DE125580123\n"         +
                   "\n"                                       +
                   "             Vielen dank\n"               +
                   "          für Ihren Einkauf!\n";
        }

        public string Create4inchRasterReceiptString()
        {
            return "                          STAR\n"                            +
                   "                       Supermarkt\n"                         +
                   "\n"                                                          +
                   "                Das Internet von seiner\n"                   +
                   "                  genussvollsten Seite\n"                    +
                   "\n"                                                          +
                   "                   www.Star-EMEM.com\n"                      +
                   "                Gebührenfrei Rufnummer:\n"                   +
                   "                      08006646701\n"                         +
                   "---------------------------------------------------------\n" +
                   "                                                      EUR\n" +
                   "Schmand 24%                                          0.42\n" +
                   "Kefir                                                0.79\n" +
                   "Haarspray                                            1.79\n" +
                   "Gurken ST                                            0.59\n" +
                   "Mandelknacker                                        1.59\n" +
                   "Mandelknacker                                        1.59\n" +
                   "Nussecken                                            1.69\n" +
                   "Nussecken                                            1.69\n" +
                   "Clemen.1kg NZ                                        1.49\n" +
                   "2X\n"                                                        +
                   "Zitronen ST                                          1.18\n" +
                   "4X\n"                                                        +
                   "Grapefruit                                           3.16\n" +
                   "Party Garnelen                                       9.79\n" +
                   "Apfelsaft                                            1.39\n" +
                   "Lauchzw./Schl.B                                      0.49\n" +
                   "Butter                                               1.19\n" +
                   "Profi-Haartrockner                                  27.99\n" +
                   "Mozarella 45%                                        0.59\n" +
                   "Mozarella 45%                                        0.59\n" +
                   "Bruschetta Brot                                      0.59\n" +
                   "Weizenmehl                                           0.39\n" +
                   "Jodsalz                                              0.19\n" +
                   "Eier M braun Bod                                     1.79\n" +
                   "Schlagsahne                                          1.69\n" +
                   "Schlagsahne                                          1.69\n" +
                   "\n"                                                          +
                   "Rueckgeld                                       EUR  0.00\n" +
                   "\n"                                                          +
                   "19.00% MwSt.                                        13.14\n" +
                   "NETTO-UMSATZ                                        82.33\n" +
                   "---------------------------------------------------------\n" +
                   "KontoNr:  0551716000 / 0 / 0512\n"                           +
                   "BLZ:      58862159\n"                                        +
                   "Trace-Nr: 027929\n"                                          +
                   "Beleg:    7238\n"                                            +
                   "---------------------------------------------------------\n" +
                   "Kas: 003/006    Bon  0377 PC01 P\n"                          +
                   "Dat: 30.03.2015 Zeit 18:06:01 43\n"                          +
                   "\n"                                                          +
                   "                 USt–ID:    DE125580123\n"                   +
                   "\n"                                                          +
                   "                      Vielen dank\n"                         +
                   "                   für Ihren Einkauf!\n";
        }

        public Stream CreateCouponImage()
        {
            Assembly assembly = typeof(GermanReceiptsComponent).GetTypeInfo().Assembly;

            return assembly.GetManifestResourceStream("XamarinSDK.Resources.GermanCouponImage.png");
        }

        public string CreateEscPos3inchRasterReceiptString()
        {
            return "               STAR\n"                 +
                   "            Supermarkt\n"              +
                   "\n"                                    +
                   "      Das Internet von seiner\n"       +
                   "       genussvollsten Seite\n"         +
                   "\n"                                    +
                   "         www.Star-EMEM.com\n"          +
                   "      Gebührenfrei Rufnummer:\n"       +
                   "            08006646701\n"             +
                   "-----------------------------------\n" +
                   "                                EUR\n" +
                   "Schmand 24%                    0.42\n" +
                   "Kefir                          0.79\n" +
                   "Haarspray                      1.79\n" +
                   "Gurken ST                      0.59\n" +
                   "Mandelknacker                  1.59\n" +
                   "Mandelknacker                  1.59\n" +
                   "Nussecken                      1.69\n" +
                   "Nussecken                      1.69\n" +
                   "Clemen.1kg NZ                  1.49\n" +
                   "2X\n"                                  +
                   "Zitronen ST                    1.18\n" +
                   "4X\n"                                  +
                   "Grapefruit                     3.16\n" +
                   "Party Garnelen                 9.79\n" +
                   "Apfelsaft                      1.39\n" +
                   "Lauchzw./Schl.B                0.49\n" +
                   "Butter                         1.19\n" +
                   "Profi-Haartrockner            27.99\n" +
                   "Mozarella 45%                  0.59\n" +
                   "Mozarella 45%                  0.59\n" +
                   "Bruschetta Brot                0.59\n" +
                   "Weizenmehl                     0.39\n" +
                   "Jodsalz                        0.19\n" +
                   "Eier M braun Bod               1.79\n" +
                   "Schlagsahne                    1.69\n" +
                   "Schlagsahne                    1.69\n" +
                   "\n"                                    +
                   "Rueckgeld                 EUR  0.00\n" +
                   "\n"                                    +
                   "19.00% MwSt.                  13.14\n" +
                   "NETTO-UMSATZ                  82.33\n" +
                   "-----------------------------------\n" +
                   "KontoNr:  0551716000 / 0 / 0512\n"     +
                   "BLZ:      58862159\n"                  +
                   "Trace-Nr: 027929\n"                    +
                   "Beleg:    7238\n"                      +
                   "-----------------------------------\n" +
                   "Kas: 003/006    Bon  0377 PC01 P\n"    +
                   "Dat: 30.03.2015 Zeit 18:06:01 43\n"    +
                   "\n"                                    +
                   "      USt–ID:    DE125580123\n"        +
                   "\n"                                    +
                   "            Vielen dank\n"             +
                   "        für Ihren Einkauf!\n";
        }

        public string CreatePasteTextLabelString()
        {
            throw new NotImplementedException();
        }
    }
}
