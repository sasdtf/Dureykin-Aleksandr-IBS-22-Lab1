using System;
using Parse;
namespace Lab1Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            double s;
            double p;
            Console.Write("a=");
            a = TryParse.DoubleTryParse();
            Console.Write("b=");
            b = TryParse.DoubleTryParse();
            Console.Write("c=");
            c = TryParse.DoubleTryParse();
            
            if (a + b < c || a + c < b || b + c < a)
            {
                Console.Write("треугольник не существует");
                return;
            }
            p = (a + b + c) / 2;
            s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.Write(s);
        }
    }
}