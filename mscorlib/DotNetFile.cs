using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace LibDotNetParser.CILApi
{
    public class DotNetFile
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        public DotNetFile(string Path) { }
        [MethodImpl(MethodImplOptions.InternalCall)]
        public DotNetFile(byte[] file) { }
    }
}
