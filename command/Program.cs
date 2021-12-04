using System;
using CosDos;

namespace command
{
    class Program
    {
        public static string CurrentDirectory = @"0:\";
        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write(CurrentDirectory + ">");
                Console.ReadLine();
            }
        }
    }
}
