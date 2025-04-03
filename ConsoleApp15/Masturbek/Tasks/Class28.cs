using System;
using System.Text;

namespace CharTasksApp.Tasks
{
    public class Task28 : TaskBase
    {
        public override void Run()
        {
            Console.Clear();
            Console.WriteLine("Задание 28: Дан массив символов. Заменить в нем каждую точку многоточнем (тремя точками).");

            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();

            StringBuilder result = new StringBuilder();

            foreach (char c in input)
            {
                if (c == '.')
                {
                    result.Append("...");
                }
                else
                {
                    result.Append(c);
                }
            }

            Console.WriteLine($"Результат: {result.ToString()}");

            WaitForAnyKey();
        }
    }
}