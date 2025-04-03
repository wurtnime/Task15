using System;
using System.Text;

namespace CharTasksApp.Tasks
{
    public class Task24 : TaskBase
    {
        public override void Run()
        {
            Console.Clear();
            Console.WriteLine("Задание 24: Дана матрица символов размером 5×5. Создать строку только из латинских букв.");

            char[,] matrix = new char[5, 5];
            StringBuilder latinLetters = new StringBuilder();

            Console.WriteLine("Введите матрицу 5x5:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = Console.ReadKey().KeyChar;
                    Console.Write(" ");

                    if ((matrix[i, j] >= 'a' && matrix[i, j] <= 'z') ||
                        (matrix[i, j] >= 'A' && matrix[i, j] <= 'Z'))
                    {
                        latinLetters.Append(matrix[i, j]);
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Строка из латинских букв: {latinLetters.ToString()}");

            WaitForAnyKey();
        }
    }
}