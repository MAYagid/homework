/*Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом, и возвращающую число — сумму всех чисел в строке. 
 * Ввести данные с клавиатуры и вывести результат на экран.*/

using System;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа через пробел");
            var str = Console.ReadLine();
            int summ = sumOfNum(str);
            Console.WriteLine(summ);
        }

        static int sumOfNum(string s)
        {
            int sum = 0;
            string[] st = s.Trim(' ').Split(' ');
            for (int i=0; i<st.Length; i++)
            {
                sum += Convert.ToInt32(st[i]);
            }
            return sum;
        }
    }
}
