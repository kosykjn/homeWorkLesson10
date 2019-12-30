using System;

namespace homeWorkLesson10_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string valueString = "test test vasya  petya 111";
            int startIndex = 3;   
            Console.WriteLine(valueString.CountOfSymbols(startIndex));
            Console.WriteLine(valueString.CountOfWords());

            Console.ReadKey();
        }
    }
}
