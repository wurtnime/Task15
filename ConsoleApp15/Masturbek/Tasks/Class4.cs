using System;

namespace CharTasksApp.Tasks
{
    public class Task4 : TaskBase
    {
        public override void Run()
        {
            Console.Clear();
            Console.WriteLine("Задание 4: Ввести массив из 10 символов. Если символ массива является прописной буквой латинского алфавита, замените символ, стоящий перед прописной буквой на пробел.");

            char[] array = new char[10];
            Console.WriteLine("Введите 10 символов:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] >= 'a' && array[i] <= 'z')
                {
                    array[i - 1] = ' ';
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