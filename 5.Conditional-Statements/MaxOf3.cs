//Write a program that finds the biggest of three integers using nested if statements.

using System;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Max(first, Math.Max(second, third)).ToString());
        }
    }
}
