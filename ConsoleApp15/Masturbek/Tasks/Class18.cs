using System;
using System.Collections.Generic;
using System.Linq;

namespace CharTasksApp.Tasks
{
    public class Task18 : TaskBase
    {
        public override void Run()
        {
            Console.Clear();
            Console.WriteLine("Задание 18: Из заданной символьной строки выбрать те символы, которые встречаются в ней только один раз, в том порядке, в котором они встречаются в тексте.");

            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();

            Dictionary<char, int> charCounts = new Dictionary<char, int>();
            List<char> uniqueChars = new List<char>();

            foreach (char c in input)
            {
                if (charCounts.ContainsKey(c))
                {
                    charCounts[c]++;
                }
                else
                {
                    charCounts[c] = 1;
                    uniqueChars.Add(c);
                }
            }

            var result = uniqueChars.Where(c => charCounts[c] == 1).ToList();

            Console.WriteLine("Символы, встречающиеся один раз:");
            foreach (char c in result)
            {
                Console.Write(c + " ");
            }

            WaitForAnyKey();
        }
    }
}