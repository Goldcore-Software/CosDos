using Cosmos.System.FileSystem;
using libDotNetClr;
using LibDotNetParser.CILApi;
using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace CosDos
{
    public class Kernel : Sys.Kernel
    {
        CosmosVFS fs = new Sys.FileSystem.CosmosVFS();
        DotNetClr clr;

        protected override void BeforeRun()
        {
            Console.WriteLine("Starting COS-DOS...");
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
            Console.WriteLine("Emergency console");
        }

        protected override void Run()
        {
            Console.Write("emergency> ");
            var input = Console.ReadLine();
            var fl = new DotNetFile(input);
            clr = new DotNetClr(fl, @"0:\framework");
            clr.Start();
        }
    }
}
