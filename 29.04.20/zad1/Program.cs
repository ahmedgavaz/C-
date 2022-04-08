using System;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
                if (x > 0) 
            { if (y > 0) Console.WriteLine("Pyrvi");
                else if (y == 0) Console.WriteLine("Nulev");
                else Console.WriteLine("Chetvyrti"); 
            }
              else  if (x<0)
            {
                if (y > 0) Console.WriteLine("Vtori");
                else if (y == 0) Console.WriteLine("Nulev");
                else Console.WriteLine("Treti");
            }
            else Console.WriteLine("Nulev");
        }
    }
}
