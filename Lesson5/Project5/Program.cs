using System;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;

namespace Project5
{
    class Program
    {
        static void Main(string[] args)
        {
            var jsonString = File.ReadAllText("ToDoList.json");
            int N = 0;
            ToDo_List[] arr = new ToDo_List[30];
            ToDo_List[] tasks = JsonSerializer.Deserialize<ToDo_List[]>(jsonString);
            for (int i = 0; i < tasks.Length; i++)
            {
                arr[i] = tasks[i];
            }
            N = tasks.Length;
            while (true)
            {
                
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1 - Добавить задачу");
                Console.WriteLine("2 - Удалить задачу");
                Console.WriteLine("3 - Вывести список задач");
                Console.WriteLine("4 - Пометить задачу как выполненную");
                Console.WriteLine("5 - Завершить работу");
                byte act = Convert.ToByte(Console.ReadLine());
                Console.Clear();
                switch (act){
                    case 1:
                        string task = Console.ReadLine();
                        arr[N] = new ToDo_List();
                        arr[N].Title = task;
                        arr[N].IsDone = false;
                        N++;
                        var arr2 = new ToDo_List[N];
                        for (int j = 0; j < N; j++)
                        {
                            arr2[j] = arr[j];
                        }


                        string jsonstring = JsonSerializer.Serialize(arr2);
                        File.WriteAllText("ToDoList.json", jsonstring);
                        break;
                    case 2:
                        break;
                    case 3:
                        
                        //Console.Clear();
                        for (int i = 0; i < N; i++)
                        {
                            string zn = arr[i].IsDone ? "[x]" : "[ ]";
                            Console.WriteLine($"{i + 1} {zn} {arr[i].Title}");
                        }
                        break;
                    case 4:
                        Console.Write("Введите номер задачи: ");
                        int num_task = Convert.ToInt32(Console.ReadLine());
                        arr[num_task-1].IsDone = true;
                        break;
                    default:
                        
                        break;
                       
                }
                if (act == 5)
                    break;
                



            }
            

        }

        public class ToDo_List
        {
            public string Title { get; set; }
            public bool IsDone { get; set; }
            public ToDo_List()
            {
                Title = "Homework";
                IsDone = false;
            }

        }

    }
}
