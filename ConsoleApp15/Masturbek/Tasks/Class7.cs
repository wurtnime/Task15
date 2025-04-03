using System;

namespace CharTasksApp.Tasks
{
    public class Task7 : TaskBase
    {
        public override void Run()
        {
            Console.Clear();
            Console.WriteLine("Задание 7: Введите массив символов из 15 элементов. Подсчитать количество гласных русских букв.");

            char[] array = new char[15];
            char[] vowels = { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я', 'А', 'Е', 'Ё', 'И', 'О', 'У', 'Ы', 'Э', 'Ю', 'Я' };
            int count = 0;

            Console.WriteLine("Введите 15 символов:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (Array.IndexOf(vowels, array[i]) >= 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"Количество гласных русских букв: {count}");

            WaitForAnyKey();
        }
    }
}