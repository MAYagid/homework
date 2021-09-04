using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите максимальную суточную температуру: ");
            double max_T = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите минимальную суточную температуру: ");
            var min_T = Convert.ToDouble(Console.ReadLine());
            double av;
            av = (min_T + max_T) / 2;
            Console.WriteLine(av);

        }
    }
}
