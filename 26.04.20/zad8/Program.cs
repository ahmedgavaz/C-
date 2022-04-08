using System;

namespace zad8
{
    class Program
    {
        static void Main(string[] args)
        {
            double hp = double.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            double s = a * 2.6 + b * 3 + c * 4.1 + d * 8.2 + e * 2;
            if (a + b + c + d + e > 49) s = s * 0.75;
            s = s * 0.9;
            double x = Math.Abs(s - hp);
            if (hp <= s) Console.WriteLine($"Yes! {x:f2} lv left.");
            else Console.WriteLine($"Not enough money! {x:f2} lv needed.");
        }
    }
}
