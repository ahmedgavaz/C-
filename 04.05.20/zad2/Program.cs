using System;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte br=0;
           int a = int.Parse(Console.ReadLine());
           int b = int.Parse(Console.ReadLine());
           int k = int.Parse(Console.ReadLine());

            if (a < b)
            { for (int i =a; i <= b; i++)
                { if (k%i==0)
                    {
                        br++;
                        
                    }
                }
                Console.WriteLine($"Br={br}");
            }
            else Console.WriteLine("Error");
        }
    }
}
