using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StarIoWrapper;

namespace XamarinSDK.Functions
{
    class CashDrawerFunctions
    {
        public static byte[] CreateData(StarIoExtEmulation emulation, PeripheralChannel channel)
        {
            ICommandBuilder commandBuilder = Extension.CreateCommandBuilder(emulation);

            commandBuilder.BeginDocument();

            commandBuilder.AppendPeripheral(channel);

            commandBuilder.EndDocument();

            return commandBuilder.Commands;
        }
    }
}
