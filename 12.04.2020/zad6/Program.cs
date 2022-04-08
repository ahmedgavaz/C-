using System;

namespace zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            byte kuche = byte.Parse(Console.ReadLine());
            byte kote = byte.Parse(Console.ReadLine());
            double x = kuche*2.5 + kote*4;
            Console.WriteLine($"{x:f2} lv.");
        }
    }
}
