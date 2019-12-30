using System;

namespace homeWorkLesson10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение в Цельсиях:");
            double userCelsiusValue = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Ваше значение в Фаренгейтах {Converter.CelsiusToFahrenheit(userCelsiusValue)}");

            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Введите значение в Фаренгейтах:");
            double userValueFahrenheit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Ваше значение в Цельсиях {Converter.FahrenheitToCelsius(userValueFahrenheit): 0.#} ");

            Console.ReadKey();
        }
    }
}
