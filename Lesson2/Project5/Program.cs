using System;

namespace Project5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер месяца: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите минимальную температуру: ");
            int min_T = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите максимальную температуру: ");
            int max_T = Convert.ToInt32(Console.ReadLine());
            if ((month > 0 && month < 3 || month == 12) && (max_T + min_T) / 2 > 0)
                Console.WriteLine("Дождливая зима");
        }
    }
}
