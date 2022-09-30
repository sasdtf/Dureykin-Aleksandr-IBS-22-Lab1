using System;
using Parse;
namespace Lab1Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            byte firstValue = AllParse.ByteParse();
            Console.WriteLine("Введите втрое число:");
            byte secondValue = AllParse.ByteParse();
            Console.WriteLine("" +
            "Побитовое И чисел {0} {1} - {2}\n" +
            "Побитовое ИЛИ чисел {0} {1} - {3}\n" +
            "побитовое исключающее ИЛИ чисел {0} {1} - {4}",
            firstValue, secondValue, firstValue & secondValue, firstValue | secondValue, firstValue ^ secondValue);
        }
    }
}