using System;

namespace CharTasksApp.Tasks
{
    public class Task17 : TaskBase
    {
        public override void Run()
        {
            Console.Clear();
            Console.WriteLine("Задание 17: Дан массив символов, в котором есть один символ $. Подсчитать количество символов до этого символа и после него.");

            Console.WriteLine("Введите строку, содержащую символ '$':");
            string input = Console.ReadLine();

            int dollarIndex = input.IndexOf('$');
            if (dollarIndex == -1)
            {
                Console.WriteLine("Символ '$' не найден в строке.");
            }
            else
            {
                int before = dollarIndex;
                int after = input.Length - dollarIndex - 1;
                Console.WriteLine($"Символов до '$': {before}, после '$': {after}");
            }

            WaitForAnyKey();
        }
    }
}