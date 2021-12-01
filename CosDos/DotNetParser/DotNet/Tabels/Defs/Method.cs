using LibDotNetParser.PE;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace LibDotNetParser.DotNet.Tabels.Defs
{
    public class Method : IMetadataTableRow
    {
        public uint RVA { get; private set; }
        public ushort ImplFlags { get; private set; }
        public ushort Flags { get; private set; }
        public uint Name { get; private set; }
        public uint Signature { get; private set; }
        public uint ParamList { get; private set; }
        [MethodImpl(MethodImplOptions.InternalCall)]
        public void Read(MetadataReader reader)
        {
        }
    }
}
