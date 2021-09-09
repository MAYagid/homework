/*
 * Написать программу, вычисляющую число Фибоначчи для заданного значения рекурсивным способом
 */

using System;

namespace Project4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер элемента: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fibonachi(N));
        }

        static int Fibonachi(int n)
        {
            if (n < 3)
                return 1;
            else
            {
                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
        }
    }
}
