using System;
using System.IO;

namespace Project4
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirName = "C:\\";

            string filename = "text.txt";
            string n = "\n";
            if (Directory.Exists(dirName))
            {
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string s in dirs)
                {
                    File.AppendAllText(filename, s);
                    File.AppendAllText(filename, n);
                }
                string[] files = Directory.GetFiles(dirName);
                foreach (string s in files)
                {
                    File.AppendAllText(filename, s);
                    File.AppendAllText(filename, n);
                }
            }
        }
    }
}

