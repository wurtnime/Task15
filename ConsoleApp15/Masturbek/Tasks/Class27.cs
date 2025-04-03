using System;

namespace CharTasksApp.Tasks
{
    public class Task27 : TaskBase
    {
        public override void Run()
        {
            Console.Clear();
            Console.WriteLine("Задание 27: Дана матрица символов размером 5×5. Определить символ с наибольшим кодом.");

            char[,] matrix = new char[5, 5];
            char maxChar = char.MinValue;

            Console.WriteLine("Введите матрицу 5x5:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = Console.ReadKey().KeyChar;
                    Console.Write(" ");

                    if (matrix[i, j] > maxChar)
                    {
                        maxChar = matrix[i, j];
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Символ с наибольшим кодом: '{maxChar}' (код: {(int)maxChar})");

            WaitForAnyKey();
        }
    }
}