using System;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        { int f=0;byte i;
            byte n = byte.Parse(Console.ReadLine());
            if (n >= 2)
            {
                for (i = 1; i <= n;i++)
                { f = f + i * 2; }
                Console.WriteLine($"f={f}");
            }
            else Console.WriteLine("Error");
        }
    }
}
