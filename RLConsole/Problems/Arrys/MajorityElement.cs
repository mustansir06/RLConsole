using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLConsole.Problems.Arrys
{
    /// <summary>
    /// http://www.geeksforgeeks.org/majority-element/
    /// Majority Element: A majority element in an array A[] of size n is an element that appears more than n/2 times (and hence there is at most one such element).
    /// </summary>
    public class MajorityElement
    {

        public static int? FindMajority(int[] arr)
        {
            int current = arr[0];
            int count = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (current == arr[i])
                {
                    count++;
                }
                else
                {
                    count--;
                }

                if (count < 1)
                {
                    current = arr[i];
                    count++;
                }
            }
            return current;
        }

    }
}
