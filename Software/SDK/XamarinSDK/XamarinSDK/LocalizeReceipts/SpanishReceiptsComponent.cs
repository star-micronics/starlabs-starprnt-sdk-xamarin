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
    class SpanishReceiptsComponent : ILocalizeReceiptsComponent
    {
        public string LanguageCode
        {
            get { return "Es"; }
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

            commandBuilder.AppendInternational(InternationalType.Spain);

            commandBuilder.AppendCharacterSpace(0);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.AppendMultiple(encoding.GetBytes("BAR RESTAURANT\n" +
                                                            "EL POZO\n"), 2, 2);

            commandBuilder.Append(encoding.GetBytes("C/.ROCAFORT 187\n" +
                                                    "08029 BARCELONA\n" +
                                                    "\n"                +
                                                    "NIF :X-3856907Z\n" +
                                                    "TEL :934199465\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("--------------------------------\n" +
                                                    "MESA: 100 P: - FECHA: YYYY-MM-DD\n" +
                                                    "CAN P/U DESCRIPCION  SUMA\n"        +
                                                    "--------------------------------\n" +
                                                    " 4  3,00  JARRA  CERVEZA   12,00\n" +
                                                    " 1  1,60  COPA DE CERVEZA   1,60\n" +
                                                    "--------------------------------\n" +
                                                    "               SUB TOTAL : 13,60\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Right);

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("TOTAL:     13,60 EUROS\n"), 2);

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("NO: 000018851     IVA INCLUIDO\n" +
                                                    "--------------------------------\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("**** GRACIAS POR SU VISITA! ****\n" +
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

            commandBuilder.AppendInternational(InternationalType.Spain);

            commandBuilder.AppendCharacterSpace(0);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

//          commandBuilder.Append(encoding.GetBytes("[If loaded.. Logo1 goes here]\n"));
//
//          commandBuilder.AppendLogo(LogoSize.Normal, 1);

            commandBuilder.AppendMultiple(encoding.GetBytes("BAR RESTAURANT EL POZO\n"), 2, 2);

            commandBuilder.Append(encoding.GetBytes("C/.ROCAFORT 187 08029 BARCELONA\n" +
                                                    "NIF :X-3856907Z  TEL :934199465\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("------------------------------------------------\n" +
                                                    "MESA: 100 P: - FECHA: YYYY-MM-DD\n"                 +
                                                    "CAN P/U DESCRIPCION  SUMA\n"                        +
                                                    "------------------------------------------------\n" +
                                                    " 4     3,00      JARRA  CERVEZA            12,00\n" +
                                                    " 1     1,60      COPA DE CERVEZA            1,60\n" +
                                                    "------------------------------------------------\n" +
                                                    "                           SUB TOTAL :     13,60\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Right);

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("TOTAL:     13,60 EUROS\n"), 2);

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("NO: 000018851  IVA INCLUIDO\n" +
                                                    "------------------------------------------------\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("**** GRACIAS POR SU VISITA! ****\n" +
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

            commandBuilder.AppendInternational(InternationalType.Spain);

            commandBuilder.AppendCharacterSpace(0);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

//          commandBuilder.Append(encoding.GetBytes("[If loaded.. Logo1 goes here]\n"));
//
//          commandBuilder.AppendLogo(LogoSize.Normal, 1);

            commandBuilder.AppendMultiple(encoding.GetBytes("BAR RESTAURANT EL POZO\n"), 2, 2);

            commandBuilder.Append(encoding.GetBytes("C/.ROCAFORT 187 08029 BARCELONA\n" +
                                                    "NIF :X-3856907Z  TEL :934199465\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("---------------------------------------------------------------------\n" +
                                                    "MESA: 100 P: - FECHA: YYYY-MM-DD\n"                                      +
                                                    "CAN P/U DESCRIPCION  SUMA\n"                                             +
                                                    "---------------------------------------------------------------------\n" +
                                                    " 4     3,00          JARRA  CERVEZA                             12,00\n" +
                                                    " 1     1,60          COPA DE CERVEZA                             1,60\n" +
                                                    "---------------------------------------------------------------------\n" +
                                                    "                                         SUB TOTAL :            13,60\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Right);

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("TOTAL:     13,60 EUROS\n"), 2);

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("NO: 000018851  IVA INCLUIDO\n" +
                                                    "---------------------------------------------------------------------\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("**** GRACIAS POR SU VISITA! ****\n" +
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

            commandBuilder.AppendInternational(InternationalType.Spain);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

//          commandBuilder.Append(encoding.GetBytes("[If loaded.. Logo1 goes here]\n"));
//
//          commandBuilder.AppendLogo(LogoSize.Normal, 1);

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("BAR RESTAURANT EL POZO\n"), 2);

            commandBuilder.Append(encoding.GetBytes("C/.ROCAFORT 187 08029 BARCELONA\n" +
                                                    "NIF :X-3856907Z  TEL :934199465\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("------------------------------------------\n" +
                                                    "MESA: 100 P: - FECHA: YYYY-MM-DD\n"           +
                                                    "CAN P/U DESCRIPCION  SUMA\n"                  +
                                                    "------------------------------------------\n" +
                                                    " 4 3,00 JARRA  CERVEZA               12,00\n" +
                                                    " 1 1,60 COPA DE CERVEZA               1,60\n" +
                                                    "------------------------------------------\n" +
                                                    " SUB TOTAL :                         13,60\n" +
                                                    "                     TOTAL:    13,60 EUROS\n" +
                                                    "NO: 000018851  IVA INCLUIDO\n"                +
                                                    "------------------------------------------\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("**** GRACIAS POR SU VISITA! ****\n"));
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

            commandBuilder.AppendInternational(InternationalType.Spain);

            commandBuilder.AppendCharacterSpace(0);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

//          commandBuilder.Append(encoding.GetBytes("[If loaded.. Logo1 goes here]\n"));
//
//          commandBuilder.AppendLogo(LogoSize.Normal, 1);

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("BAR RESTAURANT EL POZO\n"), 2);

            commandBuilder.Append(encoding.GetBytes("C/.ROCAFORT 187 08029 BARCELONA\n" +
                                                    "NIF :X-3856907Z  TEL :934199465\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("------------------------------------------\n" +
                                                    "MESA: 100 P: - FECHA: YYYY-MM-DD\n"           +
                                                    "CAN P/U DESCRIPCION  SUMA\n"                  +
                                                    "------------------------------------------\n" +
                                                    " 4    3,00    JARRA  CERVEZA         12,00\n" +
                                                    " 1    1,60    COPA DE CERVEZA         1,60\n" +
                                                    "------------------------------------------\n" +
                                                    "                     SUB TOTAL :     13,60\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Right);

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("TOTAL:     13,60 EUROS\n"), 2);

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("NO: 000018851  IVA INCLUIDO\n" +
                                                    "------------------------------------------\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("**** GRACIAS POR SU VISITA! ****\n" +
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
            return "     BAR RESTAURANT\n"        +
                   "                   EL POZO\n" +
                   "C/.ROCAFORT 187\n"            +
                   "08029 BARCELONA\n"            +
                   "NIF :X-3856907Z\n"            +
                   "TEL :934199465\n"             +
                   "--------------------------\n" +
                   "MESA: 100 P: -\n"             +
                   "    FECHA: YYYY-MM-DD\n"      +
                   "CAN P/U DESCRIPCION  SUMA\n"  +
                   "--------------------------\n" +
                   "3,00 JARRA  CERVEZA  12,00\n" +
                   "1,60 COPA DE CERVEZA  1,60\n" +
                   "--------------------------\n" +
                   "         SUB TOTAL : 13,60\n" +
                   "TOTAL:         13,60 EUROS\n" +
                   " NO:000018851 IVA INCLUIDO\n" +
                   "\n"                           +
                   "--------------------------\n" +
                   "**GRACIAS POR SU VISITA!**\n";
        }

        public string Create3inchRasterReceiptString()
        {
            return "                        BAR RESTAURANT\n" +
                   "                               EL POZO\n" +
                   "C/.ROCAFORT 187\n"                        +
                   "08029 BARCELONA\n"                        +
                   "NIF :X-3856907Z\n"                        +
                   "TEL :934199465\n"                         +
                   "--------------------------------------\n" +
                   "MESA: 100 P: - FECHA: YYYY-MM-DD\n"       +
                   "CAN P/U DESCRIPCION  SUMA\n"              +
                   "--------------------------------------\n" +
                   "4 3,00 JARRA  CERVEZA   12,00\n"          +
                   "1 1,60 COPA DE CERVEZA  1,60\n"           +
                   "--------------------------------------\n" +
                   "                     SUB TOTAL : 13,60\n" +
                   "TOTAL:               13,60 EUROS\n"       +
                   "NO: 000018851 IVA INCLUIDO\n"             +
                   "\n"                                       +
                   "--------------------------------------\n" +
                   "            **GRACIAS POR SU VISITA!**\n";
        }

        public string Create4inchRasterReceiptString()
        {
            return "                                   BAR RESTAURANT EL POZO\n" +
                   "                          C/.ROCAFORT 187 08029 BARCELONA\n" +
                   "                          NIF :X-3856907Z  TEL :934199465\n" +
                   "---------------------------------------------------------\n" +
                   "MESA: 100 P: - FECHA: YYYY-MM-DD\n"                          +
                   "CAN P/U DESCRIPCION  SUMA\n"                                 +
                   "---------------------------------------------------------\n" +
                   "4    3,00    JARRA  CERVEZA                         12,00\n" +
                   "1    1,60    COPA DE CERVEZA                         1,60\n" +
                   "---------------------------------------------------------\n" +
                   "                                  SUB TOTAL :       13,60\n" +
                   "                                 TOTAL :      13,60 EUROS\n" +
                   "NO: 000018851 IVA INCLUIDO\n"                                +
                   "\n"                                                          +
                   "---------------------------------------------------------\n" +
                   "                             ***GRACIAS POR SU VISITA!***\n";
        }

        public Stream CreateCouponImage()
        {
            Assembly assembly = typeof(SpanishReceiptsComponent).GetTypeInfo().Assembly;

            return assembly.GetManifestResourceStream("XamarinSDK.Resources.SpanishCouponImage.png");
        }

        public string CreateEscPos3inchRasterReceiptString()
        {
            return "                     BAR RESTAURANT\n" +
                   "                            EL POZO\n" +
                   "C/.ROCAFORT 187\n"                     +
                   "08029 BARCELONA\n"                     +
                   "NIF :X-3856907Z\n"                     +
                   "TEL :934199465\n"                      +
                   "-----------------------------------\n" +
                   "MESA: 100 P: - FECHA: YYYY-MM-DD\n"    +
                   "CAN P/U DESCRIPCION  SUMA\n"           +
                   "-----------------------------------\n" +
                   "4 3,00 JARRA  CERVEZA   12,00\n"       +
                   "1 1,60 COPA DE CERVEZA  1,60\n"        +
                   "-----------------------------------\n" +
                   "                  SUB TOTAL : 13,60\n" +
                   "TOTAL:               13,60 EUROS\n"    +
                   "NO: 000018851 IVA INCLUIDO\n"          +
                   "\n"                                    +
                   "-----------------------------------\n" +
                   "         **GRACIAS POR SU VISITA!**\n";
        }

        public string CreatePasteTextLabelString()
        {
            throw new NotImplementedException();
        }
    }
}
