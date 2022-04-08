using System;

namespace zad4
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("dyljina=");  double a = int.Parse(Console.ReadLine());
            Console.WriteLine("shirina="); double b = int.Parse(Console.ReadLine());
            Console.WriteLine("cena="); double c = int.Parse(Console.ReadLine());
            if (a < 0 && b < 0 && c < 0) Console.WriteLine("Error");
            else { double sum = a * b * c;
                Console.WriteLine($"cenata e {sum}");
            }
               
        }
    }
}
