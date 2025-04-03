using System;

namespace CharTasksApp.Tasks
{
    public class Task1 : TaskBase
    {
        public override void Run()
        {
            Console.Clear();
            Console.WriteLine("Задание 1: Введите массив символов из 10 элементов. Замените символы-цифры на символ '*'.");

            char[] array = new char[10];
            Console.WriteLine("Введите 10 символов:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (char.IsDigit(array[i]))
                {
                    array[i] = '*';
                }
            }

            Console.WriteLine("Измененный массив:");
            foreach (char c in array)
            {
                Console.Write(c + " ");
            }

            WaitForAnyKey();
        }
    }
}