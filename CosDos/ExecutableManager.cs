using libDotNetClr;
using LibDotNetParser.CILApi;
using System;
using System.Runtime.CompilerServices;

namespace CosDos
{
    public class ExecutableManager
    {
        public static void StartExecutable(string path)
        {
            var fl = new DotNetFile(path);
            var clr = new DotNetClr(fl, @"0:\COSDOS\dotnet");
            clr.Start();
        }
    }
}
