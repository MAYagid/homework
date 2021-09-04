using System;

namespace Project7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            ulong numb = Convert.ToUInt64(Console.ReadLine());
            byte T = 10;
            while (numb / (ulong)Math.Pow(10, T) == 0)
            {
                T--;
            }
            while (numb > 0)
            {
                ulong n1 = numb / (ulong)Math.Pow(10, T);
                ulong n2 = numb % 10;
                if (n1 != n2)
                {
                    Console.WriteLine("Не палиндром");
                    break;
                }
                numb %= (ulong)Math.Pow(10,T);
                numb /= 10;
                T -= 2;
            }
            if (numb == 0)
                Console.WriteLine("палиндром");

        }
    }
}
