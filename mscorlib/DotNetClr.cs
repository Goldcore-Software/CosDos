using LibDotNetParser;
using LibDotNetParser.CILApi;
using LibDotNetParser.CILApi.IL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

namespace libDotNetClr
{
    /// <summary>
    /// DotNetCLR Class
    /// </summary>
    public partial class DotNetClr
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        public DotNetClr(DotNetFile exe, string DllPath)
        {

        }


        /// <summary>
        /// Starts the .NET Executable
        /// </summary>
        [MethodImpl(MethodImplOptions.InternalCall)]
        public void Start(string[] args = null)
        {
            
        }

        #region Utils
        [MethodImpl(MethodImplOptions.InternalCall)]
        public void RunMethodInDLL(string NameSpace, string TypeName, string MethodName)
        {
        }
        [MethodImpl(MethodImplOptions.InternalCall)]
        public bool InternalCallMethod(InlineMethodOperandData call, DotNetMethod m, bool addToCallStack, bool IsVirt, bool isConstructor, MethodArgStack constructorObj = null)
        {
            
        }

        
        #endregion
    }
}
