using System;

namespace CharTasksApp.Tasks
{
    public class Task10 : TaskBase
    {
        public override void Run()
        {
            Console.Clear();
            Console.WriteLine("Задание 10: Дан массив символов. Подсчитать, сколько в нем букв r, k, t.");

            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();

            int rCount = 0, kCount = 0, tCount = 0;

            foreach (char c in input)
            {
                switch (char.ToLower(c))
                {
                    case 'r': rCount++; break;
                    case 'k': kCount++; break;
                    case 't': tCount++; break;
                }
            }

            Console.WriteLine($"Результат: r={rCount}, k={kCount}, t={tCount}");

            WaitForAnyKey();
        }
    }
}