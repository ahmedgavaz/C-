using System;

namespace zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            if (s == "s3cr3t!P@ssw0rd") Console.WriteLine("Welcome");
            else Console.WriteLine("Wrong password!");
        }
    }
}
