using System;
using System.Threading.Tasks;
using CharTasksApp.Tasks;

// Ayy, VIPERR motion,xa,outside

namespace CharTasksApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Практическая №15");
                Console.WriteLine("Выберите задание 1-30:");

                if (!int.TryParse(Console.ReadLine(), out int taskNumber))
                {
                    Console.WriteLine("Некорректный ввод. Нажмите любую клавишу...");
                    Console.ReadKey();
                    continue;
                }

                if (taskNumber == 0) break;

                try
                {
                    var task = TaskFactory.CreateTask(taskNumber);
                    task.Run();
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Задание с таким номером не найдено. Нажмите любую клавишу...");
                    Console.ReadKey();
                }
            }
        }
    }

    public static class TaskFactory
    {
        public static TaskBase CreateTask(int taskNumber)
        {
            return taskNumber switch
            {
                1 => new Task1(),
                2 => new Task2(),
                3 => new Task3(),
                4 => new Task4(),
                5 => new Task5(),
                6 => new Task6(),
                7 => new Task7(),
                8 => new Task8(),
                9 => new Task9(),
                10 => new Task10(),
                11 => new Task11(),
                12 => new Task12(),
                13 => new Task13(),
                14 => new Task14(),
                15 => new Task15(),
                16 => new Task16(),
                17 => new Task17(),
                18 => new Task18(),
                19 => new Task19(),
                20 => new Task20(),
                21 => new Task21(),
                22 => new Task22(),
                23 => new Task23(),
                24 => new Task24(),
                25 => new Task25(),
                26 => new Task26(),
                27 => new Task27(),
                28 => new Task28(),
                29 => new Task29(),
                30 => new Task30(),
                _ => throw new ArgumentException("Invalid task number")
            };
        }
    }

    public abstract class TaskBase
    {
        public abstract void Run();

        protected void WaitForAnyKey()
        {
            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
    }
}