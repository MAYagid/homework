using System;

namespace Project4
{
    class Program
    {
        static void Main(string[] args)
        {
            int summ = Convert.ToInt32(Console.ReadLine());
            bool cash_ = Convert.ToBoolean(Console.ReadLine());
            var cashier_name = Console.ReadLine();
            Console.WriteLine("ПРИХОД");
            Console.WriteLine($"ИТОГ    {summ}");
            if (cash_)
                Console.WriteLine("Оплата наличными");
            else
                Console.WriteLine("Оплата картой");
            Console.WriteLine($"кассир:    {cashier_name}");


        }
    }
}
