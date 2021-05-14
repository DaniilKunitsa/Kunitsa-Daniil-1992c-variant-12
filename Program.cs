using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Куница_Даниил_1992с_Вариант_12
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] array = new double[1000, 1000];
            MainMethods.FillArray(array);
            MainMethods.WriteArray(array);
            Console.WriteLine($"\nМаксимальный элемент выше главной диагонали: {MainMethods.FindMax(array)}");
            Console.ReadKey();
        }
    }
}
