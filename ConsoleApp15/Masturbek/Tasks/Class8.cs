using System;

namespace CharTasksApp.Tasks
{
    public class Task8 : TaskBase
    {
        public override void Run()
        {
            Console.Clear();
            Console.WriteLine("Задание 8: Дан массив символов, среди которых есть символ двоеточие ':'. Определить, сколько символов ему предшествует.");

            Console.WriteLine("Введите строку, содержащую символ ':':");
            string input = Console.ReadLine();

            int colonIndex = input.IndexOf(':');
            if (colonIndex == -1)
            {
                Console.WriteLine("Символ ':' не найден в строке.");
            }
            else
            {
                Console.WriteLine($"Количество символов перед ':': {colonIndex}");
            }

            WaitForAnyKey();
        }
    }
}