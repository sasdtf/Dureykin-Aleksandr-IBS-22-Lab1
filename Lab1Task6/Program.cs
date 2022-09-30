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
            a = AllParse.DoubleParse();
            Console.Write("b=");
            b = AllParse.DoubleParse();
            Console.Write("c=");
            c = AllParse.DoubleParse();
            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.Write("сторона не может быть отрицательной или равной нулю");
                return;
            }
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