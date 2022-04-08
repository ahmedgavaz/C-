using System;

namespace zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = byte.Parse(Console.ReadLine());
            int b = byte.Parse(Console.ReadLine());
            if (b>44)
            { if (a < 23)
                {
                    a = a + 1;
                    b = b - 45;
                }
            else 
                { a = 0;
                    b = b - 45;
                }
            }
            else  b = b + 15;
            if (b<10) Console.WriteLine($"{a}:0{b}");
            else Console.WriteLine($"{a}:{b}");
        }
    }
}
