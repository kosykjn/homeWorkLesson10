using System;

namespace homeWorkLesson10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое значение:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе значение:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите знак арифметической операции:");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    Console.WriteLine($"Результат: {Calculator.Plus(a, b)}");
                    break;
                case "/":
                    if (Calculator.TryDivide(a, b, out double divideResult))
                    {
                        Console.WriteLine($"Результат: {divideResult: 0.##}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка операции деления!");
                    }
                    break;
                case "-":
                    Console.WriteLine($"Результат: {Calculator.Substract(a, b)}");
                    break;
                case "*":
                    Console.WriteLine($"Результат: {Calculator.Multiply(a, b)}");
                    break;
                case "%":
                    Console.WriteLine($"Результат: {Calculator.RemainderDivision(a, b)}");
                    break;
                default:
                    Console.WriteLine("Нет такого арифметического знака!");
                    break;
            }
            
            Console.ReadKey();
        }
    }
}
