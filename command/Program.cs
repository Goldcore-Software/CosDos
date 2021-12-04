using System;
using CosDos;

namespace command
{
    class Program
    {
        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write(Shell.GetCurrentDirectory() + ">");
                Shell.Run(Console.ReadLine());
            }
        }
    }
}
