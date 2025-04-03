using System;

namespace CharTasksApp.Tasks
{
    public class Task30 : TaskBase
    {
        public override void Run()
        {
            Console.Clear();
            Console.WriteLine("Задание 30: Дана матрица символов размером 5×7. Определить сумму цифр в матрице.");

            char[,] matrix = new char[5, 7];
            int sum = 0;

            Console.WriteLine("Введите матрицу 5x7:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    matrix[i, j] = Console.ReadKey().KeyChar;
                    Console.Write(" ");

                    if (char.IsDigit(matrix[i, j]))
                    {
                        sum += int.Parse(matrix[i, j].ToString());
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Сумма цифр в матрице: {sum}");

            WaitForAnyKey();
        }
    }
}