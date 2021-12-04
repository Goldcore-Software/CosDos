using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                default:

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
