using System;

namespace CharTasksApp.Tasks
{
    public class Task11 : TaskBase
    {
        public override void Run()
        {
            Console.Clear();
            Console.WriteLine("Задание 11: Дан массив символов. Определить, сколько в нем символов '*', ';', ':'.");

            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();

            int starCount = 0, semicolonCount = 0, colonCount = 0;

            foreach (char c in input)
            {
                switch (c)
                {
                    case '*': starCount++; break;
                    case ';': semicolonCount++; break;
                    case ':': colonCount++; break;
                }
            }

            Console.WriteLine($"Результат: *={starCount}, ;={semicolonCount}, :={colonCount}");

            WaitForAnyKey();
        }
    }
}