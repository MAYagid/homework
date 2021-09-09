namespace Class2 {
    public class Class2
    {
        public enum Roman
        {
            I = 1,
            V = 5,
            X = 10,
            L = 50,
            C = 100,
            D = 500,
            M = 1000
        }

        public int ToArabic(char c)
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

        public int RomToAr(string roman)
        {
            int N = roman.Length;
            int sum = ToArabic(roman[N - 1]);
            for (int i = N - 2; i >= 0; i--)
            {
                if (roman[i] < roman[i + 1])
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
