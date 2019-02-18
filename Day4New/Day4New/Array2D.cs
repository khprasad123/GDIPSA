using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4New
{
    class Array2D
    {
        static void Main()
        {
            int[,] arr = new int[,] { { 1, 2 }, { 2, 6 }, { 6, 8 } };
            Print2Array(arr);
        }
        static void Print2Array(int [,] arr)
        {
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(" " + arr[i,j] + " ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
