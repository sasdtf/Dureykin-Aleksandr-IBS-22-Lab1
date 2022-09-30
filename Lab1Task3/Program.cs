using System;
using Parse;
namespace Lab1Task3
{
    internal class Program
    {
        public static void triangle(int n, int space, int starsfirst)
        {
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
            int space; 
            int starsfirst = 1;
            n = AllParse.IntParse();
            space = (n * 2) - 1;
            triangle(n, space, starsfirst);
        }
    }
}