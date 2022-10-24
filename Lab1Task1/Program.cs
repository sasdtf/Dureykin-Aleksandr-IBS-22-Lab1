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
            a = TryParse.DoubleTryParse();
            Console.WriteLine("b=");
            b = TryParse.DoubleTryParse();
            s = a * b;
            Console.WriteLine("s=" + s);
        }
    }
}