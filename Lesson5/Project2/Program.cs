using System;
using System.IO;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            string testfile = "startup.txt";
            
            File.AppendAllText(testfile, $"{DateTime.Now:T} \n");
            Console.WriteLine("Done");
        }
    }
}
