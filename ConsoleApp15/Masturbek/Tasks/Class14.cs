using System;
using System.Text;

namespace CharTasksApp.Tasks
{
    public class Task14 : TaskBase
    {
        public override void Run()
        {
            Console.Clear();
            Console.WriteLine("Задание 14: Дан массив символов. Заменить все двоеточия (:) на точку с запятой (;). Подсчитать количество замен.");

            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder(input);
            int replaceCount = 0;

            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] == ':')
                {
                    sb[i] = ';';
                    replaceCount++;
                }
            }

            Console.WriteLine($"Результат: {sb.ToString()}");
            Console.WriteLine($"Количество замен: {replaceCount}");

            WaitForAnyKey();
        }
    }
}