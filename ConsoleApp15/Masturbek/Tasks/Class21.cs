using System;

namespace CharTasksApp.Tasks
{
    public class Task21 : TaskBase
    {
        public override void Run()
        {
            Console.Clear();
            Console.WriteLine("Задание 21: Дана матрица символов размером 5×4. Сколько раз среди данных символов встречается символ + и сколько раз символ *.");

            char[,] matrix = new char[5, 4];
            int plusCount = 0, starCount = 0;

            Console.WriteLine("Введите матрицу 5x4:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrix[i, j] = Console.ReadKey().KeyChar;
                    Console.Write(" ");

                    switch (matrix[i, j])
                    {
                        case '+': plusCount++; break;
                        case '*': starCount++; break;
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Результат: + встречается {plusCount} раз, * встречается {starCount} раз");

            WaitForAnyKey();
        }
    }
}