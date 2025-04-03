using System;

namespace CharTasksApp.Tasks
{
    public class Task26 : TaskBase
    {
        public override void Run()
        {
            Console.Clear();
            Console.WriteLine("Задание 26: Дана матрица символов размером 4×4. Определить сумму кодов символов элементов главной диагонали.");

            char[,] matrix = new char[4, 4];
            int sum = 0;

            Console.WriteLine("Введите матрицу 4x4:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrix[i, j] = Console.ReadKey().KeyChar;
                    Console.Write(" ");

                    if (i == j) 
                    {
                        sum += matrix[i, j];
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Сумма кодов символов главной диагонали: {sum}");

            WaitForAnyKey();
        }
    }
}