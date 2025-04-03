using System;
using System.Text;

namespace CharTasksApp.Tasks
{
    public class Task16 : TaskBase
    {
        public override void Run()
        {
            Console.Clear();
            Console.WriteLine("Задание 16: Дан массив символов. Удалить часть текста, заключенного в скобки (вместе со скобками).");

            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();

            StringBuilder result = new StringBuilder();
            bool inBrackets = false;

            foreach (char c in input)
            {
                if (c == '(')
                {
                    inBrackets = true;
                    continue;
                }

                if (c == ')')
                {
                    inBrackets = false;
                    continue;
                }

                if (!inBrackets)
                {
                    result.Append(c);
                }
            }

            Console.WriteLine($"Результат: {result.ToString()}");

            WaitForAnyKey();
        }
    }
}