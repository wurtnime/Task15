using System;

namespace CharTasksApp.Tasks
{
    public class Task20 : TaskBase
    {
        public override void Run()
        {
            Console.Clear();
            Console.WriteLine("Задание 20: Дана матрица символов размером 3×4. Подсчитать, сколько раз среди символов строки встречается символ @.");

            char[,] matrix = new char[3, 4];
            int totalCount = 0;

            Console.WriteLine("Введите матрицу 3x4:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrix[i, j] = Console.ReadKey().KeyChar;
                    Console.Write(" ");

                    if (matrix[i, j] == '@')
                    {
                        totalCount++;
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Символ '@' встречается {totalCount} раз");

            WaitForAnyKey();
        }
    }
}