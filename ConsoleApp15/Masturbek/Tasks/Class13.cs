using System;

namespace CharTasksApp.Tasks
{
    public class Task13 : TaskBase
    {
        public override void Run()
        {
            Console.Clear();
            Console.WriteLine("Задание 13: Дан массив символов. Определить, сколько раз входит в него группа букв abc.");

            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();

            int count = 0;
            for (int i = 0; i <= input.Length - 3; i++)
            {
                if (input.Substring(i, 3).Equals("abc", StringComparison.OrdinalIgnoreCase))
                {
                    count++;
                }
            }

            Console.WriteLine($"Группа 'abc' встречается {count} раз");

            WaitForAnyKey();
        }
    }
}