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
        public static List<string> Path = new();
        public static int SystemDriveNumber = -1;
        int emergencymode = 0;

        protected override void BeforeRun()
        {
            Console.WriteLine("Starting COS-DOS...");
            for (int i = 0; i <= 9; i++)
            {
                try
                {
                    if (Directory.Exists(i + @":\COSDOS"))
                    {
                        SystemDriveNumber = i;
                    }
                }
                catch { }
            }
            if (SystemDriveNumber == -1)
            {
                Console.WriteLine("Could not find system drive!");
                while (true)
                {

                }
            }
            Path.Add("COSDOS");
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
