using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4New
{
    class Day3_F_6
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Enter the Matriculation Number : ");
                String input = Console.ReadLine();
                input = input.Trim();
                char[] checksum = new char[] { 'O', 'P', 'Q', 'R','S' };
                char[] temp = input.ToArray();
                int check=0;
                if (temp[0] == 'A' && temp.Length==7)
                {
                    int j = 6;
                    for(int i = 1; i < temp.Length-1; i++)
                    {
                        check += temp[i] * j--;
                    }
                    check = check % 5;
                    if (temp[6] == checksum[check])
                        Console.WriteLine("\n\nNumber Accepted ----Valid \n\n");
                    else
                        Console.WriteLine("\n\nNumber Not Accepted ----Invalid\n\n");
                }
                else
                    Console.WriteLine("\n\nNumber Not Accepted ----Invalid\n\n");

            }       
        }
    }
}
