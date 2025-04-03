using System;

namespace CharTasksApp.Tasks
{
    public class Task25 : TaskBase
    {
        public override void Run()
        {
            Console.Clear();
            Console.WriteLine("Задание 25: Дана матрица символов размером 5×5. Упорядочить символы строк по возрастанию их кода.");

            char[,] matrix = new char[5, 5];

            Console.WriteLine("Введите матрицу 5x5:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = Console.ReadKey().KeyChar;
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 5; i++)
            {
                char[] row = new char[5];
                for (int j = 0; j < 5; j++)
                {
                    row[j] = matrix[i, j];
                }
                Array.Sort(row);
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            Console.WriteLine("Отсортированная матрица:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            WaitForAnyKey();
        }
    }
}