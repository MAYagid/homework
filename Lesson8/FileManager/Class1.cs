using System;
using System.IO;


public class Direct
{
    public string current { get; set; }
    public int pages { get; set; }
}

public class Class1
{
    public static void Command(Direct dir)
    {
        Class1.Border();
        Class1.PrintCurrentDir(dir);
        Class1.PrintCatalog(dir);
        Console.SetCursorPosition(0, 25);
        string com;
        Console.Write(dir.current + ">>> ");
        com = Console.ReadLine();
        if (com.StartsWith("cd"))
        {
            ChangeDir(dir, com);
            dir.pages = 0;
        }
        if (com == "exit") return;
        if (com == "next") 
        { 
            if (Directory.GetDirectories(dir.current).Length - 20 > dir.pages * 20) dir.pages++;
        }
        if (com == "prev")
        {
            if (dir.pages > 0) dir.pages--;
        }

        if (com.StartsWith("del"))
        {
            DelDir(dir);
        }

        Command(dir);
    }
    public static string ShortDir(string st, int len)
    {
        string[] str;
        str = st.Split("\\");
        int N = str.Length;
        string s1 = "", s2 = "";
        int l = 0;
        if (st.Length < len)
        {
            return st;
        }
        if (str[N - 1].Length + 8 > len){
            s1 = @"C:\...\" + str[N - 1].Substring(0, len) + '~';
            return s1;
        }
        
        for (int i = 0; i < N / 2; i++)
        {
            if (i == N - 1 - i)
            {
                break;
            }
            s2 = "\\" + str[N - 1 - i] + s2;
            l += s2.Length;
            if (l >= len)
            {
                return s1 + "..." + s2;
            }
            s1 += str[i]+ "\\";
            l += s1.Length;
            if (l > len)
            {
                return s1 + "..." + s2;
            }
        }
        return s1.Substring(0,s1.Length-1) + s2;
    } 


    public static string ShortCatalog(string st, int len)
    {
        string[] str;
        str = st.Split('\\');
        int N = str.Length;
        string s1 = str[N-1];
        int l = 0;
        if (s1.Length > len)
        {
            s1 = str[N - 1].Substring(0, len-1) + "~";
            return s1;
        }
        return s1;
    }

    public static void ChangeDir(Direct dir, string com)
    {
        string cur_dir;
        cur_dir = com.Substring(3);
        if (Directory.Exists(cur_dir))
            dir.current = com.Substring(3);
        else if (Directory.Exists(dir.current + @"\" + cur_dir))
            dir.current = dir.current + @"\" + cur_dir;
        else if (Directory.Exists(@"C:\" + cur_dir))
            dir.current = @"C:\" + cur_dir;

    }

    public static void DelDir(Direct dir)
    {
        string ans;
        if (Directory.GetDirectories(dir.current).Length == 0 || Directory.GetFiles(dir.current).Length == 0)
        {
            Console.Write("Каталог не пустой. Удалить каталог и его содержимое? (y/n)");
            while (true)
            {
                ans = Console.ReadLine();
                if (ans == "y" || ans == "n") break;
            }
            if (ans == "y")
            {
                Directory.Delete(dir.current, true);
                ChangeDir(dir, @"cd C:\");
            }
        }
    }
    public static void Print(string s,
                             int x = 0,
                             int y = 0,
                             ConsoleColor bg = ConsoleColor.Black,
                             ConsoleColor fg = ConsoleColor.DarkYellow)   
    {
        Console.ForegroundColor = fg;
        Console.BackgroundColor = bg;
        Console.SetCursorPosition(x, y);
        Console.Write(s);
    }
    
    public static void Border()
    //рисуем границы
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        int H = Console.WindowHeight;
        int W = Console.WindowWidth;
        for (int i = 0; i < W - 1; i++)
        {
            Print("═", i, 1);
            //Console.SetCursorPosition(i, 0);
            //Console.Write("═");
            Print("═", i, H - 7);
            //Console.SetCursorPosition(i, H - 1);
            //Console.Write('═');
        }
        for (int j = 2; j < H - 7; j++)
        {
            Print("║", 0, j);
            Print("║", W - 1, j);
            Print("║", (W - 1) / 2, j);
            Print("║", (W - 1) / 2 + 1, j);
            Print("│", (W - 1) / 4, j);
            Print("│", (W - 1) / 4 * 3 + 1, j);
        }
        Print("╔", 0, 1);
        Print("╔", (W - 1) / 2 + 1, 1);
        Print("╗", W - 1, 1);
        Print("╗", (W - 1) / 2, 1);
        Print("╚", 0, H - 7);
        Print("╝", W - 1, H - 7);
        Print("╚", (W - 1) / 2 + 1, H - 7);
        Print("╝", (W - 1) / 2, H - 7);
        //Console.SetCursorPosition(0, 0);
        //Console.Write("╔");
        //Console.SetCursorPosition(W - 1, 0);
        //Console.Write("╗");
        //Console.SetCursorPosition(0, H - 1);
        //Console.Write("╚");
        //Console.SetCursorPosition(W - 1, H - 1);
        //Console.Write("╝");
        
        Print("exit - выход    cd <каталог> - смена каталога    next - следующая страница", 1, 27, ConsoleColor.Black, ConsoleColor.White);
        Print("prev - предыдущая страница", 1, 28, ConsoleColor.Black, ConsoleColor.White);

    }

    public static void PrintCatalog(Direct dir)
    {
        int page = dir.pages;
        int H = Console.WindowHeight;
        int W = Console.WindowWidth;
        var dir1 = Directory.GetDirectories(dir.current);
        var file1 = Directory.GetFiles(dir.current);
        for (int i = page * 20; i < Math.Min(dir1.Length, (page + 1) * 20); ++i)
        {
            Print(ShortCatalog(dir1[i], 15),1, i % 20 +2, ConsoleColor.Black, ConsoleColor.DarkYellow);
        }
        for (int i = 0; i < Math.Min(20, file1.Length); i++)
        {
            Print(ShortCatalog(file1[i], 15), W / 4 + 1, i % 20 + 2, ConsoleColor.Black, ConsoleColor.DarkYellow);
        }
        if (dir1.Length - (page + 1) * 20 > 0)
            Print("...", 1, 22, ConsoleColor.Black, ConsoleColor.DarkYellow);
    }
    public static void PrintCurrentDir(Direct dir)
    {
        
        Print(ShortDir(dir.current, 40), 0, 0, ConsoleColor.Black, ConsoleColor.Red);
    }
    public Class1()
	{
	}

}
