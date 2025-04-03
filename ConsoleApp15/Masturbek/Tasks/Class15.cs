using System;
using System.Text;

namespace CharTasksApp.Tasks
{
    public class Task15 : TaskBase
    {
        public override void Run()
        {
            Console.Clear();
            Console.WriteLine("Задание 15: Дан массив символов. Удалить символ «двоеточие» (:) и подсчитать количество удаленных символов.");

            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            int removeCount = 0;

            foreach (char c in input)
            {
                if (c != ':')
                {
                    sb.Append(c);
                }
                else
                {
                    removeCount++;
                }
            }

            Console.WriteLine($"Результат: {sb.ToString()}");
            Console.WriteLine($"Удалено символов: {removeCount}");

            WaitForAnyKey();
        }
    }
}