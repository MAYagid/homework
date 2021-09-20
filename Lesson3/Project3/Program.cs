using System;

namespace Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            str = Console.ReadLine();
            for (int i = str.Length-1; i>=0; i--)
            {
                Console.Write(str[i]);
            }
          
        }
    }
}
