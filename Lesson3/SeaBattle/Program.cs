using System;

namespace SeaBattle
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Морской бой без проверки пересечений кораблей
            char[,] field = new char[10, 10];
            //создаем пустое поле
            for (int i = 0; i < 10; ++i)
            {
                for (int j = 0; j < 10; ++j)
                {
                    field[i, j] = '0';
                    Console.Write(field[i, j] + " ");
                }
                Console.WriteLine();
            }
            //ставим четырехпалубник
            for (int k = 0; k < 1; k++)
            {
                Console.Write("Разместить 4-палубный корабль по-горизонтали (y/n): ");
                string r = Console.ReadLine();
                Console.WriteLine("Введите координаты начальной точки корабля");
                Console.Write("строка = ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("столбец = ");
                int y = Convert.ToInt32(Console.ReadLine());

                if (r == "y")
                {
                    for (int i = y; i < y + 4; i++)
                    {
                        field[x - 1, i - 1] = 'X';
                    }
                }
                else
                {
                    for (int i = x; i < x + 4; i++)
                    {
                        field[i - 1, y - 1] = 'X';
                    }
                }
                //вывод поля
                for (int i = 0; i < 10; ++i)
                {
                    for (int j = 0; j < 10; ++j)
                    {
                        Console.Write(field[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
                //ставим трехпалубники
            for (int k = 0; k < 2; k++)
                {
                    Console.Write("Разместить 3-палубный корабль по-горизонтали (y/n): ");
                    string r = Console.ReadLine();
                    Console.WriteLine("Введите координаты начальной точки корабля");
                    Console.Write("строка = ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("столбец = ");
                    int y = Convert.ToInt32(Console.ReadLine());

                if (r == "y")
                    {
                        for (int i = y; i < y + 3; i++)
                        {
                            field[x - 1, i - 1] = 'X';
                        }
                    }
                    else
                    {
                        for (int i = x; i < x + 3; i++)
                        {
                            field[i - 1, y - 1] = 'X';
                        }
                    }
                //вывод поля
                for (int i = 0; i < 10; ++i)
                    {
                        for (int j = 0; j < 10; ++j)
                        {
                            Console.Write(field[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            
            for (int k = 0; k < 3; k++)
            {
                Console.Write("Разместить 2-палубный корабль по-горизонтали (y/n): ");
                string r = Console.ReadLine();
                Console.WriteLine("Введите координаты начальной точки корабля");
                Console.Write("строка = ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("столбец = ");
                int y = Convert.ToInt32(Console.ReadLine());

                if (r == "y")
                {
                    for (int i = y; i < y + 2; i++)
                    {
                        field[x - 1, i - 1] = 'X';
                    }
                }
                else
                {
                    for (int i = x; i < x + 2; i++)
                    {
                        field[i - 1, y - 1] = 'X';
                    }
                }
                //вывод поля
                for (int i = 0; i < 10; ++i)
                {
                    for (int j = 0; j < 10; ++j)
                    {
                        Console.Write(field[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            for (int k = 0; k < 4; k++)
            {
                //Console.Write("Разместить 1-палубный корабль по-горизонтали (y/n): ");
                //string r = Console.ReadLine();
                string r = "y";
                Console.WriteLine("Введите координаты начальной точки корабля");
                Console.Write("строка = ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("столбец = ");
                int y = Convert.ToInt32(Console.ReadLine());

                if (r == "y")
                {
                    for (int i = y; i < y + 1; i++)
                    {
                        field[x - 1, i - 1] = 'X';
                    }
                }
                else
                {
                    for (int i = x; i < x + 1; i++)
                    {
                        field[i - 1, y - 1] = 'X';
                    }
                }
                //вывод поля
                for (int i = 0; i < 10; ++i)
                {
                    for (int j = 0; j < 10; ++j)
                    {
                        Console.Write(field[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}
