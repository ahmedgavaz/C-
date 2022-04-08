using System;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n = 10; 
            int[] array = new int[n]; 
            for (i = 0; i < n; i++)
            { array[i] = int.Parse(Console.ReadLine()); }
            for (i = n - 1; i >= 0; i--) 
            { Console.WriteLine(array[i]); }
        }
    }
}
