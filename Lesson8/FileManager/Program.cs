using System;
using System.IO;



namespace FileManager
{
    
    class Program
    {
        

        static void Main(string[] args)
        {
            Direct dir = new Direct();
            dir.current = Directory.GetCurrentDirectory();
            dir.pages = 0;

            //var cur_dir = Directory.GetCurrentDirectory();
            //cur_dir = @"C:\";
            
            Class1.Command(dir);
            //Console.ReadLine();
        }
    }
}
