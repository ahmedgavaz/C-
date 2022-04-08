using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Strana 1=");
            double a= double.Parse(Console.ReadLine()); 
            
            Console.WriteLine("Strana 2=");
            
            
            double b= double.Parse(Console.ReadLine()); 
            double s = a * b;
            Console.WriteLine(s);

        }
        
    }
}
