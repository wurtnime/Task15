using System;

namespace CharTasksApp.Tasks
{
    public class Task6 : TaskBase
    {
        public override void Run()
        {
            Console.Clear();
            Console.WriteLine("Задание 6: Дана матрица символов размером 2×6. Сколько раз среди данных символов встречаются символы +, -, *.");

            char[,] matrix = new char[2, 6];
            int plusCount = 0, minusCount = 0, starCount = 0;

            Console.WriteLine("Введите матрицу 2x6:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    matrix[i, j] = Console.ReadKey().KeyChar;
                    Console.Write(" ");

                    switch (matrix[i, j])
                    {
                        case '+': plusCount++; break;
                        case '-': minusCount++; break;
                        case '*': starCount++; break;
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Результат: + встречается {plusCount} раз, - встречается {minusCount} раз, * встречается {starCount} раз");

            WaitForAnyKey();
        }
    }
}