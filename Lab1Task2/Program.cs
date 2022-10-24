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
            n = TryParse.IntTryParse();
            for (int i = 0; i < n; i++)
            {
                for (int c = 0; c < i; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}