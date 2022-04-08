using System;

namespace zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            string ime = Console.ReadLine();
            byte project = byte.Parse(Console.ReadLine());
            int pr = project * 3;
            Console.WriteLine($"The architect {ime} will need {pr} hours to complete {project} project/s.");
               
        }
    }
}
