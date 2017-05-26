using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLConsole.Problems.Misc
{
    public class FindPower
    {

        //http://www.geeksforgeeks.org/given-p-and-n-find-the-largest-x-such-that-px-divides-n-2/
        //Given an integer n and a prime number p, find the largest x such that p^x (p raised to power x) divides n! (factorial)
        //Examples:
        //Input:  n = 7, p = 3
        //Output: x = 2
        //32 divides 7! and 2 is the largest such power of 3.
        //Input:  n = 10, p = 3
        //Output: x = 4
        //34 divides 10! and 4 is the largest such power of 3.


        public static int FinLargestPow(int n, int p)
        {
            int x = 0;
            FindPower fp = new FindPower();
            int fact = fp.RecursiveFact(n);

            while (n != 0)
            {
                if (fact % Math.Pow(p, n) == 0 && n > x)
                    x = n;
                n--;
            }

            return x;
        }

        public static int largestPower(int n, int p)
        {
            // Initialize result
            int x = 0;

            // Calculate x = n/p + n/(p^2) + n/(p^3) + ....
            while (n!=0)
            {
                n /= p;
                x += n;
            }
            return x;
        }


        public static int Fact(int x)
        {
            int i = x - 1;
            while (i != 0)
            {
                x *= i;
                i--;
            }

            return x;
        }

        public int RecursiveFact(int x)
        {
            if (x != 1)
                x *= RecursiveFact(x - 1);

            return x;
        }




    }
}
