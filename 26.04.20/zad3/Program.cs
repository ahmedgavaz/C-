﻿using System;

namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0) Console.WriteLine("even");
            else Console.WriteLine("odd");
        }
    }
}
