using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4New
{
    class Palindrome
    {
        static void Main()
        {
            while (true)
            {
                string input = Console.ReadLine();
                string temp = "",temp1=input;
                char[] set=new char[] {' ','*','.'};
                string[] word_set = input.Split(set);
                foreach(string t in word_set)
                {
                    temp += t;
                }
                input = temp;
                bool f=isPalindrome(input);
                if (f)
                    Console.WriteLine(temp1 + " is Palindrome");
                else
                    Console.WriteLine(temp1 + " is not a Palindrome");
            }
        }
        static bool isPalindrome(string input)
        {
            input = input.ToLower();
            for (int i = 0,j=input.Length;j>0&&i < input.Length; i++)
            {
                 if (input.Substring(i, 1) != input.Substring(--j, 1))
                    return false;
            }
            return true;
        }
    }
}
