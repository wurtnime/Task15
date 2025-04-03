using System;

namespace CharTasksApp.Tasks
{
    public class Task3 : TaskBase
    {
        public override void Run()
        {
            Console.Clear();
            Console.WriteLine("Задание 3: Введите массив символов из 12 элементов. Замените каждый символ-цифру на символ '!'.");

            char[] array = new char[12];
            Console.WriteLine("Введите 12 символов:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (char.IsDigit(array[i]))
                {
                    array[i] = '!';
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