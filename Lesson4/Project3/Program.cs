/*
 * Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца. 
 * На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn. 
 * Написать метод, принимающий на вход значение из этого перечисления и возвращающий название времени года 
 * (зима, весна, лето, осень). Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года. 
 * Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12»
 */

using System;

namespace Project3
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер месяца: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(SetSeason(GetSeason(month)));
        }

        enum Season
        {
            nan,
            Spring,
            Summer,
            Autumn,
            Winter
        }
        static Season GetSeason(int i)
        {
            switch ((i % 12) / 3)
            {
                case 0:
                     return Season.Winter;
                case 1:
                    return Season.Spring;
                case 2:
                    return Season.Summer;
                case 3:
                    return Season.Autumn;
              
            }
            return Season.nan;
        }

        static string SetSeason(Season seasonname)
        {
            switch (seasonname) {
                case Season.Winter:
                    return "зима";
                case Season.Summer:
                    return "лето";
                case Season.Autumn:
                    return "осень";
                case Season.Spring:
                    return "весна";
                default:
                    return "Error";


            }

        }
    }
    
}
