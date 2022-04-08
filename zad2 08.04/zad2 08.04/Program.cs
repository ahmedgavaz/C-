using System;

namespace zad2_08._04
{
    class Program
    {
        static void Main(string[] args)
        { bool bol,a,b,c;
            a = true;b = false;
            Console.WriteLine("k=");
            int k = int.Parse(Console.ReadLine());
            if ((k % 7) == ((k % 5) - 1))
                 { bol = true; }
            else { bol = false; }
            Console.WriteLine("A)= {0}",bol);
            c= (a || b && !a);
            Console.WriteLine("Б)={0}", c);
        }
    }
}
