
/*Написать метод GetFullName(string firstName, string lastName, string patronymic), 
 * принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО. 
 * Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.*/

using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; ++i)
            {
                Console.Write("Введите имя: ");
                string fn = Console.ReadLine();
                Console.Write("Введите отчество: ");
                string patr = Console.ReadLine();
                Console.Write("Введите фамилию: ");
                string ln = Console.ReadLine();
                Console.WriteLine(GetFullName(fn, ln, patr));
            }
        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            string fio = firstName + ' ' + patronymic + ' ' + lastName;
            return fio;
        }
    }
}
