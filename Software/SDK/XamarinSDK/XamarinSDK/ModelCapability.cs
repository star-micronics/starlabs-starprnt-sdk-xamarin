using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StarIoWrapper;

namespace XamarinSDK
{
    enum ModelIndex     // Don't insert(Only addition)
    {
        None = 0,
        MCPrint2,
        MCPrint3,
        MPOP,
        FVP10,
        TSP100,
        TSP650II,
        TSP700II,
        TSP800II,
        SM_S210I,
        SM_S220I,
        SM_S230I,
        SM_T300I,
        SM_T400I,
        BSC10,
        SM_S210I_StarPRNT,
        SM_S220I_StarPRNT,
        SM_S230I_StarPRNT,
        SM_T300I_StarPRNT,
        SM_T400I_StarPRNT,
        SM_L200,
        SP700,
        SM_L300
    };

    class ModelCapability
    {
        private enum ModelCapabilityIndex
        {
            Title = 0,
            Emulation,
            CashDrawerOpenActive,
            PortSettings,
            ModelNameArray
        };

        private static IList<ModelIndex> modelIndexArray = new List<ModelIndex>
        {
            ModelIndex.MCPrint2,
            ModelIndex.MCPrint3,
            ModelIndex.MPOP,
            ModelIndex.FVP10,
            ModelIndex.TSP100,
            ModelIndex.TSP650II,
            ModelIndex.TSP700II,
            ModelIndex.TSP800II,
            ModelIndex.SP700,                 // <-
            ModelIndex.SM_S210I,
            ModelIndex.SM_S220I,
            ModelIndex.SM_S230I,
            ModelIndex.SM_T300I,
            ModelIndex.SM_T400I,
            ModelIndex.SM_L200,               // <-
            ModelIndex.SM_L300,               // <-
            ModelIndex.BSC10,
            ModelIndex.SM_S210I_StarPRNT,
            ModelIndex.SM_S220I_StarPRNT,
            ModelIndex.SM_S230I_StarPRNT,
            ModelIndex.SM_T300I_StarPRNT,
            ModelIndex.SM_T400I_StarPRNT
//          ModelIndex.SM_L200,
//          ModelIndex.SP700,
//          ModelIndex.SM_L300
        };

        private static Dictionary<ModelIndex, IList<object>> modelCapabilityDictionary = new Dictionary<ModelIndex, IList<object>>
        {
            {ModelIndex.MCPrint2,          new List<object> {"mC-Print2",         StarIoExtEmulation.StarPRNT,      true,  "",         new List<string> {"MCP20 (STR-001)",
                                                                                                                                                         "MCP21 (STR-001)",
                                                                                                                                                         "MCP21",
                                                                                                                                                         "mC-Print2-",
                                                                                                                                                         "mC-Print2"}}},
            {ModelIndex.MCPrint3,          new List<object> {"mC-Print3",         StarIoExtEmulation.StarPRNT,      true,  "",         new List<string> {"MCP30 (STR-001)",
                                                                                                                                                         "MCP31",
                                                                                                                                                         "mC-Print3-",
                                                                                                                                                         "mC-Print3"}}},
            {ModelIndex.MPOP,              new List<object> {"mPOP",              StarIoExtEmulation.StarPRNT,      false, "",         new List<string> {"POP10",
                                                                                                                                                         "STAR mPOP-",
                                                                                                                                                         "mPOP"}}},
            {ModelIndex.FVP10,             new List<object> {"FVP10",             StarIoExtEmulation.StarLine,      true,  "",         new List<string> {"FVP10 (STR_T-001)",
                                                                                                                                                         "Star FVP10"}}},
            {ModelIndex.TSP100,            new List<object> {"TSP100",            StarIoExtEmulation.StarGraphic,   true,  "",         new List<string> {"TSP113",
                                                                                                                                                         "TSP143",
                                                                                                                                                         "TSP100-",
                                                                                                                                                         "Star TSP113",
                                                                                                                                                         "Star TSP143"}}},
            {ModelIndex.TSP650II,          new List<object> {"TSP650II",          StarIoExtEmulation.StarLine,      true,  "",         new List<string> {"TSP654II (STR_T-001)",
                                                                                                                                                         "TSP654 (STR_T-001)",
                                                                                                                                                         "TSP651 (STR_T-001)"}}},
            {ModelIndex.TSP700II,          new List<object> {"TSP700II",          StarIoExtEmulation.StarLine,      true,  "",         new List<string> {"TSP743II (STR_T-001)",
                                                                                                                                                         "TSP743 (STR_T-001)"}}},
            {ModelIndex.TSP800II,          new List<object> {"TSP800II",          StarIoExtEmulation.StarLine,      true,  "",         new List<string> {"TSP847II (STR_T-001)",
                                                                                                                                                         "TSP847 (STR_T-001)"}}},
            {ModelIndex.SM_S210I,          new List<object> {"SM-S210i",          StarIoExtEmulation.EscPosMobile,  false, "mini",     new List<string> {"SM-S210i"}}},
            {ModelIndex.SM_S220I,          new List<object> {"SM-S220i",          StarIoExtEmulation.EscPosMobile,  false, "mini",     new List<string> {"SM-S220i"}}},
            {ModelIndex.SM_S230I,          new List<object> {"SM-S230i",          StarIoExtEmulation.EscPosMobile,  false, "mini",     new List<string> {"SM-S230i"}}},
            {ModelIndex.SM_T300I,          new List<object> {"SM-T300i",          StarIoExtEmulation.EscPosMobile,  false, "mini",     new List<string> {"SM-T300i"}}},
            {ModelIndex.SM_T400I,          new List<object> {"SM-T400i",          StarIoExtEmulation.EscPosMobile,  false, "mini",     new List<string> {"SM-T400i"}}},
            {ModelIndex.BSC10,             new List<object> {"BSC10",             StarIoExtEmulation.EscPos,        true,  "escpos",   new List<string> {"BSC10",
                                                                                                                                                         "Star BSC10"}}},
            {ModelIndex.SM_S210I_StarPRNT, new List<object> {"SM-S210i StarPRNT", StarIoExtEmulation.StarPRNT,      false, "Portable", new List<string> {"SM-S210i StarPRNT"}}},
            {ModelIndex.SM_S220I_StarPRNT, new List<object> {"SM-S220i StarPRNT", StarIoExtEmulation.StarPRNT,      false, "Portable", new List<string> {"SM-S220i StarPRNT"}}},
            {ModelIndex.SM_S230I_StarPRNT, new List<object> {"SM-S230i StarPRNT", StarIoExtEmulation.StarPRNT,      false, "Portable", new List<string> {"SM-S230i StarPRNT"}}},
            {ModelIndex.SM_T300I_StarPRNT, new List<object> {"SM-T300i StarPRNT", StarIoExtEmulation.StarPRNT,      false, "Portable", new List<string> {"SM-T300i StarPRNT"}}},
            {ModelIndex.SM_T400I_StarPRNT, new List<object> {"SM-T400i StarPRNT", StarIoExtEmulation.StarPRNT,      false, "Portable", new List<string> {"SM-T400i StarPRNT"}}},
            {ModelIndex.SM_L200,           new List<object> {"SM-L200",           StarIoExtEmulation.StarPRNT,      false, "Portable", new List<string> {"SM-L200",
                                                                                                                                                         "STAR L200-",
                                                                                                                                                         "STAR L204-"}}},
            {ModelIndex.SP700,             new List<object> {"SP700",             StarIoExtEmulation.StarDotImpact, true,  "",         new List<string> {"SP712 (STR-001)",
                                                                                                                                                         "SP717 (STR-001)",
                                                                                                                                                         "SP742 (STR-001)",
                                                                                                                                                         "SP747 (STR-001)"}}},
            {ModelIndex.SM_L300,           new List<object> {"SM-L300",           StarIoExtEmulation.StarPRNTL,     false,  "Portable", new List<string> {"SM-L300",
                                                                                                                                                          "STAR L300-",
                                                                                                                                                          "STAR L304-"}}}
        };

        public static int ModelIndexCount
        {
            get { return modelIndexArray.Count; }
        }

        public static ModelIndex ModelIndexAtIndex(int index)
        {
            return modelIndexArray[index];
        }

        public static string TitleAtModelIndex(ModelIndex modelIndex)
        {
            return (string) modelCapabilityDictionary[modelIndex][(int) ModelCapabilityIndex.Title];
        }

        public static StarIoExtEmulation EmulationAtModelIndex(ModelIndex modelIndex)
        {
            return (StarIoExtEmulation) modelCapabilityDictionary[modelIndex][(int) ModelCapabilityIndex.Emulation];
        }

        public static bool CashDrawerOpenActiveAtModelIndex(ModelIndex modelIndex)
        {
            return (bool) modelCapabilityDictionary[modelIndex][(int) ModelCapabilityIndex.CashDrawerOpenActive];
        }

        public static string PortSettingsAtModelIndex(ModelIndex modelIndex)
        {
            return (string) modelCapabilityDictionary[modelIndex][(int) ModelCapabilityIndex.PortSettings];
        }

        public static ModelIndex ModelIndexAtModelName(string modelName)
        {
            foreach (ModelIndex modelIndex in modelIndexArray)
            {
                IList<string> modelNameArray = (IList<string>) modelCapabilityDictionary[modelIndex][(int) ModelCapabilityIndex.ModelNameArray];

                for (int i = 0; i < modelNameArray.Count; i++)
                {
                    if (modelName.StartsWith(modelNameArray[i]))
                    {
                        return modelIndex;
                    }
                }
            }

            return ModelIndex.None;
        }
    }
}
