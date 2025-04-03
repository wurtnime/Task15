using System;

namespace CharTasksApp.Tasks
{
    public class Task2 : TaskBase
    {
        public override void Run()
        {
            Console.Clear();
            Console.WriteLine("Задание 2: Введите массив символов из 11 элементов. Переведите все строчные буквы-символы в верхний регистр.");

            char[] array = new char[11];
            Console.WriteLine("Введите 11 символов:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (char.IsLower(array[i]))
                {
                    array[i] = char.ToUpper(array[i]);
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