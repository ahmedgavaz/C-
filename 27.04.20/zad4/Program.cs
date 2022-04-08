using System;

namespace zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string t = Console.ReadLine();
            double b=a;
            if (s=="mm")
            { if (t == "cm") b = a / 10;
                if (t == "m") b = a / 1000;
            }
           else if (s == "cm")
            {
                if (t == "mm") b = a * 10;
                if (t == "m") b = a / 100;
            }
            else if (s == "m")
            {
                if (t == "cm") b = a * 100;
                if (t == "mm") b = a * 1000;
            }
            else Console.WriteLine("Error");
            Console.WriteLine($"{b:f3}");

        }
    }
}
