using System;
using System.IO;


namespace FileManager
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int H = Console.WindowHeight;
            int W = Console.WindowWidth;
            var dir = Directory.GetDirectories(@"C:\");
            Class1.Border();
            for (int i = 0; i < dir.Length; ++i)
            {
                if (i % 2 == 0)
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(W/2, H/2);
                Console.WriteLine(dir[i]);
            }
            Class1.print();
            
        }
    }
}
