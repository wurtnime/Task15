using System;

namespace CharTasksApp.Tasks
{
    public class Task22 : TaskBase
    {
        public override void Run()
        {
            Console.Clear();
            Console.WriteLine("Задание 22: Введите массив символов из 12 элементов. Удвоить все коды символов массива.");

            char[] array = new char[12];
            int[] doubledCodes = new int[12];

            Console.WriteLine("Введите 12 символов:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Console.ReadKey().KeyChar;
                Console.WriteLine();
                doubledCodes[i] = array[i] * 2;
            }

            Console.WriteLine("Удвоенные коды символов:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]}: {doubledCodes[i]}");
            }

            WaitForAnyKey();
        }
    }
}