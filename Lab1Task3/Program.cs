using System;
using Parse;
namespace Lab1Task3
{
    internal class Program
    {
        public static void triangle(int n)
        {
            int space = (n * 2) - 1;
            int starsfirst = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < space; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < starsfirst; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                space--;
                starsfirst += 2;
            }
            return;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("сколько будет строк?");
            int n;
            n = TryParse.IntTryParse();
            triangle(n);
        }
    }
}