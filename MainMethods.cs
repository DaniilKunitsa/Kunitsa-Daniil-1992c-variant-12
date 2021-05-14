using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Куница_Даниил_1992с_Вариант_12
{
    public static class MainMethods
    {
        private static Random rnd = new Random();

        public static void FillArray(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(10, 100);
                }
            }
        }
    }
}
