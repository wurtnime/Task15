using System;
using System.Linq;

namespace CharTasksApp.Tasks
{
    public class Task29 : TaskBase
    {
        public override void Run()
        {
            Console.Clear();
            Console.WriteLine("Задание 29: Введите массив символов, состоящий из английских слов и пробелов. Упорядочить данный массив английских слов по алфавиту.");

            Console.WriteLine("Введите английский текст:");
            string input = Console.ReadLine();

            var words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(words, StringComparer.OrdinalIgnoreCase);

            Console.WriteLine("Отсортированные слова:");
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

            WaitForAnyKey();
        }
    }
}