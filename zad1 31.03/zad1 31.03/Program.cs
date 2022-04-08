using System;

namespace zad1_31._03
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b; string s;
            s = Console.ReadLine();a = int.Parse(s);
            s = Console.ReadLine(); b = int.Parse(s);
            Console.WriteLine("Старо а={0}, старо b={1}",a,b);
            a = a + b; b = a - b;a = a - b;
            Console.WriteLine("Ново а={0}, ново b={1}", a, b);
        }
    }
}
