using System;

namespace zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            string f = Console.ReadLine();
            double area = 0;
            if (f == "square")
            {
                double side = double.Parse(Console.ReadLine());
                area = side * side;
            }
            else if (f == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b;
            }
            else if (f == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                area = r * r * Math.PI;
            }
            else if (f == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                area = a * h / 2;
            }
            Console.WriteLine($"{area:f3}");
        }
    }
}
