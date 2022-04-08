using System;

namespace zad8
{
    class Program
    {
        static void Main(string[] args)
        {
            double m= double.Parse(Console.ReadLine());
            double pr = m * 7.61;
            double dis = pr - pr * 0.82;
            pr =pr*0.82;
            Console.WriteLine($"The final price is: {pr:f2} lv.");
            Console.WriteLine($"The discount is: {dis:f2} lv.");


        }
    }
}
