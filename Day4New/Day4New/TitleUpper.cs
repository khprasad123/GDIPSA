using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4New
{
    class TitleUpper
    {
        static void Main()
        {
            while (true)
            {
                string input = Console.ReadLine();
                string[] temp = input.Split(' ');
                input = "";
                foreach(string t in temp)
                {
                    for(int i = 0; i < t.Length; i++)
                    {
                        if (i == 0)
                            input += char.ToUpper(t[0]);
                        else
                            input += t[i];
                    }
                    input += " ";
                }
                Console.WriteLine(input); 
            }
        }
    }
}
