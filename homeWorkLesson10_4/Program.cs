using System;

namespace homeWorkLesson10_4
{
    class Program
    {
        static void ShowHeader(string header, ConsoleColor color)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(new string('-', 22));
            Console.WriteLine($"{header}:");
            Console.WriteLine(new string('-', 22));
            Console.ForegroundColor = oldColor;
        }

        static void Main(string[] args)
        {
            int[] array = ArrayMethods.CreateRandomArray(10, 1, 9);

            ShowHeader("Рандомный массив", ConsoleColor.Red);

            array.Print();
            array.Sort(ArraySortType.Ascending);

            ShowHeader("Отсортированый массив", ConsoleColor.Green);

            array.Print();

            Console.ReadKey();
        }
    }
}
