using System;

namespace CharTasksApp.Tasks
{
    public class Task12 : TaskBase
    {
        public override void Run()
        {
            Console.Clear();
            Console.WriteLine("Задание 12: Дан массив символов, среди которых есть символ '#'. Определить, сколько символов стоит после него.");

            Console.WriteLine("Введите строку, содержащую символ '#':");
            string input = Console.ReadLine();

            int hashIndex = input.IndexOf('#');
            if (hashIndex == -1)
            {
                Console.WriteLine("Символ '#' не найден в строке.");
            }
            else
            {
                int countAfter = input.Length - hashIndex - 1;
                Console.WriteLine($"Количество символов после '#': {countAfter}");
            }

            WaitForAnyKey();
        }
    }
}