using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using StarIoWrapper;

namespace XamarinSDK.Functions
{
    class ApiFunctions
    {
        public static byte[] CreateGenericData(StarIoExtEmulation emulation)
        {
//          Encoding encoding = Encoding.ASCII;
            Encoding encoding = Encoding.UTF8;

            byte[] data = encoding.GetBytes("Hello World.");

            ICommandBuilder commandBuilder = Extension.CreateCommandBuilder(emulation);

            commandBuilder.BeginDocument();

            commandBuilder.Append(data);

            commandBuilder.Append((byte) '\n');

            commandBuilder.AppendCutPaper(CutPaperAction.PartialCutWithFeed);

            commandBuilder.EndDocument();

            return commandBuilder.Commands;
        }

        public static byte[] CreateFontStyleData(StarIoExtEmulation emulation)
        {
//          Encoding encoding = Encoding.ASCII;
            Encoding encoding = Encoding.UTF8;

            byte[] data = encoding.GetBytes("Hello World.\n");

            ICommandBuilder commandBuilder = Extension.CreateCommandBuilder(emulation);

            commandBuilder.BeginDocument();

            commandBuilder.Append(data);
            commandBuilder.AppendFontStyle(FontStyleType.B);
            commandBuilder.Append(data);
            commandBuilder.AppendFontStyle(FontStyleType.A);
            commandBuilder.Append(data);
            commandBuilder.AppendFontStyle(FontStyleType.B);
            commandBuilder.Append(data);

            commandBuilder.AppendCutPaper(CutPaperAction.PartialCutWithFeed);

            commandBuilder.EndDocument();

            return commandBuilder.Commands;
        }

        public static byte[] CreateInitializationData(StarIoExtEmulation emulation)
        {
//          Encoding encoding = Encoding.ASCII;
            Encoding encoding = Encoding.UTF8;

            byte[] data = encoding.GetBytes("Hello World.\n");

            ICommandBuilder commandBuilder = Extension.CreateCommandBuilder(emulation);

            commandBuilder.BeginDocument();

            commandBuilder.Append(data);
            commandBuilder.AppendMultiple(2, 2);
            commandBuilder.Append(data);
            commandBuilder.AppendFontStyle(FontStyleType.B);
            commandBuilder.Append(data);
            commandBuilder.AppendInitialization(InitializationType.Command);
            commandBuilder.Append(data);

            commandBuilder.AppendCutPaper(CutPaperAction.PartialCutWithFeed);

            commandBuilder.EndDocument();

            return commandBuilder.Commands;
        }

        public static byte[] CreateCodePageData(StarIoExtEmulation emulation)
        {
//          Encoding encoding = Encoding.ASCII;
            Encoding encoding = Encoding.UTF8;

            byte[] data2 = {0x20, 0x21, 0x22, 0x23, 0x24, 0x25, 0x26, 0x27, 0x28, 0x29, 0x2a, 0x2b, 0x2c, 0x2d, 0x2e, 0x2f, 0x0a};
            byte[] data3 = {0x30, 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37, 0x38, 0x39, 0x3a, 0x3b, 0x3c, 0x3d, 0x3e, 0x3f, 0x0a};
            byte[] data4 = {0x40, 0x41, 0x42, 0x43, 0x44, 0x45, 0x46, 0x47, 0x48, 0x49, 0x4a, 0x4b, 0x4c, 0x4d, 0x4e, 0x4f, 0x0a};
            byte[] data5 = {0x50, 0x51, 0x52, 0x53, 0x54, 0x55, 0x56, 0x57, 0x58, 0x59, 0x5a, 0x5b, 0x5c, 0x5d, 0x5e, 0x5f, 0x0a};
            byte[] data6 = {0x60, 0x61, 0x62, 0x63, 0x64, 0x65, 0x66, 0x67, 0x68, 0x69, 0x6a, 0x6b, 0x6c, 0x6d, 0x6e, 0x6f, 0x0a};
            byte[] data7 = {0x70, 0x71, 0x72, 0x73, 0x74, 0x75, 0x76, 0x77, 0x78, 0x79, 0x7a, 0x7b, 0x7c, 0x7d, 0x7e, 0x7f, 0x0a};
            byte[] data8 = {0x80, 0x81, 0x82, 0x83, 0x84, 0x85, 0x86, 0x87, 0x88, 0x89, 0x8a, 0x8b, 0x8c, 0x8d, 0x8e, 0x8f, 0x0a};
            byte[] data9 = {0x90, 0x91, 0x92, 0x93, 0x94, 0x95, 0x96, 0x97, 0x98, 0x99, 0x9a, 0x9b, 0x9c, 0x9d, 0x9e, 0x9f, 0x0a};
            byte[] dataA = {0xa0, 0xa1, 0xa2, 0xa3, 0xa4, 0xa5, 0xa6, 0xa7, 0xa8, 0xa9, 0xaa, 0xab, 0xac, 0xad, 0xae, 0xaf, 0x0a};
            byte[] dataB = {0xb0, 0xb1, 0xb2, 0xb3, 0xb4, 0xb5, 0xb6, 0xb7, 0xb8, 0xb9, 0xba, 0xbb, 0xbc, 0xbd, 0xbe, 0xbf, 0x0a};
            byte[] dataC = {0xc0, 0xc1, 0xc2, 0xc3, 0xc4, 0xc5, 0xc6, 0xc7, 0xc8, 0xc9, 0xca, 0xcb, 0xcc, 0xcd, 0xce, 0xcf, 0x0a};
            byte[] dataD = {0xd0, 0xd1, 0xd2, 0xd3, 0xd4, 0xd5, 0xd6, 0xd7, 0xd8, 0xd9, 0xda, 0xdb, 0xdc, 0xdd, 0xde, 0xdf, 0x0a};
            byte[] dataE = {0xe0, 0xe1, 0xe2, 0xe3, 0xe4, 0xe5, 0xe6, 0xe7, 0xe8, 0xe9, 0xea, 0xeb, 0xec, 0xed, 0xee, 0xef, 0x0a};
            byte[] dataF = {0xf0, 0xf1, 0xf2, 0xf3, 0xf4, 0xf5, 0xf6, 0xf7, 0xf8, 0xf9, 0xfa, 0xfb, 0xfc, 0xfd, 0xfe, 0xff, 0x0a};

            ICommandBuilder commandBuilder = Extension.CreateCommandBuilder(emulation);

            commandBuilder.BeginDocument();

            commandBuilder.AppendCodePage(CodePageType.CP998);  commandBuilder.Append(encoding.GetBytes("*CP998*\n"));

            commandBuilder.Append(data2);
            commandBuilder.Append(data3);
            commandBuilder.Append(data4);
            commandBuilder.Append(data5);
            commandBuilder.Append(data6);
            commandBuilder.Append(data7);
            commandBuilder.Append(data8);
            commandBuilder.Append(data9);
            commandBuilder.Append(dataA);
            commandBuilder.Append(dataB);
            commandBuilder.Append(dataC);
            commandBuilder.Append(dataD);
            commandBuilder.Append(dataE);
            commandBuilder.Append(dataF);

            commandBuilder.Append(encoding.GetBytes("\n"));

//          commandBuilder.AppendCodePage(CodePageType.CP437);  commandBuilder.Append(encoding.GetBytes("*CP437*\n"));
//          commandBuilder.AppendCodePage(CodePageType.CP737);  commandBuilder.Append(encoding.GetBytes("*CP737*\n"));
//          commandBuilder.AppendCodePage(CodePageType.CP772);  commandBuilder.Append(encoding.GetBytes("*CP772*\n"));
//          commandBuilder.AppendCodePage(CodePageType.CP774);  commandBuilder.Append(encoding.GetBytes("*CP774*\n"));
//          commandBuilder.AppendCodePage(CodePageType.CP851);  commandBuilder.Append(encoding.GetBytes("*CP851*\n"));
//          commandBuilder.AppendCodePage(CodePageType.CP852);  commandBuilder.Append(encoding.GetBytes("*CP852*\n"));
//          commandBuilder.AppendCodePage(CodePageType.CP855);  commandBuilder.Append(encoding.GetBytes("*CP855*\n"));
//          commandBuilder.AppendCodePage(CodePageType.CP857);  commandBuilder.Append(encoding.GetBytes("*CP857*\n"));
//          commandBuilder.AppendCodePage(CodePageType.CP858);  commandBuilder.Append(encoding.GetBytes("*CP858*\n"));
//          commandBuilder.AppendCodePage(CodePageType.CP860);  commandBuilder.Append(encoding.GetBytes("*CP860*\n"));
//          commandBuilder.AppendCodePage(CodePageType.CP861);  commandBuilder.Append(encoding.GetBytes("*CP861*\n"));
//          commandBuilder.AppendCodePage(CodePageType.CP862);  commandBuilder.Append(encoding.GetBytes("*CP862*\n"));
//          commandBuilder.AppendCodePage(CodePageType.CP863);  commandBuilder.Append(encoding.GetBytes("*CP863*\n"));
//          commandBuilder.AppendCodePage(CodePageType.CP864);  commandBuilder.Append(encoding.GetBytes("*CP864*\n"));
//          commandBuilder.AppendCodePage(CodePageType.CP865);  commandBuilder.Append(encoding.GetBytes("*CP865*\n"));
//          commandBuilder.AppendCodePage(CodePageType.CP866);  commandBuilder.Append(encoding.GetBytes("*CP866*\n"));
//          commandBuilder.AppendCodePage(CodePageType.CP869);  commandBuilder.Append(encoding.GetBytes("*CP869*\n"));
//          commandBuilder.AppendCodePage(CodePageType.CP874);  commandBuilder.Append(encoding.GetBytes("*CP874*\n"));
//          commandBuilder.AppendCodePage(CodePageType.CP928);  commandBuilder.Append(encoding.GetBytes("*CP928*\n"));
            commandBuilder.AppendCodePage(CodePageType.CP932);  commandBuilder.Append(encoding.GetBytes("*CP932*\n"));
//          commandBuilder.AppendCodePage(CodePageType.CP998);  commandBuilder.Append(encoding.GetBytes("*CP998*\n"));
//          commandBuilder.AppendCodePage(CodePageType.CP999);  commandBuilder.Append(encoding.GetBytes("*CP999*\n"));
//          commandBuilder.AppendCodePage(CodePageType.CP1001); commandBuilder.Append(encoding.GetBytes("*CP1001*\n"));
//          commandBuilder.AppendCodePage(CodePageType.CP1250); commandBuilder.Append(encoding.GetBytes("*CP1250*\n"));
//          commandBuilder.AppendCodePage(CodePageType.CP1251); commandBuilder.Append(encoding.GetBytes("*CP1251*\n"));
//          commandBuilder.AppendCodePage(CodePageType.CP1252); commandBuilder.Append(encoding.GetBytes("*CP1252*\n"));
//          commandBuilder.AppendCodePage(CodePageType.CP2001); commandBuilder.Append(encoding.GetBytes("*CP2001*\n"));
//          commandBuilder.AppendCodePage(CodePageType.CP3001); commandBuilder.Append(encoding.GetBytes("*CP3001*\n"));
//          commandBuilder.AppendCodePage(CodePageType.CP3002); commandBuilder.Append(encoding.GetBytes("*CP3002*\n"));
//          commandBuilder.AppendCodePage(CodePageType.CP3011); commandBuilder.Append(encoding.GetBytes("*CP3011*\n"));
//          commandBuilder.AppendCodePage(CodePageType.CP3012); commandBuilder.Append(encoding.GetBytes("*CP3012*\n"));
//          commandBuilder.AppendCodePage(CodePageType.CP3021); commandBuilder.Append(encoding.GetBytes("*CP3021*\n"));
//          commandBuilder.AppendCodePage(CodePageType.CP3041); commandBuilder.Append(encoding.GetBytes("*CP3041*\n"));
//          commandBuilder.AppendCodePage(CodePageType.CP3840); commandBuilder.Append(encoding.GetBytes("*CP3840*\n"));
//          commandBuilder.AppendCodePage(CodePageType.CP3841); commandBuilder.Append(encoding.GetBytes("*CP3841*\n"));
//          commandBuilder.AppendCodePage(CodePageType.CP3843); commandBuilder.Append(encoding.GetBytes("*CP3843*\n"));
//          commandBuilder.AppendCodePage(CodePageType.CP3844); commandBuilder.Append(encoding.GetBytes("*CP3844*\n"));
//          commandBuilder.AppendCodePage(CodePageType.CP3845); commandBuilder.Append(encoding.GetBytes("*CP3845*\n"));
//          commandBuilder.AppendCodePage(CodePageType.CP3846); commandBuilder.Append(encoding.GetBytes("*CP3846*\n"));
//          commandBuilder.AppendCodePage(CodePageType.CP3847); commandBuilder.Append(encoding.GetBytes("*CP3847*\n"));
//          commandBuilder.AppendCodePage(CodePageType.CP3848); commandBuilder.Append(encoding.GetBytes("*CP3848*\n"));
//          commandBuilder.AppendCodePage(CodePageType.Blank);  commandBuilder.Append(encoding.GetBytes("*Blank*\n"));
//          commandBuilder.AppendCodePage(CodePageType.CP932);  commandBuilder.Append(encoding.GetBytes("*CP932*\n"));

            commandBuilder.Append(data2);
            commandBuilder.Append(data3);
            commandBuilder.Append(data4);
            commandBuilder.Append(data5);
            commandBuilder.Append(data6);
            commandBuilder.Append(data7);
            commandBuilder.Append(data8);
            commandBuilder.Append(data9);
            commandBuilder.Append(dataA);
            commandBuilder.Append(dataB);
            commandBuilder.Append(dataC);
            commandBuilder.Append(dataD);
            commandBuilder.Append(dataE);
            commandBuilder.Append(dataF);

            commandBuilder.AppendCutPaper(CutPaperAction.PartialCutWithFeed);

            commandBuilder.EndDocument();

            return commandBuilder.Commands;
        }

        public static byte[] CreateInternationalData(StarIoExtEmulation emulation)
        {
//          Encoding encoding = Encoding.ASCII;
            Encoding encoding = Encoding.UTF8;

            byte[] data = {0x23, 0x24, 0x40, 0x58, 0x5a, 0x5b, 0x5c, 0x5d, 0x5e, 0x60, 0x7b, 0x7c, 0x7d, 0x7e, 0x0a};

            ICommandBuilder commandBuilder = Extension.CreateCommandBuilder(emulation);

            commandBuilder.BeginDocument();

            commandBuilder.Append(encoding.GetBytes("*USA*\n"));
            commandBuilder.AppendInternational(InternationalType.USA);
            commandBuilder.Append(data);

            commandBuilder.Append(encoding.GetBytes("*France*\n"));
            commandBuilder.AppendInternational(InternationalType.France);
            commandBuilder.Append(data);

            commandBuilder.Append(encoding.GetBytes("*Germany*\n"));
            commandBuilder.AppendInternational(InternationalType.Germany);
            commandBuilder.Append(data);

            commandBuilder.Append(encoding.GetBytes("*UK*\n"));
            commandBuilder.AppendInternational(InternationalType.UK);
            commandBuilder.Append(data);

            commandBuilder.Append(encoding.GetBytes("*Denmark*\n"));
            commandBuilder.AppendInternational(InternationalType.Denmark);
            commandBuilder.Append(data);

            commandBuilder.Append(encoding.GetBytes("*Sweden*\n"));
            commandBuilder.AppendInternational(InternationalType.Sweden);
            commandBuilder.Append(data);

            commandBuilder.Append(encoding.GetBytes("*Italy*\n"));
            commandBuilder.AppendInternational(InternationalType.Italy);
            commandBuilder.Append(data);

            commandBuilder.Append(encoding.GetBytes("*Spain*\n"));
            commandBuilder.AppendInternational(InternationalType.Spain);
            commandBuilder.Append(data);

            commandBuilder.Append(encoding.GetBytes("*Japan*\n"));
            commandBuilder.AppendInternational(InternationalType.Japan);
            commandBuilder.Append(data);

            commandBuilder.Append(encoding.GetBytes("*Norway*\n"));
            commandBuilder.AppendInternational(InternationalType.Norway);
            commandBuilder.Append(data);

            commandBuilder.Append(encoding.GetBytes("*Denmark2*\n"));
            commandBuilder.AppendInternational(InternationalType.Denmark2);
            commandBuilder.Append(data);

            commandBuilder.Append(encoding.GetBytes("*Spain2*\n"));
            commandBuilder.AppendInternational(InternationalType.Spain2);
            commandBuilder.Append(data);

            commandBuilder.Append(encoding.GetBytes("*LatinAmerica*\n"));
            commandBuilder.AppendInternational(InternationalType.LatinAmerica);
            commandBuilder.Append(data);

            commandBuilder.Append(encoding.GetBytes("*Korea*\n"));
            commandBuilder.AppendInternational(InternationalType.Korea);
            commandBuilder.Append(data);

            commandBuilder.Append(encoding.GetBytes("*Ireland*\n"));
            commandBuilder.AppendInternational(InternationalType.Ireland);
            commandBuilder.Append(data);

            commandBuilder.Append(encoding.GetBytes("*Legal*\n"));
            commandBuilder.AppendInternational(InternationalType.Legal);
            commandBuilder.Append(data);

            commandBuilder.AppendCutPaper(CutPaperAction.PartialCutWithFeed);

            commandBuilder.EndDocument();

            return commandBuilder.Commands;
        }

        public static byte[] CreateFeedData(StarIoExtEmulation emulation)
        {
//          Encoding encoding = Encoding.ASCII;
            Encoding encoding = Encoding.UTF8;

            byte[] data       = encoding.GetBytes("Hello World.");
            byte[] dataWithLf = encoding.GetBytes("Hello World.\n");

            ICommandBuilder commandBuilder = Extension.CreateCommandBuilder(emulation);

            commandBuilder.BeginDocument();

            commandBuilder.Append(data);
            commandBuilder.AppendLineFeed();

            commandBuilder.AppendLineFeed(data);

            commandBuilder.Append(data);
            commandBuilder.AppendLineFeed(2);

            commandBuilder.AppendLineFeed(data, 2);

            commandBuilder.Append(data);
            commandBuilder.AppendUnitFeed(64);

            commandBuilder.AppendUnitFeed(data, 64);

            commandBuilder.Append(dataWithLf);

            commandBuilder.AppendCutPaper(CutPaperAction.PartialCutWithFeed);

            commandBuilder.EndDocument();

            return commandBuilder.Commands;
        }

        public static byte[] CreateCharacterSpaceData(StarIoExtEmulation emulation)
        {
//          Encoding encoding = Encoding.ASCII;
            Encoding encoding = Encoding.UTF8;

            byte[] data = encoding.GetBytes("Hello World.");

            ICommandBuilder commandBuilder = Extension.CreateCommandBuilder(emulation);

            commandBuilder.BeginDocument();

            commandBuilder.AppendCharacterSpace(0);
            commandBuilder.AppendLineFeed(data);
            commandBuilder.AppendCharacterSpace(1);
            commandBuilder.AppendLineFeed(data);
            commandBuilder.AppendCharacterSpace(2);
            commandBuilder.AppendLineFeed(data);
            commandBuilder.AppendCharacterSpace(3);
            commandBuilder.AppendLineFeed(data);
            commandBuilder.AppendCharacterSpace(4);
            commandBuilder.AppendLineFeed(data);
            commandBuilder.AppendCharacterSpace(5);
            commandBuilder.AppendLineFeed(data);
            commandBuilder.AppendCharacterSpace(6);
            commandBuilder.AppendLineFeed(data);
            commandBuilder.AppendCharacterSpace(7);
            commandBuilder.AppendLineFeed(data);

            commandBuilder.AppendCutPaper(CutPaperAction.PartialCutWithFeed);

            commandBuilder.EndDocument();

            return commandBuilder.Commands;
        }

        public static byte[] CreateLineSpaceData(StarIoExtEmulation emulation)
        {
//          Encoding encoding = Encoding.ASCII;
            Encoding encoding = Encoding.UTF8;

            byte[] data = encoding.GetBytes("Hello World.");

            ICommandBuilder commandBuilder = Extension.CreateCommandBuilder(emulation);

            commandBuilder.BeginDocument();

            commandBuilder.AppendLineSpace(32);
            commandBuilder.AppendLineFeed(data);
            commandBuilder.AppendLineFeed(data);
            commandBuilder.AppendLineFeed(data);
            commandBuilder.AppendLineSpace(24);
            commandBuilder.AppendLineFeed(data);
            commandBuilder.AppendLineFeed(data);
            commandBuilder.AppendLineFeed(data);
            commandBuilder.AppendLineSpace(32);
            commandBuilder.AppendLineFeed(data);
            commandBuilder.AppendLineFeed(data);
            commandBuilder.AppendLineFeed(data);
            commandBuilder.AppendLineSpace(24);
            commandBuilder.AppendLineFeed(data);
            commandBuilder.AppendLineFeed(data);
            commandBuilder.AppendLineFeed(data);

            commandBuilder.AppendCutPaper(CutPaperAction.PartialCutWithFeed);

            commandBuilder.EndDocument();

            return commandBuilder.Commands;
        }

        public static byte[] CreateEmphasisData(StarIoExtEmulation emulation)
        {
//          Encoding encoding = Encoding.ASCII;
            Encoding encoding = Encoding.UTF8;

            byte[] data      = encoding.GetBytes("Hello World.\n");
            byte[] dataHalf0 = encoding.GetBytes("Hello ");
            byte[] dataHalf1 = encoding.GetBytes      ("World.\n");

            ICommandBuilder commandBuilder = Extension.CreateCommandBuilder(emulation);

            commandBuilder.BeginDocument();

            commandBuilder.Append(data);

            commandBuilder.AppendEmphasis(true);
            commandBuilder.Append(data);
            commandBuilder.AppendEmphasis(false);
            commandBuilder.Append(data);

            commandBuilder.AppendEmphasis(data);
            commandBuilder.Append        (data);

            commandBuilder.AppendEmphasis(dataHalf0);
            commandBuilder.Append        (dataHalf1);

            commandBuilder.AppendCutPaper(CutPaperAction.PartialCutWithFeed);

            commandBuilder.EndDocument();

            return commandBuilder.Commands;
        }

        public static byte[] CreateInvertData(StarIoExtEmulation emulation)
        {
//          Encoding encoding = Encoding.ASCII;
            Encoding encoding = Encoding.UTF8;

            byte[] data      = encoding.GetBytes("Hello World.\n");
            byte[] dataHalf0 = encoding.GetBytes("Hello ");
            byte[] dataHalf1 = encoding.GetBytes      ("World.\n");

            ICommandBuilder commandBuilder = Extension.CreateCommandBuilder(emulation);

            commandBuilder.BeginDocument();

            commandBuilder.Append(data);

            commandBuilder.AppendInvert(true);
            commandBuilder.Append(data);
            commandBuilder.AppendInvert(false);
            commandBuilder.Append(data);

            commandBuilder.AppendInvert(data);
            commandBuilder.Append(data);

            commandBuilder.AppendInvert(dataHalf0);
            commandBuilder.Append      (dataHalf1);

            commandBuilder.AppendCutPaper(CutPaperAction.PartialCutWithFeed);

            commandBuilder.EndDocument();

            return commandBuilder.Commands;
        }

        public static byte[] CreateUnderLineData(StarIoExtEmulation emulation)
        {
//          Encoding encoding = Encoding.ASCII;
            Encoding encoding = Encoding.UTF8;

            byte[] data      = encoding.GetBytes("Hello World.\n");
            byte[] dataHalf0 = encoding.GetBytes("Hello ");
            byte[] dataHalf1 = encoding.GetBytes      ("World.\n");

            ICommandBuilder commandBuilder = Extension.CreateCommandBuilder(emulation);

            commandBuilder.BeginDocument();

            commandBuilder.Append(data);

            commandBuilder.AppendUnderLine(true);
            commandBuilder.Append(data);
            commandBuilder.AppendUnderLine(false);
            commandBuilder.Append(data);

            commandBuilder.AppendUnderLine(data);
            commandBuilder.Append         (data);

            commandBuilder.AppendUnderLine(dataHalf0);
            commandBuilder.Append         (dataHalf1);

            commandBuilder.AppendCutPaper(CutPaperAction.PartialCutWithFeed);

            commandBuilder.EndDocument();

            return commandBuilder.Commands;
        }

        public static byte[] CreateMultipleData(StarIoExtEmulation emulation)
        {
//          Encoding encoding = Encoding.ASCII;
            Encoding encoding = Encoding.UTF8;

            byte[] data      = encoding.GetBytes("Hello World.\n");
            byte[] dataHalf0 = encoding.GetBytes("Hello ");
            byte[] dataHalf1 = encoding.GetBytes      ("World.\n");

            ICommandBuilder commandBuilder = Extension.CreateCommandBuilder(emulation);

            commandBuilder.BeginDocument();

            commandBuilder.Append(data);

            commandBuilder.AppendMultiple(2, 2);
            commandBuilder.Append(data);
            commandBuilder.AppendMultiple(1, 1);
            commandBuilder.Append(data);

            commandBuilder.AppendMultiple(data, 2, 2);
            commandBuilder.Append        (data);

            commandBuilder.AppendMultiple(dataHalf0, 2, 2);
            commandBuilder.Append        (dataHalf1);

            commandBuilder.AppendMultipleHeight(2);
            commandBuilder.Append(data);
            commandBuilder.AppendMultipleHeight(1);
            commandBuilder.Append(data);

            commandBuilder.AppendMultipleHeight(dataHalf0, 2);
            commandBuilder.Append              (dataHalf1);

            commandBuilder.AppendMultipleWidth(2);
            commandBuilder.Append(data);
            commandBuilder.AppendMultipleWidth(1);
            commandBuilder.Append(data);

            commandBuilder.AppendMultipleWidth(dataHalf0, 2);
            commandBuilder.Append(dataHalf1);

            commandBuilder.AppendCutPaper(CutPaperAction.PartialCutWithFeed);

            commandBuilder.EndDocument();

            return commandBuilder.Commands;
        }

        public static byte[] CreateAbsolutePositionData(StarIoExtEmulation emulation)
        {
//          Encoding encoding = Encoding.ASCII;
            Encoding encoding = Encoding.UTF8;

            byte[] data = encoding.GetBytes("Hello World.\n");

            ICommandBuilder commandBuilder = Extension.CreateCommandBuilder(emulation);

            commandBuilder.BeginDocument();

            commandBuilder.Append(data);

            commandBuilder.AppendAbsolutePosition(40);
            commandBuilder.Append(data);
            commandBuilder.Append(data);

            commandBuilder.AppendAbsolutePosition(data, 40);
            commandBuilder.Append                (data);

            commandBuilder.AppendCutPaper(CutPaperAction.PartialCutWithFeed);

            commandBuilder.EndDocument();

            return commandBuilder.Commands;
        }

        public static byte[] CreateAlignmentData(StarIoExtEmulation emulation)
        {
//          Encoding encoding = Encoding.ASCII;
            Encoding encoding = Encoding.UTF8;

            byte[] data = encoding.GetBytes("Hello World.\n");

            ICommandBuilder commandBuilder = Extension.CreateCommandBuilder(emulation);

            commandBuilder.BeginDocument();

            commandBuilder.Append(data);

            commandBuilder.AppendAlignment(AlignmentPosition.Center);
            commandBuilder.Append(data);
            commandBuilder.AppendAlignment(AlignmentPosition.Right);
            commandBuilder.Append(data);
            commandBuilder.AppendAlignment(AlignmentPosition.Left);
            commandBuilder.Append(data);

            commandBuilder.AppendAlignment(data, AlignmentPosition.Center);
            commandBuilder.AppendAlignment(data, AlignmentPosition.Right);
            commandBuilder.Append         (data);

            commandBuilder.AppendCutPaper(CutPaperAction.PartialCutWithFeed);

            commandBuilder.EndDocument();

            return commandBuilder.Commands;
        }

        public static byte[] CreateLogoData(StarIoExtEmulation emulation)
        {
//          Encoding encoding = Encoding.ASCII;
            Encoding encoding = Encoding.UTF8;

            ICommandBuilder commandBuilder = Extension.CreateCommandBuilder(emulation);

            commandBuilder.BeginDocument();

            commandBuilder.Append(encoding.GetBytes("*Normal*\n"));
            commandBuilder.AppendLogo(LogoSize.Normal,                  1);

            commandBuilder.Append(encoding.GetBytes("\n*Double Width*\n"));
            commandBuilder.AppendLogo(LogoSize.DoubleWidth,             1);

            commandBuilder.Append(encoding.GetBytes("\n*Double Height*\n"));
            commandBuilder.AppendLogo(LogoSize.DoubleHeight,            1);

            commandBuilder.Append(encoding.GetBytes("\n*Double Width and Double Height*\n"));
            commandBuilder.AppendLogo(LogoSize.DoubleWidthDoubleHeight, 1);

            commandBuilder.AppendCutPaper(CutPaperAction.PartialCutWithFeed);

            commandBuilder.EndDocument();

            return commandBuilder.Commands;
        }

        public static byte[] CreateCutPaperData(StarIoExtEmulation emulation)
        {
//          Encoding encoding = Encoding.ASCII;
            Encoding encoding = Encoding.UTF8;

            byte[] data = encoding.GetBytes("Hello World.\n");

            ICommandBuilder commandBuilder = Extension.CreateCommandBuilder(emulation);

            commandBuilder.BeginDocument();

            commandBuilder.Append(data);
            commandBuilder.Append(data);
            commandBuilder.Append(data);
            commandBuilder.Append(data);
            commandBuilder.Append(data);
            commandBuilder.Append(data);
            commandBuilder.Append(data);
            commandBuilder.Append(data);
            commandBuilder.Append(data);
            commandBuilder.Append(data);

            commandBuilder.AppendCutPaper(CutPaperAction.FullCut);

            commandBuilder.Append(data);
            commandBuilder.Append(data);
            commandBuilder.Append(data);
            commandBuilder.Append(data);
            commandBuilder.Append(data);
            commandBuilder.Append(data);
            commandBuilder.Append(data);
            commandBuilder.Append(data);
            commandBuilder.Append(data);
            commandBuilder.Append(data);

            commandBuilder.AppendCutPaper(CutPaperAction.PartialCut);

            commandBuilder.Append(data);
            commandBuilder.Append(data);
            commandBuilder.Append(data);
            commandBuilder.Append(data);
            commandBuilder.Append(data);
            commandBuilder.Append(data);
            commandBuilder.Append(data);
            commandBuilder.Append(data);
            commandBuilder.Append(data);
            commandBuilder.Append(data);

            commandBuilder.AppendCutPaper(CutPaperAction.FullCutWithFeed);

            commandBuilder.Append(data);
            commandBuilder.Append(data);
            commandBuilder.Append(data);
            commandBuilder.Append(data);
            commandBuilder.Append(data);
            commandBuilder.Append(data);
            commandBuilder.Append(data);
            commandBuilder.Append(data);
            commandBuilder.Append(data);
            commandBuilder.Append(data);

            commandBuilder.AppendCutPaper(CutPaperAction.PartialCutWithFeed);

            commandBuilder.EndDocument();

            return commandBuilder.Commands;
        }

        public static byte[] CreatePeripheralData(StarIoExtEmulation emulation)
        {
            ICommandBuilder commandBuilder = Extension.CreateCommandBuilder(emulation);

            commandBuilder.BeginDocument();

            commandBuilder.AppendPeripheral(PeripheralChannel.No1);
            commandBuilder.AppendPeripheral(PeripheralChannel.No2);
            commandBuilder.AppendPeripheral(PeripheralChannel.No1, 2000);
            commandBuilder.AppendPeripheral(PeripheralChannel.No2, 2000);

            commandBuilder.EndDocument();

            return commandBuilder.Commands;
        }

        public static byte[] CreateSoundData(StarIoExtEmulation emulation)
        {
            ICommandBuilder commandBuilder = Extension.CreateCommandBuilder(emulation);

            commandBuilder.BeginDocument();

            commandBuilder.AppendSound(SoundChannel.No1);
            commandBuilder.AppendSound(SoundChannel.No2);
            commandBuilder.AppendSound(SoundChannel.No1, 3);
            commandBuilder.AppendSound(SoundChannel.No2, 3);

            commandBuilder.EndDocument();

            return commandBuilder.Commands;
        }

        public static byte[] CreateBitmapData(StarIoExtEmulation emulation, int width)
        {
//          Encoding encoding = Encoding.ASCII;
            Encoding encoding = Encoding.UTF8;

            Assembly assembly = typeof(ApiFunctions).GetTypeInfo().Assembly;

            Stream sphereStream   = assembly.GetManifestResourceStream("XamarinSDK.Resources.SphereImage.png");
            Stream starLogoStream = assembly.GetManifestResourceStream("XamarinSDK.Resources.StarLogoImage.png");

            ICommandBuilder commandBuilder = Extension.CreateCommandBuilder(emulation);

            commandBuilder.BeginDocument();

            commandBuilder.Append(encoding.GetBytes("*diffusion:true*\n"));
            commandBuilder.AppendBitmap(sphereStream, true);
            commandBuilder.Append(encoding.GetBytes("\n*diffusion:false*\n"));
            commandBuilder.AppendBitmap(sphereStream, false);

            commandBuilder.Append(encoding.GetBytes("\n*Normal*\n"));
            commandBuilder.AppendBitmap(starLogoStream, true);

            commandBuilder.Append(encoding.GetBytes("\n*width:Full, bothScale:true*\n"));
            commandBuilder.AppendBitmap(starLogoStream, true, width, true);
            commandBuilder.Append(encoding.GetBytes("\n*width:Full, bothScale:false*\n"));
            commandBuilder.AppendBitmap(starLogoStream, true, width, false);

            commandBuilder.Append(encoding.GetBytes("\n*Right90*\n"));
            commandBuilder.AppendBitmap(starLogoStream, true, BitmapConverterRotation.Right90);
//          commandBuilder.Append(encoding.GetBytes("\n*Rotate180*\n"));
//          commandBuilder.AppendBitmap(starLogoStream, true, BitmapConverterRotation.Rotate180);
//          commandBuilder.Append(encoding.GetBytes("\n*Left90*\n"));
//          commandBuilder.AppendBitmap(starLogoStream, true, BitmapConverterRotationLeft90);

            commandBuilder.Append(encoding.GetBytes("\n*Normal,    AbsolutePosition:40*\n"));
            commandBuilder.AppendBitmapWithAbsolutePosition(starLogoStream, true, 40);
//          commandBuilder.Append(encoding.GetBytes("\n*Right90,   AbsolutePosition:40*\n"));
//          commandBuilder.AppendBitmapWithAbsolutePosition(starLogoStream, true, BitmapConverterRotation.Right90  , 40);
//          commandBuilder.Append(encoding.GetBytes("\n*Rotate180, AbsolutePosition:40*\n"));
//          commandBuilder.AppendBitmapWithAbsolutePosition(starLogoStream, true, BitmapConverterRotation.Rotate180, 40);
//          commandBuilder.Append(encoding.GetBytes("\n*Left90,    AbsolutePosition:40*\n"));
//          commandBuilder.AppendBitmapWithAbsolutePosition(starLogoStream, true, BitmapConverterRotation.Left90   , 40);

            commandBuilder.Append(encoding.GetBytes("\n*Normal,    Alignment:Center*\n"));
            commandBuilder.AppendBitmapWithAlignment(starLogoStream, true, AlignmentPosition.Center);
//          commandBuilder.Append(encoding.GetBytes("\n*Right90,   Alignment:Center*\n"));
//          commandBuilder.AppendBitmapWithAlignment(starLogoStream, true, BitmapConverterRotation.Right90  , AlignmentPosition.Center);
//          commandBuilder.Append(encoding.GetBytes("\n*Rotate180, Alignment:Center*\n"));
//          commandBuilder.AppendBitmapWithAlignment(starLogoStream, true, BitmapConverterRotation.Rotate180, AlignmentPosition.Center);
//          commandBuilder.Append(encoding.GetBytes("\n*Left90,    Alignment:Center*\n"));
//          commandBuilder.AppendBitmapWithAlignment(starLogoStream, true, BitmapConverterRotation.Left90   , AlignmentPosition.Center);

            commandBuilder.Append(encoding.GetBytes("\n*Normal,    Alignment:Right*\n"));
            commandBuilder.AppendBitmapWithAlignment(starLogoStream, true, AlignmentPosition.Right);
//          commandBuilder.Append(encoding.GetBytes("\n*Right90,   Alignment:Right*\n"));
//          commandBuilder.AppendBitmapWithAlignment(starLogoStream, true, BitmapConverterRotation.Right90  , AlignmentPosition.Right);
//          commandBuilder.Append(encoding.GetBytes("\n*Rotate180, Alignment:Right*\n"));
//          commandBuilder.AppendBitmapWithAlignment(starLogoStream, true, BitmapConverterRotation.Rotate180, AlignmentPosition.Right);
//          commandBuilder.Append(encoding.GetBytes("\n*Left90,    Alignment:Right*\n"));
//          commandBuilder.AppendBitmapWithAlignment(starLogoStream, true, BitmapConverterRotation.Left90   , AlignmentPosition.Right);

            commandBuilder.AppendCutPaper(CutPaperAction.PartialCutWithFeed);

            commandBuilder.EndDocument();

            return commandBuilder.Commands;
        }

        public static byte[] CreateBarcodeData(StarIoExtEmulation emulation)
        {
//          Encoding encoding = Encoding.ASCII;
            Encoding encoding = Encoding.UTF8;

            byte[] dataUpcE    = encoding.GetBytes("01234500006");
            byte[] dataUpcA    = encoding.GetBytes("01234567890");
            byte[] dataJan8    = encoding.GetBytes("0123456");
            byte[] dataJan13   = encoding.GetBytes("012345678901");
            byte[] dataCode39  = encoding.GetBytes("0123456789");
            byte[] dataItf     = encoding.GetBytes("0123456789");
            byte[] dataCode128 = encoding.GetBytes("{B0123456789");
            byte[] dataCode93  = encoding.GetBytes("0123456789");
            byte[] dataNw7     = encoding.GetBytes("A0123456789B");

            ICommandBuilder commandBuilder = Extension.CreateCommandBuilder(emulation);

            commandBuilder.BeginDocument();

            commandBuilder.Append(encoding.GetBytes("*UPCE*\n"));
            commandBuilder.AppendBarcode(dataUpcE,    BarcodeSymbology.UPCE,    BarcodeWidth.Mode1, 40, true);
            commandBuilder.AppendUnitFeed(32);
            commandBuilder.Append(encoding.GetBytes("\n*UPCA*\n"));
            commandBuilder.AppendBarcode(dataUpcA,    BarcodeSymbology.UPCA,    BarcodeWidth.Mode1, 40, true);
            commandBuilder.AppendUnitFeed(32);
            commandBuilder.Append(encoding.GetBytes("\n*JAN8*\n"));
            commandBuilder.AppendBarcode(dataJan8,    BarcodeSymbology.JAN8,    BarcodeWidth.Mode1, 40, true);
            commandBuilder.AppendUnitFeed(32);
            commandBuilder.Append(encoding.GetBytes("\n*JAN13*\n"));
            commandBuilder.AppendBarcode(dataJan13,   BarcodeSymbology.JAN13,   BarcodeWidth.Mode1, 40, true);
            commandBuilder.AppendUnitFeed(32);
            commandBuilder.Append(encoding.GetBytes("\n*Code39*\n"));
            commandBuilder.AppendBarcode(dataCode39,  BarcodeSymbology.Code39,  BarcodeWidth.Mode1, 40, true);
            commandBuilder.AppendUnitFeed(32);
            commandBuilder.Append(encoding.GetBytes("\n*ITF*\n"));
            commandBuilder.AppendBarcode(dataItf,     BarcodeSymbology.ITF,     BarcodeWidth.Mode1, 40, true);
            commandBuilder.AppendUnitFeed(32);
            commandBuilder.Append(encoding.GetBytes("\n*Code128*\n"));
            commandBuilder.AppendBarcode(dataCode128, BarcodeSymbology.Code128, BarcodeWidth.Mode1, 40, true);
            commandBuilder.AppendUnitFeed(32);
            commandBuilder.Append(encoding.GetBytes("\n*Code93*\n"));
            commandBuilder.AppendBarcode(dataCode93,  BarcodeSymbology.Code93,  BarcodeWidth.Mode1, 40, true);
            commandBuilder.AppendUnitFeed(32);
            commandBuilder.Append(encoding.GetBytes("\n*NW7*\n"));
            commandBuilder.AppendBarcode(dataNw7,     BarcodeSymbology.NW7,     BarcodeWidth.Mode1, 40, true);
            commandBuilder.AppendUnitFeed(32);

            commandBuilder.Append(encoding.GetBytes("*HRI:false*\n"));
            commandBuilder.AppendBarcode(dataUpcE, BarcodeSymbology.UPCE, BarcodeWidth.Mode1, 40, false);
            commandBuilder.AppendUnitFeed(32);
            commandBuilder.Append(encoding.GetBytes("*Mode:1*\n"));
            commandBuilder.AppendBarcode(dataUpcE, BarcodeSymbology.UPCE, BarcodeWidth.Mode1, 40, true);
            commandBuilder.AppendUnitFeed(32);
            commandBuilder.Append(encoding.GetBytes("*Mode:2*\n"));
            commandBuilder.AppendBarcode(dataUpcE, BarcodeSymbology.UPCE, BarcodeWidth.Mode2, 40, true);
            commandBuilder.AppendUnitFeed(32);
            commandBuilder.Append(encoding.GetBytes("*Mode:3*\n"));
            commandBuilder.AppendBarcode(dataUpcE, BarcodeSymbology.UPCE, BarcodeWidth.Mode3, 40, true);
            commandBuilder.AppendUnitFeed(32);

            commandBuilder.Append(encoding.GetBytes("\n*AbsolutePosition:40*\n"));
            commandBuilder.AppendBarcodeWithAbsolutePosition(dataUpcE, BarcodeSymbology.UPCE, BarcodeWidth.Mode1, 40, true, 40);
            commandBuilder.AppendUnitFeed(32);

            commandBuilder.Append(encoding.GetBytes("\n*Alignment:Center*\n"));
            commandBuilder.AppendBarcodeWithAlignment(dataUpcE, BarcodeSymbology.UPCE, BarcodeWidth.Mode1, 40, true, AlignmentPosition.Center);
            commandBuilder.AppendUnitFeed(32);
            commandBuilder.Append(encoding.GetBytes("\n*Alignment:Right*\n"));
            commandBuilder.AppendBarcodeWithAlignment(dataUpcE, BarcodeSymbology.UPCE, BarcodeWidth.Mode1, 40, true, AlignmentPosition.Right);
            commandBuilder.AppendUnitFeed(32);

            commandBuilder.AppendCutPaper(CutPaperAction.PartialCutWithFeed);

            commandBuilder.EndDocument();

            return commandBuilder.Commands;
        }

        public static byte[] CreatePdf417Data(StarIoExtEmulation emulation)
        {
//          Encoding encoding = Encoding.ASCII;
            Encoding encoding = Encoding.UTF8;

            byte[] data = encoding.GetBytes("Hello World.");

            ICommandBuilder commandBuilder = Extension.CreateCommandBuilder(emulation);

            commandBuilder.BeginDocument();

            commandBuilder.Append(encoding.GetBytes("\n*Module:2*\n"));
            commandBuilder.AppendPdf417(data, 0, 1, Pdf417Level.ECC0, 2, 2);
            commandBuilder.AppendUnitFeed(32);
            commandBuilder.Append(encoding.GetBytes("\n*Module:4*\n"));
            commandBuilder.AppendPdf417(data, 0, 1, Pdf417Level.ECC0, 4, 2);
            commandBuilder.AppendUnitFeed(32);

            commandBuilder.Append(encoding.GetBytes("\n*Column:2*\n"));
            commandBuilder.AppendPdf417(data, 0, 2, Pdf417Level.ECC0, 2, 2);
            commandBuilder.AppendUnitFeed(32);
            commandBuilder.Append(encoding.GetBytes("\n*Column:4*\n"));
            commandBuilder.AppendPdf417(data, 0, 4, Pdf417Level.ECC0, 2, 2);
            commandBuilder.AppendUnitFeed(32);

            commandBuilder.Append(encoding.GetBytes("\n*Line:10*\n"));
            commandBuilder.AppendPdf417(data, 10, 0, Pdf417Level.ECC0, 2, 2);
            commandBuilder.AppendUnitFeed(32);
            commandBuilder.Append(encoding.GetBytes("\n*Line:40*\n"));
            commandBuilder.AppendPdf417(data, 40, 0, Pdf417Level.ECC0, 2, 2);
            commandBuilder.AppendUnitFeed(32);

            commandBuilder.Append(encoding.GetBytes("\n*Level:ECC0*\n"));
            commandBuilder.AppendPdf417(data, 0, 7, Pdf417Level.ECC0, 2, 2);
            commandBuilder.AppendUnitFeed(32);
            commandBuilder.Append(encoding.GetBytes("\n*Level:ECC8*\n"));
            commandBuilder.AppendPdf417(data, 0, 7, Pdf417Level.ECC8, 2, 2);
            commandBuilder.AppendUnitFeed(32);

            commandBuilder.Append(encoding.GetBytes("\n*AbsolutePosition:40*\n"));
            commandBuilder.AppendPdf417WithAbsolutePosition(data, 0, 1, Pdf417Level.ECC0, 2, 2, 40);
            commandBuilder.AppendUnitFeed(32);

            commandBuilder.Append(encoding.GetBytes("\n*Alignment:Center*\n"));
            commandBuilder.AppendPdf417WithAlignment(data, 0, 1, Pdf417Level.ECC0, 2, 2, AlignmentPosition.Center);
            commandBuilder.AppendUnitFeed(32);
            commandBuilder.Append(encoding.GetBytes("\n*Alignment:Right*\n"));
            commandBuilder.AppendPdf417WithAlignment(data, 0, 1, Pdf417Level.ECC0, 2, 2, AlignmentPosition.Right);
            commandBuilder.AppendUnitFeed(32);

            commandBuilder.AppendCutPaper(CutPaperAction.PartialCutWithFeed);

            commandBuilder.EndDocument();

            return commandBuilder.Commands;
        }

        public static byte[] CreateQrCodeData(StarIoExtEmulation emulation)
        {
//          Encoding encoding = Encoding.ASCII;
            Encoding encoding = Encoding.UTF8;

            byte[] data = encoding.GetBytes("Hello World.");

            ICommandBuilder commandBuilder = Extension.CreateCommandBuilder(emulation);

            commandBuilder.BeginDocument();

            commandBuilder.Append(encoding.GetBytes("*Cell:2*\n"));
            commandBuilder.AppendQrCode(data, QrCodeModel.No2, QrCodeLevel.L, 2);
            commandBuilder.AppendUnitFeed(32);
            commandBuilder.Append(encoding.GetBytes("*Cell:8*\n"));
            commandBuilder.AppendQrCode(data, QrCodeModel.No2, QrCodeLevel.L, 8);
            commandBuilder.AppendUnitFeed(32);

            commandBuilder.Append(encoding.GetBytes("*Level:L*\n"));
            commandBuilder.AppendQrCode(data, QrCodeModel.No2, QrCodeLevel.L, 4);
            commandBuilder.AppendUnitFeed(32);
            commandBuilder.Append(encoding.GetBytes("*Level:M*\n"));
            commandBuilder.AppendQrCode(data, QrCodeModel.No2, QrCodeLevel.M, 4);
            commandBuilder.AppendUnitFeed(32);
            commandBuilder.Append(encoding.GetBytes("*Level:Q*\n"));
            commandBuilder.AppendQrCode(data, QrCodeModel.No2, QrCodeLevel.Q, 4);
            commandBuilder.AppendUnitFeed(32);
            commandBuilder.Append(encoding.GetBytes("*Level:H*\n"));
            commandBuilder.AppendQrCode(data, QrCodeModel.No2, QrCodeLevel.H, 4);
            commandBuilder.AppendUnitFeed(32);

            commandBuilder.Append(encoding.GetBytes("\n*AbsolutePosition:40*\n"));
            commandBuilder.AppendQrCodeWithAbsolutePosition(data, QrCodeModel.No2, QrCodeLevel.L, 4, 40);
            commandBuilder.AppendUnitFeed(32);

            commandBuilder.Append(encoding.GetBytes("\n*Alignment:Center*\n"));
            commandBuilder.AppendQrCodeWithAlignment(data, QrCodeModel.No2, QrCodeLevel.L, 4, AlignmentPosition.Center);
            commandBuilder.AppendUnitFeed(32);
            commandBuilder.Append(encoding.GetBytes("\n*Alignment:Right*\n"));
            commandBuilder.AppendQrCodeWithAlignment(data, QrCodeModel.No2, QrCodeLevel.L, 4, AlignmentPosition.Right);
            commandBuilder.AppendUnitFeed(32);

            commandBuilder.AppendCutPaper(CutPaperAction.PartialCutWithFeed);

            commandBuilder.EndDocument();

            return commandBuilder.Commands;
        }

        public static byte[] CreateBlackMarkData(StarIoExtEmulation emulation, BlackMarkType type)
        {
//          Encoding encoding = Encoding.ASCII;
            Encoding encoding = Encoding.UTF8;

            byte[] data = encoding.GetBytes("Hello World.\n");

            ICommandBuilder commandBuilder = Extension.CreateCommandBuilder(emulation);

            commandBuilder.BeginDocument();

            commandBuilder.AppendBlackMark(type);

            commandBuilder.Append(data);

            commandBuilder.AppendCutPaper(CutPaperAction.PartialCutWithFeed);

//          commandBuilder.AppendBlackMark(BlackMarkType.Invalid);

            commandBuilder.EndDocument();

            return commandBuilder.Commands;
        }

        public static byte[] CreatePageModeData(StarIoExtEmulation emulation, int width)
        {
//          Encoding encoding = Encoding.ASCII;
            Encoding encoding = Encoding.UTF8;

            byte[] data = encoding.GetBytes("Hello World.\n");

            Assembly assembly = typeof(ApiFunctions).GetTypeInfo().Assembly;

            Stream starLogoStream = assembly.GetManifestResourceStream("XamarinSDK.Resources.StarLogoImage.png");

            int height = 30 * 8;     // 30mm!!!

            Rectangle rectangle;

            ICommandBuilder commandBuilder = Extension.CreateCommandBuilder(emulation);

            commandBuilder.BeginDocument();

            commandBuilder.Append(encoding.GetBytes("\n*Normal*\n"));

            rectangle = new Rectangle(0, 0, width, height);

            commandBuilder.BeginPageMode(rectangle, BitmapConverterRotation.Normal);

            commandBuilder.Append(data);

            commandBuilder.AppendPageModeVerticalAbsolutePosition(160);

            commandBuilder.Append(data);

            commandBuilder.AppendPageModeVerticalAbsolutePosition(80);

            commandBuilder.AppendAbsolutePosition(data, 40);

            commandBuilder.EndPageMode();

            commandBuilder.Append(encoding.GetBytes("\n*Right90*\n"));

////        rectangle = new StarIoWrapper.Rectangle(0, 0, width,  height);
//          rectangle = new StarIoWrapper.Rectangle(0, 0, height, width);
            rectangle = new StarIoWrapper.Rectangle(0, 0, width,  height);

            commandBuilder.BeginPageMode(rectangle, BitmapConverterRotation.Right90);

            commandBuilder.Append(data);

            commandBuilder.AppendPageModeVerticalAbsolutePosition(160);

            commandBuilder.Append(data);

            commandBuilder.AppendPageModeVerticalAbsolutePosition(80);

            commandBuilder.AppendAbsolutePosition(data, 40);

            commandBuilder.EndPageMode();

//          commandBuilder.Append(encoding.GetBytes("\n*Rotate180*\n"));
//
//          rectangle = new StarIoWrapper.Rectangle(0, 0, width,  height);
//
//          commandBuilder.BeginPageMode(rectangle, BitmapConverterRotation.Rotate180);
//
//          commandBuilder.Append(data);
//
//          commandBuilder.AppendPageModeVerticalAbsolutePosition(160);
//
//          commandBuilder.Append(data);
//
//          commandBuilder.AppendPageModeVerticalAbsolutePosition(80);
//
//          commandBuilder.AppendAbsolutePosition(data, 40);
//
//          commandBuilder.EndPageMode();
//
//          commandBuilder.Append(encoding.GetBytes("\n*Left90*\n"));
//
////        rectangle = new StarIoWrapper.Rectangle(0, 0, width,  height);
//          rectangle = new StarIoWrapper.Rectangle(0, 0, height, width);
//
//          commandBuilder.BeginPageMode(rectangle, BitmapConverterRotation.Left90);
//
//          commandBuilder.Append(data);
//
//          commandBuilder.AppendPageModeVerticalAbsolutePosition(160);
//
//          commandBuilder.Append(data);
//
//          commandBuilder.AppendPageModeVerticalAbsolutePosition(80);
//
//          commandBuilder.AppendAbsolutePosition(data, 40);
//
//          commandBuilder.EndPageMode();

            commandBuilder.Append(encoding.GetBytes("\n*Mixed Text*\n"));

//          rectangle = new StarIoWrapper.Rectangle(0, 0, width, height);
            rectangle = new StarIoWrapper.Rectangle(0, 0, width, width);

            commandBuilder.BeginPageMode(rectangle, BitmapConverterRotation.Normal);

            commandBuilder.AppendPageModeVerticalAbsolutePosition(width / 2);

            commandBuilder.AppendAbsolutePosition(data, width / 2);

            commandBuilder.AppendPageModeRotation(BitmapConverterRotation.Right90);

            commandBuilder.AppendPageModeVerticalAbsolutePosition(width / 2);

            commandBuilder.AppendAbsolutePosition(data, width / 2);

            commandBuilder.AppendPageModeRotation(BitmapConverterRotation.Rotate180);

            commandBuilder.AppendPageModeVerticalAbsolutePosition(width / 2);

            commandBuilder.AppendAbsolutePosition(data, width / 2);

            commandBuilder.AppendPageModeRotation(BitmapConverterRotation.Left90);

            commandBuilder.AppendPageModeVerticalAbsolutePosition(width / 2);

            commandBuilder.AppendAbsolutePosition(data, width / 2);

            commandBuilder.EndPageMode();

            commandBuilder.Append(encoding.GetBytes("\n*Mixed Bitmap*\n"));

//          rectangle = new StarIoWrapper.Rectangle(0, 0, width, height);
            rectangle = new StarIoWrapper.Rectangle(0, 0, width, width);

            commandBuilder.BeginPageMode(rectangle, BitmapConverterRotation.Normal);

            commandBuilder.AppendPageModeVerticalAbsolutePosition(width / 2);

            commandBuilder.AppendBitmapWithAbsolutePosition(starLogoStream, true, width / 2);

            commandBuilder.AppendPageModeRotation(BitmapConverterRotation.Right90);

            commandBuilder.AppendPageModeVerticalAbsolutePosition(width / 2);

            commandBuilder.AppendBitmapWithAbsolutePosition(starLogoStream, true, width / 2);

            commandBuilder.AppendPageModeRotation(BitmapConverterRotation.Rotate180);

            commandBuilder.AppendPageModeVerticalAbsolutePosition(width / 2);

            commandBuilder.AppendBitmapWithAbsolutePosition(starLogoStream, true, width / 2);

            commandBuilder.AppendPageModeRotation(BitmapConverterRotation.Left90);

            commandBuilder.AppendPageModeVerticalAbsolutePosition(width / 2);

            commandBuilder.AppendBitmapWithAbsolutePosition(starLogoStream, true, width / 2);

            commandBuilder.EndPageMode();

            commandBuilder.AppendCutPaper(CutPaperAction.PartialCutWithFeed);

            commandBuilder.EndDocument();

            return commandBuilder.Commands;
        }
    }
}
