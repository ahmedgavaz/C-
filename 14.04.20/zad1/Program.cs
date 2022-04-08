using System;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double length = Math.Abs(x1 - x2);
            double width = Math.Abs(y1 - y2);
            double area = width * length;
            double perimeter = 2 * (width + length);
            Console.WriteLine($"{area:f2}");
            Console.WriteLine($"{perimeter:f2}");

        }
    }
}
