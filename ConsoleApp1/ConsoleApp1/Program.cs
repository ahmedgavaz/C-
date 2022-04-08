using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3; int b = 5;
            int c = a + b++;
            int t = a + (++b);
            a--;b++;c = a++ + b;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(t);
        }
    }
}
