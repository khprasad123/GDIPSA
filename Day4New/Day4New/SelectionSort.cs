using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4New
{
    class SelectionSort
    {
        static void Main()
        {
            int[] arr = new int[] { 3, 9, 5, 6, 1, 2, 4 };
            //selection sort
            PrintArray(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;
                    }
                }
            }
            PrintArray(arr);
        }
        static void PrintArray(int[] arr)
        {
            Console.Write("{ ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i] + " ");
            }
            Console.WriteLine(" }");
        }
    }
}
