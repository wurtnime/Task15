using System;
using System.Linq;

namespace CharTasksApp.Tasks
{
    public class Task9 : TaskBase
    {
        public override void Run()
        {
            Console.Clear();
            Console.WriteLine("Задание 9: Дан массив символов, содержащий английский текст. Найти количество слов, начинающихся с буквы b.");

            Console.WriteLine("Введите английский текст:");
            string input = Console.ReadLine();

            var words = input.Split(new[] { ' ', '.', ',', '!', '?', ';', ':', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int count = words.Count(w => w.StartsWith("b", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine($"Количество слов на 'b': {count}");

            WaitForAnyKey();
        }
    }
}