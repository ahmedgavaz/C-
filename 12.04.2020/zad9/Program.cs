using System;

namespace zad9
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            double v = x * y * z * 0.001;
            double pl = v * (1 - p * 0.01);
            Console.WriteLine($"{pl:f3}");
        }
    }
}
