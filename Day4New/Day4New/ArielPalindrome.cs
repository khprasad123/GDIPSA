using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4New
{
    class ArielPalindrome
    {
        static void Main()
        {
            Console.Write("Please give me a phrase: ");
            string s = Console.ReadLine();
            int t = s.Length-1;


            for (int i = 0;i < s.Length; i++)
            {
                if (s.Substring(i, 1) != s.Substring(t, 1))
                {
                    Console.WriteLine(s + "  "+" is not palindrome\n\n");
                    return;
                }

                t = t - 1;
                    
            }

            Console.WriteLine(s+ "  "+"Is palindrome \n\n"); 

        }
    }
}
