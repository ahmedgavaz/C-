using System;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            while (a!=b)
            { if (a > b) a = a - b;
                if (b > a) b = b - a;
            }
            Console.WriteLine(a);
        }
    }
}
