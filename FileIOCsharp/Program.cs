using System;
using System.IO;

namespace FileIOCsharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num = 5;
            //Console.WriteLine("Enter a number: ");
            //num = Console.Read();
            for (int height = 0; height < num; height++)
            {
                int space = height;
                int cntr = 0;
                string line = "";
                Console.Write(line.PadLeft(space, ' '));
                while (cntr++ < (num - space))
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
