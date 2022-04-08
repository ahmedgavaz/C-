using System;

namespace zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a < 100) Console.WriteLine("Less than 100");
            else if (a > 99 && a < 201) Console.WriteLine("Between 100 and 200");
            else Console.WriteLine("Greater than 200");

        }
    }
}
