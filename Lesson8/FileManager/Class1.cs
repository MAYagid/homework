using System;

public class Class1
{
	public static void print()
	{
		Console.WriteLine("Hello");
	}
    
    public static void Border()
    //рисуем границы
    {
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        int H = Console.WindowHeight;
        int W = Console.WindowWidth;
        for (int i = 1; i < W - 1; i++)
        {
            Console.SetCursorPosition(i, 0);
            Console.Write("═");
            Console.SetCursorPosition(i, H - 1);
            Console.Write('═');
        }
        for (int j = 1; j < H - 1; j++)
        {
            Console.SetCursorPosition(0, j);
            Console.Write("|");
            Console.SetCursorPosition(W - 1, j);
            Console.Write('|');
            Console.SetCursorPosition((W - 1) / 2, j);
            Console.Write('|');
            Console.SetCursorPosition((W - 1) / 4, j);
            Console.Write('|');
            Console.SetCursorPosition((W - 1) / 4 * 3, j);
            Console.Write('║');
        }
        Console.SetCursorPosition(0, 0);
        Console.Write("╔");
        Console.SetCursorPosition(W - 1, 0);
        Console.Write("╗");
        Console.SetCursorPosition(0, H - 1);
        Console.Write("╚");
        Console.SetCursorPosition(W - 1, H - 1);
        Console.Write("╝");


    }
    public Class1()
	{
	}
}
