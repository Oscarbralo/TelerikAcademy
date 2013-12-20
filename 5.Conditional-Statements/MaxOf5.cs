//Write a program that finds the greatest of given 5 variables.

using System;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());
            int four = int.Parse(Console.ReadLine());
            int five = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Max(one, Math.Max(two, Math.Max(three, Math.Max(four, five)))));
        }
    }
}
