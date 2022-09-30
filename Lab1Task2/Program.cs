using System;
using Parse;
namespace Lab1Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("сколько будет строк?");
            int n;
            n = AllParse.IntParse();
            for (int i = 1; i <= n; i++)
            {
                for (int c = 1; c <= i; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}