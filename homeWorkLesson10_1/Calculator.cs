using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson10_1
{
    static class Calculator
    {
        public static double Plus(double a, double b)
        {
            return a + b;
        }
        public static double Substract(double a, double b)
        {
            return a - b;
        }
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        public static double Divide(double a, double b)
        {
            return a / b;
        }
        public static bool TryDivide(double a, double b, out double result)
        {
            if (b.Equals(0.0))
            {
                result = 0.0;
                return false;
            }
            else
            {
                result = Divide(a, b);
                return true;
            }
        }
        public static double RemainderDivision(double a, double b)
        {
            return a % b;
        }
    }
}
