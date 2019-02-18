using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4New
{
    class Prime
    {
        static void Main()
        {
            while (true)
            {
                double num = double.Parse(Console.ReadLine());
                Console.WriteLine(isPrime(num));
            }
        }
        static string isPrime(double n)
        {
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                    return "Not Prime";
            }
            return "Prime";
        }

    }
}
