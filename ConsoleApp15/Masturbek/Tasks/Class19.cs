using System;

namespace CharTasksApp.Tasks
{
    public class Task19 : TaskBase
    {
        public override void Run()
        {
            Console.Clear();
            Console.WriteLine("Задание 19: Дан массив символов. Проверить, одинаковое ли число открывающихся и закрывающихся квадратных скобок в данной строке.");

            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();

            int openBrackets = input.Count(c => c == '[');
            int closeBrackets = input.Count(c => c == ']');

            Console.WriteLine($"Открывающихся скобок: {openBrackets}, закрывающихся: {closeBrackets}");
            Console.WriteLine(openBrackets == closeBrackets ? "Число скобок одинаковое" : "Число скобок разное");

            WaitForAnyKey();
        }
    }
}