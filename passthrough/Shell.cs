using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CosDos
{
    public class Shell
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        public static void Run(string cmdline) { }
        [MethodImpl(MethodImplOptions.InternalCall)]
        public static string GetCurrentDirectory() { return ""; } // dummy value
        [MethodImpl(MethodImplOptions.InternalCall)]
        public static void SetCurrentDirectory(string currdir) { }
    }
}
