using System;
using System.IO;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string testfile = "testfile.txt";
            Console.WriteLine("Введите строку: ");
            string str1 = Console.ReadLine();
            File.WriteAllText(testfile, str1);

        }
    }
}
