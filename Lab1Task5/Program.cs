using System;
using Parse;
namespace Lab1Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = 1000;
            int sum = 0;
            for (int i = 0; i < max; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}