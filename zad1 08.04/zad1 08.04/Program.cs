using System;

namespace zad1_08._04
{
    class Program
    {
        static void Main(string[] args)
        { bool c = false;
            Console.WriteLine("a=");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            double b = double.Parse(Console.ReadLine());
            if (a==0.3 && b==-1.6 && Math.Pow(a, 2)+Math.Pow(b, 2)<= 4)
                    {c = true;}
           Console.Write(c);
        }
    }
}
