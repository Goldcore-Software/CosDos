using Cosmos.System.FileSystem;
using libDotNetClr;
using LibDotNetParser.CILApi;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sys = Cosmos.System;

namespace CosDos
{
    public class Kernel : Sys.Kernel
    {
        CosmosVFS fs = new Sys.FileSystem.CosmosVFS();
        DotNetClr clr;
        int emergencymode = 0;

        protected override void BeforeRun()
        {
            Console.WriteLine("Starting COS-DOS...");
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
            if (!File.Exists(@"0:\COSDOS\command.exe"))
            {
                emergencymode = 1;
                Console.WriteLine("Emergency console");
            }
            else
            {
                ExecutableManager.StartExecutable(@"0:\COSDOS\command.exe");
            }
        }

        protected override void Run()
        {
            try
            {
                Console.Write("emergency> ");
                var input = Console.ReadLine();
                var fl = new DotNetFile(input);
                clr = new DotNetClr(fl, @"0:\framework");
                clr.Start();
            }
            catch (Exception)
            {

                
            }
            
        }
    }
}
