using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CosDos
{
    public class Shell
    {
        public static string CurrentDirectory = Kernel.SystemDriveNumber + @":\";
        public static void Run(string cmdline)
        {
            string[] cmdsplit = cmdline.Split(' ');
            string cmd = cmdsplit[0];
            switch (cmd)
            {
                case "setcd":
                    CurrentDirectory = cmdsplit[1];
                    break;
                case "miv":
                    File.WriteAllText(Path.GetFullPath(cmd, CurrentDirectory), MIV.MIV.miv(File.ReadAllText(Path.GetFullPath(cmd, CurrentDirectory))));
                    break;
                case "":
                    break;
                default:
                    if (File.Exists(Path.GetFullPath(cmd,CurrentDirectory)))
                    {
                        ExecutableManager.StartExecutable(Path.GetFullPath(cmd, CurrentDirectory));
                    }
                    else
                    {
                        Console.WriteLine("\'" + cmd + "\' is not recognized as an internal or external command,");
                        Console.WriteLine("operable program or batch file.");
                    }
                    break;
            }
        }
        public static string GetCurrentDirectory()
        {
            return CurrentDirectory;
        }
        public static void SetCurrentDirectory(string currdir)
        {
            CurrentDirectory = currdir;
        }
    }
}
