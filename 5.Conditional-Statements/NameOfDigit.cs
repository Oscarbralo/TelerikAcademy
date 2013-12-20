//Write program that asks for a digit and depending on the input shows the name of that digit (in English) using a switch statement.

using System;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = int.Parse(Console.ReadLine());
            string[] res = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            while (choice > 9)
            {
                Console.WriteLine("Enter a digit between 0 and 9.");
                choice = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(res[choice]);
        }
    }
}
