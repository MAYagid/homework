using System;

namespace Project6
{
    class Program
    {
        public enum Week
        {
            Mon = 0b_1000000,
            Tue = 0b_0100000,
            Wed = 0b_0010000,
            Thu = 0b_0001000,
            Fri = 0b_0000100,
            Set = 0b_0000010,
            Sun = 0b_0000001,
        }

        static void Main(string[] args)
        {
          
            Week Office1 = Week.Mon | Week.Tue | Week.Wed | Week.Fri;
            Console.WriteLine("Введите день недели (Mon, Tue, Wed, Thu, Fri, Set, Sun)");
            var Day = Console.ReadLine();
            Week choice_day = Week.Mon;
            switch (Day)
            {
                case "Mon":
                    choice_day = Week.Mon; break;
                case "Tue":
                    choice_day = Week.Tue; break;
                case "Wed":
                    choice_day = Week.Wed; break;
                case "Thu":
                    choice_day = Week.Thu; break;
                case "Fri":
                    choice_day = Week.Fri; break;
                case "Set":
                    choice_day = Week.Set; break;
                case "Sun":
                    choice_day = Week.Sun; break;
            }
            Week answer = Office1 & choice_day;
            if (answer != 0)
                Console.WriteLine("Офис работает");
            else
                Console.WriteLine("Офис не работает");
                    }
    }
}
