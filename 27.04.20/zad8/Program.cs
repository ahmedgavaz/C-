using System;

namespace zad8
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = double.Parse(Console.ReadLine());
            double u = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            double a, b;
           if (d <= 6000 && d >= 0 && u >= 2 && u <= 6 && z >= 0 && z <= 1000)
           {
                if (d > z && u < 4.5) Console.WriteLine("You cannot get a scholarship!");
                else if (d < z && u > 4.5 && u < 5.5)
                {
                    a = z * 0.35;
                    a = Math.Floor(a);
                    Console.WriteLine($"You get a Social scholarship {a} BGN");
                }
                else if (u > 5.49 && d >= z)
                {
                    a = u * 25;
                    a = Math.Floor(a);
                    Console.WriteLine($"You get a scholarship for excellent results {a} BGN");
                }
                else if (u > 5.49 && d < z)
                {
                    a = z * 0.35;
                    b = u * 25;
                    b = Math.Floor(b);
                    a = Math.Floor(a);
                    if (a > b)
                    {
                        
                        Console.WriteLine($"You get a Social scholarship {a} BGN");
                    }
                    else
                    {
                        
                        Console.WriteLine($"You get a scholarship for excellent results {b} BGN");
                    }
                }
                else Console.WriteLine("You cannot get a scholarship!"); 
                
            }
        }
    }
}