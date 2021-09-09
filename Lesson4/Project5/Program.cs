using System;

namespace Project5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomToAr(Console.ReadLine()));
        }

        static int ToArabic(char c)
        {
            switch (c)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
            }
            return 0;
        }

        static int RomToAr(string roman)
        {
            int N = roman.Length;
            int sum = ToArabic(roman[N - 1]);
            for (int i = N - 2; i >= 0; i--)
            {
                if (ToArabic(roman[i]) < ToArabic(roman[i + 1]))
                {
                    sum -= ToArabic(roman[i]);
                }
                else
                {
                    sum += ToArabic(roman[i]);
                }
                
            }
            return sum;
        }

    }
}
