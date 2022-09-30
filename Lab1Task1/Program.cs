using System;
using Parse;
namespace Lab1Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double s;
            Console.WriteLine("a=");
            a = AllParse.DoubleParse();
            if (a <= 0)
            {
                Console.WriteLine("неверное значение a");
                return;
            }
            Console.WriteLine("b=");
            b = AllParse.DoubleParse();
            if (b <= 0)
            {
                Console.WriteLine("неверное значение b");
                return;
            }
            s = a * b;
            Console.WriteLine("s=" + s);
        }
    }
}