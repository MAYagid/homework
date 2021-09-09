using System;

public class Class1
{
	public Class1()
	{
	}

    public static Roman ToArab(char c)
    {
        switch (c)
        {
            case 'I': return Roman.I;
            case 'V': return Roman.V;
            case 'X': return Roman.X;
            case 'L': return Roman.L;
            case 'C': return Roman.C;
            case 'D': return Roman.D;
            case 'M': return Roman.M;


        }
        return 0;
    }

    public static(int, int) Razr(string roman, char c1, char c2, char c3, int i)
    {
        int Arabic = 0;
        //вычисление разряда единиц
        if (i >= 0 && roman[i] == c1)
        {
            while (i >= 0 && roman[i] == c1)
            {
                Arabic += (int)ToArab(roman[i]);
                i--;
            }
        }
        if (i >= 0 && (roman[i] == c2 || roman[i] == c3))
        {
            if (i - 1 >= 0 && roman[i - 1] == c1)
            {
                Arabic += ((int)ToArab(roman[i]) - (int)ToArab(c1));
                i -= 2;
            }
            else if (i >= 0 && roman[i] == c2)
            {
                Arabic += (int)ToArab(c2);
                i--;
            }

        }

        return (Arabic, i);
    }

    public static int RomanToArabic(string roman)
    {
        int Arabic = 0;
        int N = roman.Length - 1;
        Console.WriteLine(N);
        var R = Razr(roman, 'I', 'V', 'X', N);
        Arabic += R.Item1;
        N = R.Item2;
        Console.WriteLine(N);
        R = Razr(roman, 'X', 'L', 'C', N);
        Arabic += R.Item1;
        N = R.Item2;
        Console.WriteLine(N);
        R = Razr(roman, 'C', 'D', 'M', N);
        Arabic += R.Item1;
        N = R.Item2;
        Console.WriteLine(N);
        R = Razr(roman, 'M', ' ', ' ', N);
        Arabic += R.Item1;
        Console.WriteLine(R.Item2);


        return Arabic;
    }
}
