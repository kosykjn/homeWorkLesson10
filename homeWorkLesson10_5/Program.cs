using System;

namespace homeWorkLesson10_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var point1 = new Point3D(10.0, 10.0, 10.0);
            var point2 = new Point3D(20.0, 20.0, 20.0);

            Console.WriteLine("point1 + point2 = {0}", point1 + point2);
            Console.WriteLine("point1 - point2 = {0}", point1 - point2);
            Console.WriteLine("point1 * point2 = {0}", point1 * point2);
            Console.WriteLine("point1 / point2 = {0}", point1 / point2); 

            Console.ReadKey();
        }
    }
}
