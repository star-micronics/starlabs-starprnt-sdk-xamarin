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
    class PortugueseReceiptsComponent : ILocalizeReceiptsComponent
    {
        public string LanguageCode
        {
            get { return "Pt"; }
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

//          commandBuilder.AppendInternational(InternationalType.UK);

            commandBuilder.AppendCharacterSpace(0);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("COMERCIAL DE ALIMENTOS\n" +
                                                                  "STAR LTDA.\n"), 2);

            commandBuilder.Append(encoding.GetBytes("Avenida Moyses Roysen,\n"          +
                                                    "S/N Vila Guilherme\n"              +
                                                    "Cep: 02049-010 – Sao Paulo – SP\n" +
                                                    "CNPJ: 62.545.579/0013-69\n"        +
                                                    "IE:110.819.138.118\n"              +
                                                    "IM: 9.041.041-5\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("--------------------------------\n" +
                                                    "MM/DD/YYYY HH:MM:SS\n"              +
                                                    "CCF:133939 COO:227808\n"            +
                                                    "--------------------------------\n" +
                                                    "CUPOM FISCAL\n"                     +
                                                    "--------------------------------\n" +
                                                    "001 2505 CAFÉ DO PONTO TRAD A\n"    +
                                                    "                    1un F1 8,15)\n" +
                                                    "002 2505 CAFÉ DO PONTO TRAD A\n"    +
                                                    "                    1un F1 8,15)\n" +
                                                    "003 2505 CAFÉ DO PONTO TRAD A\n"    +
                                                    "                    1un F1 8,15)\n" +
                                                    "004 6129 AGU MIN NESTLE 510ML\n"    +
                                                    "                    1un F1 1,39)\n" +
                                                    "005 6129 AGU MIN NESTLE 510ML\n"    +
                                                    "                    1un F1 1,39)\n" +
                                                    "--------------------------------\n"));

            commandBuilder.AppendMultipleWidth(encoding.GetBytes("TOTAL  R$  27,23\n"), 2);

            commandBuilder.Append(encoding.GetBytes("DINHEIROv                  29,00\n" +
                                                    "TROCO R$                    1,77\n" +
                                                    "Valor dos Tributos R$2,15(7,90%)\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("ITEM(S) CINORADIS 5\n"           +
                                                    "OP.:15326  PDV:9  BR,BF:93466\n" +
                                                    "OBRIGADO PERA PREFERENCIA.\n"));

            commandBuilder.AppendMultipleWidth(encoding.GetBytes("VOLTE SEMPRE!\n" +
                                                                 "\n"), 2);

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("SAC 0800 724 2822\n"                +
                                                    "--------------------------------\n" +
                                                    "MD5:\n"                             +
                                                    "fe028828a532a7dbaf4271155aa4e2db\n" +
                                                    "Calypso_CA CA.20.c13\n"             +
                                                    " – Unisys Brasil\n"                 +
                                                    "--------------------------------\n" +
                                                    "DARUMA AUTOMAÇÃO   MACH 2\n"        +
                                                    "ECF-IF VERSÃO:01,00,00 ECF:093\n"   +
                                                    "Lj:0204 OPR:ANGELA JORGE\n"         +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("DDDDDDDDDAEHFGBFCC\n"       +
                                                    "MM/DD/YYYY HH:MM:SS\n"      +
                                                    "FAB:DR0911BR000000275026\n" +
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

//          commandBuilder.AppendInternational(InternationalType.UK);

            commandBuilder.AppendCharacterSpace(0);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

//          commandBuilder.Append(encoding.GetBytes("[If loaded.. Logo1 goes here]\n"));
//
//          commandBuilder.AppendLogo(LogoSize.Normal, 1);

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("COMERCIAL DE ALIMENTOS STAR LTDA.\n"), 2);

            commandBuilder.Append(encoding.GetBytes("Avenida Moyses Roysen, S/N  Vila Guilherme\n" +
                                                    "Cep: 02049-010 – Sao Paulo – SP\n"            +
                                                    "CNPJ: 62.545.579/0013-69\n"                   +
                                                    "IE:110.819.138.118  IM: 9.041.041-5\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("------------------------------------------------\n" +
                                                    "MM/DD/YYYY HH:MM:SS  CCF:133939 COO:227808\n"       +
                                                    "------------------------------------------------\n" +
                                                    "CUPOM FISCAL\n"                                     +
                                                    "------------------------------------------------\n" +
                                                    "001  2505  CAFÉ DO PONTO TRAD A  1un F1  8,15)\n"   +
                                                    "002  2505  CAFÉ DO PONTO TRAD A  1un F1  8,15)\n"   +
                                                    "003  2505  CAFÉ DO PONTO TRAD A  1un F1  8,15)\n"   +
                                                    "004  6129  AGU MIN NESTLE 510ML  1un F1  1,39)\n"   +
                                                    "005  6129  AGU MIN NESTLE 510ML  1un F1  1,39)\n"   +
                                                    "------------------------------------------------\n"));

            commandBuilder.AppendMultipleWidth(encoding.GetBytes("TOTAL  R$         27,23\n"), 2);

            commandBuilder.Append(encoding.GetBytes("DINHEIROv                                29,00\n" +
                                                    "TROCO R$                                  1,77\n" +
                                                    "Valor dos Tributos R$2,15 (7,90%)\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("ITEM(S) CINORADIS 5\n"           +
                                                    "OP.:15326  PDV:9  BR,BF:93466\n" +
                                                    "OBRIGADO PERA PREFERENCIA.\n"));

            commandBuilder.AppendMultipleWidth(encoding.GetBytes("VOLTE SEMPRE!\n" +
                                                                 "\n"), 2);

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("SAC 0800 724 2822\n"                                +
                                                    "------------------------------------------------\n" +
                                                    "MD5:fe028828a532a7dbaf4271155aa4e2db\n"             +
                                                    "Calypso_CA CA.20.c13 – Unisys Brasil\n"             +
                                                    "------------------------------------------------\n" +
                                                    "DARUMA AUTOMAÇÃO   MACH 2\n"                        +
                                                    "ECF-IF VERSÃO:01,00,00 ECF:093\n"                   +
                                                    "Lj:0204 OPR:ANGELA JORGE\n"                         +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("DDDDDDDDDAEHFGBFCC\n"       +
                                                    "MM/DD/YYYY HH:MM:SS\n"      +
                                                    "FAB:DR0911BR000000275026\n" +
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

//          commandBuilder.AppendInternational(InternationalType.UK);

            commandBuilder.AppendCharacterSpace(0);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

//          commandBuilder.Append(encoding.GetBytes("[If loaded.. Logo1 goes here]\n"));
//
//          commandBuilder.AppendLogo(LogoSize.Normal, 1);

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("COMERCIAL DE ALIMENTOS STAR LTDA.\n"), 2);

            commandBuilder.Append(encoding.GetBytes("Avenida Moyses Roysen, S/N  Vila Guilherme\n" +
                                                    "Cep: 02049-010 – Sao Paulo – SP\n"            +
                                                    "CNPJ: 62.545.579/0013-69\n"                   +
                                                    "IE:110.819.138.118  IM: 9.041.041-5\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("---------------------------------------------------------------------\n" +
                                                    "MM/DD/YYYY HH:MM:SS  CCF:133939 COO:227808\n"                            +
                                                    "---------------------------------------------------------------------\n" +
                                                    "CUPOM FISCAL\n"                                                          +
                                                    "---------------------------------------------------------------------\n" +
                                                    "001  2505        CAFÉ DO PONTO TRAD A    1un F1            8,15)\n"      +
                                                    "002  2505        CAFÉ DO PONTO TRAD A    1un F1            8,15)\n"      +
                                                    "003  2505        CAFÉ DO PONTO TRAD A    1un F1            8,15)\n"      +
                                                    "004  6129        AGU MIN NESTLE 510ML    1un F1            1,39)\n"      +
                                                    "005  6129        AGU MIN NESTLE 510ML    1un F1            1,39)\n"      +
                                                    "---------------------------------------------------------------------\n"));

            commandBuilder.AppendMultipleWidth(encoding.GetBytes("TOTAL  R$                  27,23\n"), 2);

            commandBuilder.Append(encoding.GetBytes("DINHEIROv                                                  29,00\n" +
                                                    "TROCO R$                                                    1,77\n" +
                                                    "Valor dos Tributos R$2,15 (7,90%)\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("ITEM(S) CINORADIS 5\n"           +
                                                    "OP.:15326  PDV:9  BR,BF:93466\n" +
                                                    "OBRIGADO PERA PREFERENCIA.\n"));

            commandBuilder.AppendMultipleWidth(encoding.GetBytes("VOLTE SEMPRE!\n" +
                                                                 "\n"), 2);

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("SAC 0800 724 2822\n"                                                     +
                                                    "---------------------------------------------------------------------\n" +
                                                    "MD5:fe028828a532a7dbaf4271155aa4e2db\n"                                  +
                                                    "Calypso_CA CA.20.c13 – Unisys Brasil\n"                                  +
                                                    "---------------------------------------------------------------------\n" +
                                                    "DARUMA AUTOMAÇÃO   MACH 2\n"                                             +
                                                    "ECF-IF VERSÃO:01,00,00 ECF:093\n"                                        +
                                                    "Lj:0204 OPR:ANGELA JORGE\n"                                              +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("DDDDDDDDDAEHFGBFCC\n"       +
                                                    "MM/DD/YYYY HH:MM:SS\n"      +
                                                    "FAB:DR0911BR000000275026\n" +
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

//          commandBuilder.AppendInternational(InternationalType.UK);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

//          commandBuilder.Append(encoding.GetBytes("[If loaded.. Logo1 goes here]\n"));
//
//          commandBuilder.AppendLogo(LogoSize.Normal, 1);

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("\nCOMERCIAL DE ALIMENTOS STAR LTDA.\n"), 2);

            commandBuilder.Append(encoding.GetBytes("Avenida Moyses Roysen, S/N  Vila Guilherme\n" +
                                                    "Cep: 02049-010 – Sao Paulo - SP\n"            +
                                                    "CNPJ: 62.545.579/0013-69\n"                   +
                                                    "IE:110.819.138.118  IM: 9.041.041-5\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("------------------------------------------\n" +
                                                    "MM/DD/YYYY HH:MM:SS  CCF:133939 COO:227808\n" +
                                                    "------------------------------------------\n" +
                                                    "CUPOM FISCAL\n"                               +
                                                    "------------------------------------------\n" +
                                                    "01 2505 CAFÉ DO PONTO TRAD A  1un F1 8,15)\n" +
                                                    "02 2505 CAFÉ DO PONTO TRAD A  1un F1 8,15)\n" +
                                                    "03 2505 CAFÉ DO PONTO TRAD A  1un F1 8,15)\n" +
                                                    "04 6129 AGU MIN NESTLE 510ML  1un F1 1,39)\n" +
                                                    "05 6129 AGU MIN NESTLE 510ML  1un F1 1,39)\n" +
                                                    "------------------------------------------\n" +
                                                    "TOTAL  R$                            27,23\n" +
                                                    "DINHEIROv                            29,00\n" +
                                                    "TROCO R$                              1,77\n" +
                                                    "Valor dos Tributos R$2,15 (7,90%)\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("ITEM(S) CINORADIS 5\n"           +
                                                    "OP.:15326  PDV:9  BR,BF:93466\n" +
                                                    "OBRIGADO PERA PREFERENCIA.\n"));

            commandBuilder.AppendMultipleWidth(encoding.GetBytes("VOLTE SEMPRE!\n" +
                                                                "\n"), 2);

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("SAC 0800 724 2822\n"                          +
                                                    "------------------------------------------\n" +
                                                    "MD5:  fe028828a532a7dbaf4271155aa4e2db\n"     +
                                                    "Calypso_CA CA.20.c13 – Unisys Brasil\n"       +
                                                    "------------------------------------------\n" +
                                                    "DARUMA AUTOMAÇÃO   MACH 2\n"                  +
                                                    "ECF-IF VERSÃO:01,00,00 ECF:093\n"             +
                                                    "Lj:0204 OPR:ANGELA JORGE\n"                   +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("DDDDDDDDDAEHFGBFCC\n"  +
                                                    "MM/DD/YYYY HH:MM:SS\n" +
                                                    "FAB:DR0911BR000000275026\n"));
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

//          commandBuilder.AppendInternational(InternationalType.UK);

            commandBuilder.AppendCharacterSpace(0);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

//          commandBuilder.Append(encoding.GetBytes("[If loaded.. Logo1 goes here]\n"));
//
//          commandBuilder.AppendLogo(LogoSize.Normal, 1);

            commandBuilder.AppendMultipleHeight(encoding.GetBytes("COMERCIAL DE ALIMENTOS STAR LTDA.\n"), 2);

            commandBuilder.Append(encoding.GetBytes("Avenida Moyses Roysen, S/N  Vila Guilherme\n" +
                                                    "Cep: 02049-010 – Sao Paulo – SP\n"            +
                                                    "CNPJ: 62.545.579/0013-69\n"                   +
                                                    "IE:110.819.138.118  IM: 9.041.041-5\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("------------------------------------------\n" +
                                                    "MM/DD/YYYY HH:MM:SS  CCF:133939 COO:227808\n" +
                                                    "------------------------------------------\n" +
                                                    "CUPOM FISCAL\n"                               +
                                                    "------------------------------------------\n" +
                                                    "001   2505    CAFÉ DO PONTO TRAD A\n"         +
                                                    "                            1un F1  8,15)\n"  +
                                                    "002   2505    CAFÉ DO PONTO TRAD A\n"         +
                                                    "                            1un F1  8,15)\n"  +
                                                    "003   2505    CAFÉ DO PONTO TRAD A\n"         +
                                                    "                            1un F1  8,15)\n"  +
                                                    "004   6129    AGU MIN NESTLE 510ML\n"         +
                                                    "                            1un F1  1,39)\n"  +
                                                    "005   6129    AGU MIN NESTLE 510ML\n"         +
                                                    "                            1un F1  1,39)\n"  +
                                                    "------------------------------------------\n"));

            commandBuilder.AppendMultipleWidth(encoding.GetBytes("TOTAL  R$      27,23\n"), 2);

            commandBuilder.Append(encoding.GetBytes("DINHEIROv                          29,00\n" +
                                                    "TROCO R$                            1,77\n" +
                                                    "Valor dos Tributos R$2,15 (7,90%)\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("ITEM(S) CINORADIS 5\n"           +
                                                    "OP.:15326  PDV:9  BR,BF:93466\n" +
                                                    "OBRIGADO PERA PREFERENCIA.\n"));

            commandBuilder.AppendMultipleWidth(encoding.GetBytes("VOLTE SEMPRE!\n" +
                                                                 "\n"), 2);

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("SAC 0800 724 2822\n"                          +
                                                    "------------------------------------------\n" +
                                                    "MD5:fe028828a532a7dbaf4271155aa4e2db\n"       +
                                                    "Calypso_CA CA.20.c13 – Unisys Brasil\n"       +
                                                    "------------------------------------------\n" +
                                                    "DARUMA AUTOMAÇÃO   MACH 2\n"                  +
                                                    "ECF-IF VERSÃO:01,00,00 ECF:093\n"             +
                                                    "Lj:0204 OPR:ANGELA JORGE\n"                   +
                                                    "\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("DDDDDDDDDAEHFGBFCC\n"       +
                                                    "MM/DD/YYYY HH:MM:SS\n"      +
                                                    "FAB:DR0911BR000000275026\n" +
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
            return "COMERCIAL DE ALIMENTOS\n"     +
                   "         STAR LTDA.\n"        +
                   "Avenida Moyses Roysen,\n"     +
                   "S/N Vila Guilherme\n"         +
                   "Cep: 02049-010 – Sao Paulo\n" +
                   "     – SP\n"                  +
                   "CNPJ: 62.545.579/0013-69\n"   +
                   "IE:110.819.138.118\n"         +
                   "IM: 9.041.041-5\n"            +
                   "--------------------------\n" +
                   "MM/DD/YYYY HH:MM:SS\n"        +
                   "CCF:133939 COO:227808\n"      +
                   "--------------------------\n" +
                   "CUPOM FISCAL\n"               +
                   "--------------------------\n" +
                   "01 CAFÉ DO PONTO TRAD A\n"    +
                   "              1un F1 8,15)\n" +
                   "02 CAFÉ DO PONTO TRAD A\n"    +
                   "              1un F1 8,15)\n" +
                   "03 CAFÉ DO PONTO TRAD A\n"    +
                   "              1un F1 8,15)\n" +
                   "04 AGU MIN NESTLE 510ML\n"    +
                   "              1un F1 1,39)\n" +
                   "05 AGU MIN NESTLE 510ML\n"    +
                   "              1un F1 1,39)\n" +
                   "--------------------------\n" +
                   "TOTAL  R$            27,23\n" +
                   "DINHEIROv            29,00\n" +
                   "\n"                           +
                   "TROCO R$              1,77\n" +
                   "Valor dos Tributos\n"         +
                   "R$2,15(7,90%)\n"              +
                   "ITEM(S) CINORADIS 5\n"        +
                   "OP.:15326  PDV:9\n"           +
                   "            BR,BF:93466\n"    +
                   "OBRIGADO PERA PREFERENCIA.\n" +
                   "VOLTE SEMPRE!\n"              +
                   "SAC 0800 724 2822\n"          +
                   "--------------------------\n" +
                   "MD5:\n"                       +
                   "fe028828a532a7dbaf4271155a\n" +
                   "a4e2db\n"                     +
                   "Calypso_CA CA.20.c13\n"       +
                   " – Unisys Brasil\n"           +
                   "--------------------------\n" +
                   "DARUMA AUTOMAÇÃO   MACH 2\n"  +
                   "ECF-IF VERSÃO:01,00,00\n"     +
                   "ECF:093\n"                    +
                   "Lj:0204 OPR:ANGELA JORGE\n"   +
                   "DDDDDDDDDAEHFGBFCC\n"         +
                   "MM/DD/YYYY HH:MM:SS\n"        +
                   "FAB:DR0911BR000000275026\n";
        }

        public string Create3inchRasterReceiptString()
        {
            return "         COMERCIAL DE ALIMENTOS\n"         +
                   "              STAR LTDA.\n"                +
                   "        Avenida Moyses Roysen,\n"          +
                   "          S/N Vila Guilherme\n"            +
                   "     Cep: 02049-010 – Sao Paulo – SP\n"    +
                   "        CNPJ: 62.545.579/0013-69\n"        +
                   "  IE:110.819.138.118    IM: 9.041.041-5\n" +
                   "---------------------------------------\n" +
                   "MM/DD/YYYY HH:MM:SS\n"                     +
                   "CCF:133939   COO:227808\n"                 +
                   "---------------------------------------\n" +
                   "CUPOM FISCAL\n"                            +
                   "---------------------------------------\n" +
                   "01  CAFÉ DO PONTO TRAD A  1un F1  8,15)\n" +
                   "02  CAFÉ DO PONTO TRAD A  1un F1  8,15)\n" +
                   "03  CAFÉ DO PONTO TRAD A  1un F1  8,15)\n" +
                   "04  AGU MIN NESTLE 510ML  1un F1  1,39)\n" +
                   "05  AGU MIN NESTLE 510ML  1un F1  1,39)\n" +
                   "---------------------------------------\n" +
                   "TOTAL  R$                         27,23\n" +
                   "DINHEIROv                         29,00\n" +
                   "\n"                                        +
                   "TROCO R$                           1,77\n" +
                   "Valor dos Tributos R$2,15(7,90%)\n"        +
                   "ITEM(S) CINORADIS 5\n"                     +
                   "OP.:15326  PDV:9  BR,BF:93466\n"           +
                   "OBRIGADO PERA PREFERENCIA.\n"              +
                   "VOLTE SEMPRE!    SAC 0800 724 2822\n"      +
                   "---------------------------------------\n" +
                   "MD5:  fe028828a532a7dbaf4271155aa4e2db\n"  +
                   "Calypso_CA CA.20.c13 – Unisys Brasil\n"    +
                   "---------------------------------------\n" +
                   "DARUMA AUTOMAÇÃO   MACH 2\n"               +
                   "ECF-IF VERSÃO:01,00,00 ECF:093\n"          +
                   "Lj:0204 OPR:ANGELA JORGE\n"                +
                   "DDDDDDDDDAEHFGBFCC\n"                      +
                   "MM/DD/YYYY HH:MM:SS\n"                     +
                   "FAB:DR0911BR000000275026\n";
        }

        public string Create4inchRasterReceiptString()
        {
            return "            COMERCIAL DE ALIMENTOS STAR LTDA.\n"             +
                   "         Avenida Moyses Roysen, S/N Vila Guilherme\n"        +
                   "              Cep: 02049-010 – Sao Paulo – SP\n"             +
                   "                  CNPJ: 62.545.579/0013-69\n"                +
                   "                    IE:110.819.138.118    IM: 9.041.041-5\n" +
                   "---------------------------------------------------------\n" +
                   "              MM/DD/YYYY HH:MM:SS CCF:133939   COO:227808\n" +
                   "---------------------------------------------------------\n" +
                   "CUPOM FISCAL\n"                                              +
                   "---------------------------------------------------------\n" +
                   "01   CAFÉ DO PONTO TRAD A    1un F1                 8,15)\n" +
                   "02   CAFÉ DO PONTO TRAD A    1un F1                 8,15)\n" +
                   "03   CAFÉ DO PONTO TRAD A    1un F1                 8,15)\n" +
                   "04   AGU MIN NESTLE 510ML    1un F1                 1,39)\n" +
                   "05   AGU MIN NESTLE 510ML    1un F1                 1,39)\n" +
                   "---------------------------------------------------------\n" +
                   "TOTAL  R$                                           27,23\n" +
                   "DINHEIROv                                           29,00\n" +
                   "\n"                                                          +
                   "TROCO R$                                             1,77\n" +
                   "Valor dos Tributos R$2,15(7,90%)\n"                          +
                   "ITEM(S) CINORADIS 5\n"                                       +
                   "OP.:15326  PDV:9  BR,BF:93466\n"                             +
                   "OBRIGADO PERA PREFERENCIA.\n"                                +
                   "                       VOLTE SEMPRE!    SAC 0800 724 2822\n" +
                   "---------------------------------------------------------\n" +
                   "                   MD5:  fe028828a532a7dbaf4271155aa4e2db\n" +
                   "                     Calypso_CA CA.20.c13 – Unisys Brasil\n" +
                   "---------------------------------------------------------\n" +
                   "DARUMA AUTOMAÇÃO   MACH 2\n"                                 +
                   "ECF-IF VERSÃO:01,00,00 ECF:093\n"                            +
                   "Lj:0204 OPR:ANGELA JORGE\n"                                  +
                   "DDDDDDDDDAEHFGBFCC\n"                                        +
                   "MM/DD/YYYY HH:MM:SS\n"                                       +
                   "FAB:DR0911BR000000275026\n";
        }

        public Stream CreateCouponImage()
        {
            Assembly assembly = typeof(PortugueseReceiptsComponent).GetTypeInfo().Assembly;

            return assembly.GetManifestResourceStream("XamarinSDK.Resources.PortugueseCouponImage.png");
        }

        public string CreateEscPos3inchRasterReceiptString()
        {
            return "     COMERCIAL DE ALIMENTOS\n"          +
                    "            STAR LTDA.\n"              +
                    "      Avenida Moyses Roysen,\n"        +
                    "        S/N Vila Guilherme\n"          +
                    "  Cep: 02049-010 – Sao Paulo – SP\n"   +
                    "      CNPJ: 62.545.579/0013-69\n"      +
                    "IE:110.819.138.118  IM: 9.041.041-5\n" +
                    "-----------------------------------\n" +
                    "MM/DD/YYYY HH:MM:SS\n"                 +
                    "CCF:133939   COO:227808\n"             +
                    "-----------------------------------\n" +
                    "CUPOM FISCAL\n"                        +
                    "-----------------------------------\n" +
                    "01  CAFÉ DO PONTO TRAD A\n"            +
                    "                      1un F1  8,15)\n" +
                    "02  CAFÉ DO PONTO TRAD A\n"            +
                    "                      1un F1  8,15)\n" +
                    "03  CAFÉ DO PONTO TRAD A\n"            +
                    "                      1un F1  8,15)\n" +
                    "04  AGU MIN NESTLE 510ML\n"            +
                    "                      1un F1  1,39)\n" +
                    "05  AGU MIN NESTLE 510ML\n"            +
                    "                      1un F1  1,39)\n" +
                    "-----------------------------------\n" +
                    "TOTAL  R$                     27,23\n" +
                    "DINHEIROv                     29,00\n" +
                    "\n"                                    +
                    "TROCO R$                       1,77\n" +
                    "Valor dos Tributos R$2,15(7,90%)\n"    +
                    "ITEM(S) CINORADIS 5\n"                 +
                    "OP.:15326  PDV:9  BR,BF:93466\n"       +
                    "OBRIGADO PERA PREFERENCIA.\n"          +
                    "VOLTE SEMPRE!     SAC 0800 724 2822\n" +
                    "-----------------------------------\n" +
                    "MD5:\n"                                +
                    "fe028828a532a7dbaf4271155aa4e2db\n"    +
                    "Calypso_CA CA.20.c13\n"                +
                    " – Unisys Brasil\n"                    +
                    "-----------------------------------\n" +
                    "DARUMA AUTOMAÇÃO   MACH 2\n"           +
                    "ECF-IF VERSÃO:01,00,00 ECF:093\n"      +
                    "Lj:0204 OPR:ANGELA JORGE\n"            +
                    "DDDDDDDDDAEHFGBFCC\n"                  +
                    "MM/DD/YYYY HH:MM:SS\n"                 +
                    "FAB:DR0911BR000000275026\n";
        }

        public string CreatePasteTextLabelString()
        {
            throw new NotImplementedException();
        }
    }
}
