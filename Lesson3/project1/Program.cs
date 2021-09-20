using System;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер матрицы: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[100, 100];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"a[{i},{j}]=");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i == j)
                    {
                        Console.Write(arr[i, j]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            
        }
    }
}
