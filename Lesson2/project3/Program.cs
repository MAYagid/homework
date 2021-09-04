using System;

namespace project3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int numb = Convert.ToInt32(Console.ReadLine());
            if (numb % 2 == 0)
                Console.WriteLine($"число {numb} четное") ;
            else
                Console.WriteLine($"число {numb} нечетное");

        }
    }
}
