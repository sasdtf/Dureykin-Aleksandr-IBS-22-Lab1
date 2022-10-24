using System;
using Parse;
namespace Lab1Task4
{
    internal class Program
    {
        public static void triangle(int n, int space)
        {
           
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
            int N;
            int space;
            int n = 1;
            Console.Write("сколько треугольников должно быть?");
            N = TryParse.IntTryParse();
            space = N - 1;
            for (int i = 0; i < N; i++)
            {
                triangle(n, space);
                n++;
            }
        }
    }
}