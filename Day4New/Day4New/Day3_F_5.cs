using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4New
{
    class Day3_F_5
    {
        static void Main()
        {
            string[] name = new string[] { "john", "venkat", "mary", "victor", "betty" };
            int[] marks = new int[] { 63, 29, 75, 82, 55 };
           

            PrintArray(marks, name);
            Console.WriteLine("Report 1 : BY MARKS ");
            SortMarks(ref marks, ref name);
            PrintArray(marks, name);

            Console.WriteLine("Report 2 : BY NAME ");
            SortName(ref marks, ref name);
            PrintArray(marks, name);

        }
        static void PrintArray(int [] m,string[] n)
        {
            for (int i = 0; i < m.Length; i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}", i+1, n[i], m[i]);
            }
            Console.Write("\n\n");
        }
        static void SortMarks(ref int[] m,ref string[] n)
        {
            for(int i = 0; i < m.Length; i++)
            {
                for(int j = i+1; j < m.Length; j++)
                {
                    if (m[i] > m[j])
                    {
                        swapNum(ref m[i], ref m[j]);
                        swapString(ref n[i], ref n[j]);
                    }
                }
            }
        }
        static void SortName(ref int[] m, ref string[] n)
        {
            for (int i = 0; i < n.Length; i++)
            {
                for (int j = i + 1; j < n.Length; j++)
                {
                    if (n[i].CompareTo(n[j])>0)
                    {
                        swapNum(ref m[i], ref m[j]);
                        swapString(ref n[i], ref n[j]);
                    }
                }
            }
        }

        static void swapNum(ref int i,ref int j)
        {
            int t = i;
            i = j;
            j = t;
        }
        static void  swapString(ref string i,ref string j)
        {
            string t = i;
            i = j;
            j = t;
        }
    }
}
