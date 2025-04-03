using System;

namespace CharTasksApp.Tasks
{
    public class Task5 : TaskBase
    {
        public override void Run()
        {
            Console.Clear();
            Console.WriteLine("Задание 5: Введите массив символов из 15 элементов. Измените регистр символа: прописные заменить на строчные, а строчные на прописные.");

            char[] array = new char[15];
            Console.WriteLine("Введите 15 символов:");
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
                else if (char.IsUpper(array[i]))
                {
                    array[i] = char.ToLower(array[i]);
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