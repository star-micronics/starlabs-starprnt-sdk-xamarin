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
    class RussianReceiptsComponent : ILocalizeReceiptsComponent
    {
        public string LanguageCode
        {
            get { return "Ru"; }
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
                encoding = Encoding.GetEncoding("Windows-1251");

                commandBuilder.AppendCodePage(CodePageType.CP1251);
            }

//          commandBuilder.AppendInternational(InternationalType.UK);

            commandBuilder.AppendCharacterSpace(0);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.AppendMultiple(encoding.GetBytes("Р Е Л А К С\n"), 2, 2);

            commandBuilder.Append(encoding.GetBytes("ООО “РЕЛАКС”\n"                                      +
                                                    "СПб., Малая Балканская, д. 38, лит. А\n" +
                                                    "тел. 307-07-12\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("РЕГ №322736     ИНН:123321\n" +
                                                    "01 Белякова И.А.КАССА: 0020 ОТД.01\n"));

            commandBuilder.AppendAlignment(encoding.GetBytes("ЧЕК НА ПРОДАЖУ  No 84373\n"), AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("--------------------------------\n"                  +
                                                    " 1. Яблоки Айдаред, кг    144.50\n"   +
                                                    " 2. Соус соевый Sen So     36.40\n"        +
                                                    " 3. Соус томатный Клас     19.90\n"  +
                                                    " 4. Ребра свиные в.к м     78.20\n"    +
                                                    " 5. Масло подсол раф д    114.00\n"   +
                                                    " 6. Блокнот 10х14см сп    164.00\n"      +
                                                    " 7. Морс Северная Ягод     99.90\n"  +
                                                    " 8. Активия Биойогурт      43.40\n"  +
                                                    " 9. Бублики Украинские     26.90\n" +
                                                    "10. Активия Биойогурт      43.40\n"  +
                                                    "11. Сахар-песок 1кг        58.40\n"      +
                                                    "12. Хлопья овсяные Ясн     38.40\n"  +
                                                    "13. Кинза 50г              39.90\n"            +
                                                    "14. Пемза “Сердечко” .Т    37.90\n"  +
                                                    "15. Приправа Santa Mar     47.90\n"          +
                                                    "16. Томаты слива Выбор    162.00\n"  +
                                                    "17. Бонд Стрит Ред Сел     56.90\n"   +
                                                    "--------------------------------\n"                  +
                                                    "--------------------------------\n"                  +
                                                    "ДИСКОНТНАЯ КАРТА\n"                   +
                                                    "                No:2440012489765\n"                  +
                                                    "--------------------------------\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Right);

            commandBuilder.Append(encoding.GetBytes("ИТОГО К ОПЛАТЕ = 1212.00\n" +
                                                    "НАЛИЧНЫЕ = 1212.00\n"           +
                                                    "ВАША СКИДКА : 0.41\n"         +
                                                    "\n"));

            commandBuilder.AppendAlignment(encoding.GetBytes("ЦЕНЫ УКАЗАНЫ С УЧЕТОМ СКИДКИ\n" +
                                                             "\n"), AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("08-02-2015 09:49  0254.0130604\n" +
                                                    "00083213 #060127\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("СПАСИБО ЗА ПОКУПКУ !\n"                 +
                                                    "МЫ  ОТКРЫТЫ ЕЖЕДНЕВНО С 9 ДО 23\n" +
                                                    "СОХРАНЯЙТЕ, ПОЖАЛУЙСТА , ЧЕК\n"  +
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
                encoding = Encoding.GetEncoding("Windows-1251");

                commandBuilder.AppendCodePage(CodePageType.CP1251);
            }

//          commandBuilder.AppendInternational(InternationalType.UK);

            commandBuilder.AppendCharacterSpace(0);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.AppendMultiple(encoding.GetBytes("Р Е Л А К С\n"), 2, 2);

            commandBuilder.Append(encoding.GetBytes("ООО “РЕЛАКС”\n"                                      +
                                                    "СПб., Малая Балканская, д. 38, лит. А\n" +
                                                    "тел. 307-07-12\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("РЕГ №322736 ИНН : 123321\n" +
                                                    "01  Белякова И.А.  КАССА: 0020 ОТД.01\n"));

            commandBuilder.AppendAlignment(encoding.GetBytes("ЧЕК НА ПРОДАЖУ  No 84373\n"), AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("------------------------------------------------\n"                  +
                                                    "1.     Яблоки Айдаред, кг                 144.50\n"   +
                                                    "2.     Соус соевый Sen So                  36.40\n"        +
                                                    "3.     Соус томатный Клас                  19.90\n"  +
                                                    "4.     Ребра свиные в.к м                  78.20\n"    +
                                                    "5.     Масло подсол раф д                 114.00\n"   +
                                                    "6.     Блокнот 10х14см сп                 164.00\n"      +
                                                    "7.     Морс Северная Ягод                  99.90\n"  +
                                                    "8.     Активия Биойогурт                   43.40\n"  +
                                                    "9.     Бублики Украинские                  26.90\n" +
                                                    "10.    Активия Биойогурт                   43.40\n"  +
                                                    "11.    Сахар-песок 1кг                     58.40\n"      +
                                                    "12.    Хлопья овсяные Ясн                  38.40\n"  +
                                                    "13.    Кинза 50г                           39.90\n"            +
                                                    "14.    Пемза “Сердечко” .Т                 37.90\n"  +
                                                    "15.    Приправа Santa Mar                  47.90\n"          +
                                                    "16.    Томаты слива Выбор                 162.00\n"  +
                                                    "17.    Бонд Стрит Ред Сел                  56.90\n"   +
                                                    "------------------------------------------------\n"                  +
                                                    "------------------------------------------------\n"                  +
                                                    "ДИСКОНТНАЯ КАРТА  No: 2440012489765\n"                +
                                                    "------------------------------------------------\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Right);

            commandBuilder.Append(encoding.GetBytes("ИТОГО  К  ОПЛАТЕ     = 1212.00\n" +
                                                    "НАЛИЧНЫЕ             = 1212.00\n"     +
                                                    "ВАША СКИДКА : 0.41\n"               +
                                                    "\n"));

            commandBuilder.AppendAlignment(encoding.GetBytes("ЦЕНЫ УКАЗАНЫ С УЧЕТОМ СКИДКИ\n" +
                                                             "\n"), AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("08-02-2015 09:49  0254.0130604\n" +
                                                    "00083213 #060127\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("СПАСИБО ЗА ПОКУПКУ !\n"                 +
                                                    "МЫ  ОТКРЫТЫ ЕЖЕДНЕВНО С 9 ДО 23\n" +
                                                    "СОХРАНЯЙТЕ, ПОЖАЛУЙСТА , ЧЕК\n"  +
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
                encoding = Encoding.GetEncoding("Windows-1251");

                commandBuilder.AppendCodePage(CodePageType.CP1251);
            }

//          commandBuilder.AppendInternational(InternationalType.UK);

            commandBuilder.AppendCharacterSpace(0);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.AppendMultiple(encoding.GetBytes("Р Е Л А К С\n"), 2, 2);

            commandBuilder.Append(encoding.GetBytes("ООО “РЕЛАКС”\n"                                      +
                                                    "СПб., Малая Балканская, д. 38, лит. А\n" +
                                                    "тел. 307-07-12\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("РЕГ №322736 ИНН : 123321\n" +
                                                    "01  Белякова И.А.  КАССА: 0020 ОТД.01\n"));

            commandBuilder.AppendAlignment(encoding.GetBytes("ЧЕК НА ПРОДАЖУ  No 84373\n"), AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("---------------------------------------------------------------------\n"                  +
                                                    "1.     Яблоки Айдаред, кг                                      144.50\n"   +
                                                    "2.     Соус соевый Sen So                                       36.40\n"        +
                                                    "3.     Соус томатный Клас                                       19.90\n"  +
                                                    "4.     Ребра свиные в.к м                                       78.20\n"    +
                                                    "5.     Масло подсол раф д                                      114.00\n"   +
                                                    "6.     Блокнот 10х14см сп                                      164.00\n"      +
                                                    "7.     Морс Северная Ягод                                       99.90\n"  +
                                                    "8.     Активия Биойогурт                                        43.40\n"  +
                                                    "9.     Бублики Украинские                                       26.90\n" +
                                                    "10.    Активия Биойогурт                                        43.40\n"  +
                                                    "11.    Сахар-песок 1кг                                          58.40\n"      +
                                                    "12.    Хлопья овсяные Ясн                                       38.40\n"  +
                                                    "13.    Кинза 50г                                                39.90\n"            +
                                                    "14.    Пемза “Сердечко” .Т                                      37.90\n"  +
                                                    "15.    Приправа Santa Mar                                       47.90\n"          +
                                                    "16.    Томаты слива Выбор                                      162.00\n"  +
                                                    "17.    Бонд Стрит Ред Сел                                       56.90\n"   +
                                                    "---------------------------------------------------------------------\n"                  +
                                                    "---------------------------------------------------------------------\n"                  +
                                                    "ДИСКОНТНАЯ КАРТА  No: 2440012489765\n"                                     +
                                                    "---------------------------------------------------------------------\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Right);

            commandBuilder.Append(encoding.GetBytes("ИТОГО  К  ОПЛАТЕ           = 1212.00\n" +
                                                    "НАЛИЧНЫЕ                   = 1212.00\n"     +
                                                    "ВАША СКИДКА : 0.41\n"                     +
                                                    "\n"));

            commandBuilder.AppendAlignment(encoding.GetBytes("ЦЕНЫ УКАЗАНЫ С УЧЕТОМ СКИДКИ\n" +
                                                             "\n"), AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("08-02-2015 09:49  0254.0130604\n" +
                                                    "00083213 #060127\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("СПАСИБО ЗА ПОКУПКУ !\n"                 +
                                                    "МЫ  ОТКРЫТЫ ЕЖЕДНЕВНО С 9 ДО 23\n" +
                                                    "СОХРАНЯЙТЕ, ПОЖАЛУЙСТА , ЧЕК\n"  +
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
                encoding = Encoding.GetEncoding("Windows-1251");

                commandBuilder.AppendCodePage(CodePageType.CP1251);
            }

//          commandBuilder.AppendInternational(InternationalType.UK);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.AppendMultiple(encoding.GetBytes("Р  Е  Л  А  К  С\n"), 2, 2);

            commandBuilder.Append(encoding.GetBytes("ООО “РЕЛАКС”\n"                                      +
                                                    "СПб., Малая Балканская, д. 38, лит. А\n" +
                                                    "тел. 307-07-12\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("РЕГ №322736 ИНН : 123321\n" +
                                                    "01  Белякова И.А.  КАССА: 0020 ОТД.01\n"));

            commandBuilder.AppendAlignment(encoding.GetBytes("ЧЕК НА ПРОДАЖУ  No 84373\n"), AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("------------------------------------------\n"                  +
                                                    "1.     Яблоки Айдаред, кг           144.50\n"   +
                                                    "2.     Соус соевый Sen So            36.40\n"        +
                                                    "3.     Соус томатный Клас            19.90\n"  +
                                                    "4.     Ребра свиные в.к м            78.20\n"    +
                                                    "5.     Масло подсол раф д           114.00\n"   +
                                                    "6.     Блокнот 10х14см сп           164.00\n"      +
                                                    "7.     Морс Северная Ягод            99.90\n"  +
                                                    "8.     Активия Биойогурт             43.40\n"  +
                                                    "9.     Бублики Украинские            26.90\n" +
                                                    "10.    Активия Биойогурт             43.40\n"  +
                                                    "11.    Сахар-песок 1кг               58.40\n"      +
                                                    "12.    Хлопья овсяные Ясн            38.40\n"  +
                                                    "13.    Кинза 50г                     39.90\n"            +
                                                    "14.    Пемза “Сердечко” .Т           37.90\n"  +
                                                    "15.    Приправа Santa Mar            47.90\n"          +
                                                    "16.    Томаты слива Выбор           162.00\n"  +
                                                    "17.    Бонд Стрит Ред Сел            56.90\n"   +
                                                    "------------------------------------------\n"                  +
                                                    "------------------------------------------\n"                  +
                                                    "ДИСКОНТНАЯ КАРТА  No: 2440012489765\n"          +
                                                    "------------------------------------------\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Right);

            commandBuilder.Append(encoding.GetBytes("ИТОГО  К  ОПЛАТЕ  = 1212.00\n" +
                                                    "НАЛИЧНЫЕ          = 1212.00\n"     +
                                                    "ВАША СКИДКА : 0.41\n"            +
                                                    "\n"));

            commandBuilder.AppendAlignment(encoding.GetBytes("ЦЕНЫ УКАЗАНЫ С УЧЕТОМ СКИДКИ\n" +
                                                             "\n"), AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("08-02-2015 09:49  0254.0130604\n" +
                                                    "00083213 #060127\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("СПАСИБО ЗА ПОКУПКУ !\n"                 +
                                                    "МЫ  ОТКРЫТЫ ЕЖЕДНЕВНО С 9 ДО 23\n" +
                                                    "СОХРАНЯЙТЕ, ПОЖАЛУЙСТА , ЧЕК\n"));
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
                encoding = Encoding.GetEncoding("Windows-1251");

                commandBuilder.AppendCodePage(CodePageType.CP1251);
            }

//          commandBuilder.AppendInternational(InternationalType.UK);

            commandBuilder.AppendCharacterSpace(0);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.AppendMultiple(encoding.GetBytes("Р Е Л А К С\n"), 2, 2);

            commandBuilder.Append(encoding.GetBytes("ООО “РЕЛАКС”\n"                                      +
                                                    "СПб., Малая Балканская, д. 38, лит. А\n" +
                                                    "тел. 307-07-12\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Left);

            commandBuilder.Append(encoding.GetBytes("РЕГ №322736 ИНН : 123321\n" +
                                                    "01  Белякова И.А.  КАССА: 0020 ОТД.01\n"));

            commandBuilder.AppendAlignment(encoding.GetBytes("ЧЕК НА ПРОДАЖУ  No 84373\n"), AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("------------------------------------------\n"                  +
                                                    "1.     Яблоки Айдаред, кг           144.50\n"   +
                                                    "2.     Соус соевый Sen So            36.40\n"        +
                                                    "3.     Соус томатный Клас            19.90\n"  +
                                                    "4.     Ребра свиные в.к м            78.20\n"    +
                                                    "5.     Масло подсол раф д           114.00\n"   +
                                                    "6.     Блокнот 10х14см сп           164.00\n"      +
                                                    "7.     Морс Северная Ягод            99.90\n"  +
                                                    "8.     Активия Биойогурт             43.40\n"  +
                                                    "9.     Бублики Украинские            26.90\n" +
                                                    "10.    Активия Биойогурт             43.40\n"  +
                                                    "11.    Сахар-песок 1кг               58.40\n"      +
                                                    "12.    Хлопья овсяные Ясн            38.40\n"  +
                                                    "13.    Кинза 50г                     39.90\n"            +
                                                    "14.    Пемза “Сердечко” .Т           37.90\n"  +
                                                    "15.    Приправа Santa Mar            47.90\n"          +
                                                    "16.    Томаты слива Выбор           162.00\n"  +
                                                    "17.    Бонд Стрит Ред Сел            56.90\n"   +
                                                    "------------------------------------------\n"                  +
                                                    "------------------------------------------\n"                  +
                                                    "ДИСКОНТНАЯ КАРТА  No: 2440012489765\n"          +
                                                    "------------------------------------------\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Right);

            commandBuilder.Append(encoding.GetBytes("ИТОГО  К  ОПЛАТЕ     = 1212.00\n" +
                                                    "НАЛИЧНЫЕ             = 1212.00\n"     +
                                                    "ВАША СКИДКА : 0.41\n"               +
                                                    "\n"));

            commandBuilder.AppendAlignment(encoding.GetBytes("ЦЕНЫ УКАЗАНЫ С УЧЕТОМ СКИДКИ\n" +
                                                             "\n"), AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("08-02-2015 09:49  0254.0130604\n" +
                                                    "00083213 #060127\n"));

            commandBuilder.AppendAlignment(AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("СПАСИБО ЗА ПОКУПКУ !\n"                 +
                                                    "МЫ  ОТКРЫТЫ ЕЖЕДНЕВНО С 9 ДО 23\n" +
                                                    "СОХРАНЯЙТЕ, ПОЖАЛУЙСТА , ЧЕК\n"  +
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
            return "          Р Е Л А К С\n"                          +
                   "          ООО “РЕЛАКС”\n"                    +
                   "СПб., Малая Балканская, д.\n"        +
                   "38, лит. А\n"                                       +
                   "\n"                                                     +
                   "тел. 307-07-12\n"                                    +
                   "РЕГ №322736     ИНН:123321\n"                    +
                   "01 Белякова И.А. КАССА:0020\n"           +
                   "ОТД.01\n"                                            +
                   "ЧЕК НА ПРОДАЖУ  No 84373\n"                 +
                   "----------------------------\n"                         +
                   " 1.Яблоки Айдаред, кг 144.50\n"          +
                   " 2.Соус соевый Sen So  36.40\n"               +
                   " 3.Соус томатный Клас  19.90\n"         +
                   " 4.Ребра свиные в.к м  78.20\n"           +
                   " 5.Масло подсол раф д 114.00\n"          +
                   " 6.Блокнот 10х14см сп 164.00\n"             +
                   " 7.Морс Северная Ягод  99.90\n"         +
                   " 8.Активия Биойогурт   43.40\n"         +
                   " 9.Бублики Украинские  26.90\n"        +
                   "10.Активия Биойогурт   43.40\n"         +
                   "11.Сахар-песок 1кг     58.40\n"             +
                   "12.Хлопья овсяные Ясн  38.40\n"         +
                   "13.Кинза 50г           39.90\n"                   +
                   "14.Пемза “Сердечко” .Т 37.90\n"         +
                   "15.Приправа Santa Mar  47.90\n"                 +
                   "16.Томаты слива Выбор 162.00\n"         +
                   "17.Бонд Стрит Ред Сел  56.90\n"          +
                   "----------------------------\n"                         +
                   "----------------------------\n"                         +
                   "ДИСКОНТНАЯ КАРТА\n"                      +
                   "            No:2440012489765\n"                         +
                   "----------------------------\n"                         +
                   "ИТОГО К ОПЛАТЕ = 1212.00\n"                 +
                   "НАЛИЧНЫЕ = 1212.00\n"                           +
                   "ВАША СКИДКА : 0.41\n"                         +
                   "ЦЕНЫ УКАЗАНЫ С УЧЕТОМ СКИДКИ\n" +
                   "\n"                                                     +
                   "08-02-2015 09:49\n"                                     +
                   "0254.013060400083213 #060127\n"                         +
                   "СПАСИБО ЗА ПОКУПКУ !\n"                 +
                   "\n"                                                     +
                   "МЫ  ОТКРЫТЫ ЕЖЕДНЕВНО С 9 ДО\n"    +
                   "23 СОХРАНЯЙТЕ, ПОЖАЛУЙСТА ,\n"      +
                   "ЧЕК\n";
        }

        public string Create3inchRasterReceiptString()
        {
            return "      Р Е Л А К С   ООО “РЕЛАКС”\n"             +
                   " СПб., Малая Балканская, д. 38, лит. А\n" +
                   "\n"                                                              +
                   "тел. 307-07-12\n"                                             +
                   "РЕГ №322736     ИНН:123321\n"                             +
                   "01 Белякова И.А. КАССА: 0020 ОТД.01\n"         +
                   "ЧЕК НА ПРОДАЖУ  No 84373\n"                          +
                   "--------------------------------------\n"                        +
                   " 1. Яблоки Айдаред, кг          144.50\n"         +
                   " 2. Соус соевый Sen So           36.40\n"              +
                   " 3. Соус томатный Клас           19.90\n"        +
                   " 4. Ребра свиные в.к м           78.20\n"          +
                   " 5. Масло подсол раф д          114.00\n"         +
                   " 6. Блокнот 10х14см сп          164.00\n"            +
                   " 7. Морс Северная Ягод           99.90\n"        +
                   " 8. Активия Биойогурт            43.40\n"        +
                   " 9. Бублики Украинские           26.90\n"       +
                   "10. Активия Биойогурт            43.40\n"        +
                   "11. Сахар-песок 1кг              58.40\n"            +
                   "12. Хлопья овсяные Ясн           38.40\n"        +
                   "13. Кинза 50г                    39.90\n"                  +
                   "14. Пемза “Сердечко” .Т          37.90\n"        +
                   "15. Приправа Santa Mar           47.90\n"                +
                   "16. Томаты слива Выбор          162.00\n"        +
                   "17. Бонд Стрит Ред Сел           56.90\n"         +
                   "--------------------------------------\n"                        +
                   "--------------------------------------\n"                        +
                   "ДИСКОНТНАЯ КАРТА      No:2440012489765\n"         +
                   "--------------------------------------\n"                        +
                   "ИТОГО К ОПЛАТЕ = 1212.00\n"                          +
                   "НАЛИЧНЫЕ = 1212.00\n"                                    +
                   "ВАША СКИДКА : 0.41\n"                                  +
                   "ЦЕНЫ УКАЗАНЫ С УЧЕТОМ СКИДКИ\n"          +
                   "\n"                                                              +
                   "08-02-2015 09:49  0254.0130604\n"                                +
                   "00083213 #060127\n"                                              +
                   "               СПАСИБО ЗА ПОКУПКУ !\n"           +
                   "\n"                                                              +
                   "    МЫ  ОТКРЫТЫ ЕЖЕДНЕВНО С 9 ДО 23\n"      +
                   "        СОХРАНЯЙТЕ, ПОЖАЛУЙСТА , ЧЕК\n";
        }

        public string Create4inchRasterReceiptString()
        {
            return "               Р Е Л А К С   ООО “РЕЛАКС”\n"                   +
                   "                СПб., Малая Балканская, д. 38, лит. А\n" +
                   "\n"                                                                             +
                   "тел. 307-07-12\n"                                                            +
                   "РЕГ №322736     ИНН:123321\n"                                            +
                   "01 Белякова И.А. КАССА: 0020 ОТД.01\n"                        +
                   "ЧЕК НА ПРОДАЖУ  No 84373\n"                                         +
                   "-----------------------------------------------------\n"                        +
                   " 1.      Яблоки Айдаред, кг                    144.50\n"         +
                   " 2.      Соус соевый Sen So                     36.40\n"              +
                   " 3.      Соус томатный Клас                     19.90\n"        +
                   " 4.      Ребра свиные в.к м                     78.20\n"          +
                   " 5.      Масло подсол раф д                    114.00\n"         +
                   " 6.      Блокнот 10х14см сп                    164.00\n"            +
                   " 7.      Морс Северная Ягод                     99.90\n"        +
                   " 8.      Активия Биойогурт                      43.40\n"        +
                   " 9.      Бублики Украинские                     26.90\n"       +
                   "10.      Активия Биойогурт                      43.40\n"        +
                   "11.      Сахар-песок 1кг                        58.40\n"            +
                   "12.      Хлопья овсяные Ясн                     38.40\n"        +
                   "13.      Кинза 50г                              39.90\n"                  +
                   "14.      Пемза “Сердечко” .Т                    37.90\n"        +
                   "15.      Приправа Santa Mar                     47.90\n"                +
                   "16.      Томаты слива Выбор                    162.00\n"        +
                   "17.      Бонд Стрит Ред Сел                     56.90\n"         +
                   "-----------------------------------------------------\n"                        +
                   "-----------------------------------------------------\n"                        +
                   "ДИСКОНТНАЯ КАРТА                     No:2440012489765\n"         +
                   "-----------------------------------------------------\n"                        +
                   "ИТОГО К ОПЛАТЕ = 1212.00\n"                                         +
                   "НАЛИЧНЫЕ = 1212.00\n"                                                   +
                   "ВАША СКИДКА : 0.41\n"                                                 +
                   "ЦЕНЫ УКАЗАНЫ С УЧЕТОМ СКИДКИ\n"                         +
                   "\n"                                                                             +
                   "08-02-2015 09:49  0254.0130604\n"                                               +
                   "00083213 #060127\n"                                                             +
                   "                                 СПАСИБО ЗА ПОКУПКУ !\n"        +
                   "\n"                                                                             +
                   "                      МЫ  ОТКРЫТЫ ЕЖЕДНЕВНО С 9 ДО 23\n"   +
                   "                         СОХРАНЯЙТЕ, ПОЖАЛУЙСТА , ЧЕК\n";
        }

        public Stream CreateCouponImage()
        {
            Assembly assembly = typeof(RussianReceiptsComponent).GetTypeInfo().Assembly;

            return assembly.GetManifestResourceStream("XamarinSDK.Resources.RussianCouponImage.png");
        }

        public string CreateEscPos3inchRasterReceiptString()
        {
            return "   Р Е Л А К С    ООО “РЕЛАКС”\n"          +
                   "    СПб., Малая Балканская, д.\n"        +
                   "           38, лит. А\n"                                +
                   "\n"                                                         +
                   "тел. 307-07-12\n"                                        +
                   "РЕГ №322736     ИНН:123321\n"                        +
                   "01 Белякова И.А. КАССА: 0020 ОТД.01\n"    +
                   "ЧЕК НА ПРОДАЖУ  No 84373\n"                     +
                   "-----------------------------------\n"                      +
                   " 1. Яблоки Айдаред, кг       144.50\n"       +
                   " 2. Соус соевый Sen So        36.40\n"            +
                   " 3. Соус томатный Клас        19.90\n"      +
                   " 4. Ребра свиные в.к м        78.20\n"        +
                   " 5. Масло подсол раф д       114.00\n"       +
                   " 6. Блокнот 10х14см сп       164.00\n"          +
                   " 7. Морс Северная Ягод        99.90\n"      +
                   " 8. Активия Биойогурт         43.40\n"      +
                   " 9. Бублики Украинские        26.90\n"     +
                   "10. Активия Биойогурт         43.40\n"      +
                   "11. Сахар-песок 1кг           58.40\n"          +
                   "12. Хлопья овсяные Ясн        38.40\n"      +
                   "13. Кинза 50г                 39.90\n"                +
                   "14. Пемза “Сердечко” .Т       37.90\n"      +
                   "15. Приправа Santa Mar        47.90\n"              +
                   "16. Томаты слива Выбор       162.00\n"      +
                   "17. Бонд Стрит Ред Сел        56.90\n"       +
                   "-----------------------------------\n"                      +
                   "-----------------------------------\n"                      +
                   "ДИСКОНТНАЯ КАРТА   No:2440012489765\n"       +
                   "-----------------------------------\n"                      +
                   "ИТОГО К ОПЛАТЕ = 1212.00\n"                     +
                   "НАЛИЧНЫЕ = 1212.00\n"                               +
                   "ВАША СКИДКА : 0.41\n"                             +
                   "ЦЕНЫ УКАЗАНЫ С УЧЕТОМ СКИДКИ\n"     +
                   "\n"                                                         +
                   "08-02-2015 09:49  0254.0130604\n"                           +
                   "00083213 #060127\n"                                         +
                   "               СПАСИБО ЗА ПОКУПКУ !\n"      +
                   "\n"                                                         +
                   "    МЫ  ОТКРЫТЫ ЕЖЕДНЕВНО С 9 ДО 23\n" +
                   "       СОХРАНЯЙТЕ, ПОЖАЛУЙСТА , ЧЕК\n";
        }

        public string CreatePasteTextLabelString()
        {
            throw new NotImplementedException();
        }
    }
}
