using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace XamarinSDK
{
    class DebugExt
    {
        public static void WriteLine(string message, [CallerMemberName] string memberName = "")
        {
            Debug.WriteLine(memberName + " : " + message);
        }
    }
}
