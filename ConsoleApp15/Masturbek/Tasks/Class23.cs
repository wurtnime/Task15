using System;

namespace CharTasksApp.Tasks
{
    public class Task23 : TaskBase
    {
        public override void Run()
        {
            Console.Clear();
            Console.WriteLine("Задание 23: Дана матрица символов размером 3×4. Сколько раз среди данных символов встречаются цифры? Заменить цифры на символ !.");

            char[,] matrix = new char[3, 4];
            int digitCount = 0;

            Console.WriteLine("Введите матрицу 3x4:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrix[i, j] = Console.ReadKey().KeyChar;
                    Console.Write(" ");

                    if (char.IsDigit(matrix[i, j]))
                    {
                        digitCount++;
                        matrix[i, j] = '!';
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Найдено цифр: {digitCount}");
            Console.WriteLine("Матрица после замены:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            WaitForAnyKey();
        }
    }
}