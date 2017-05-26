using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLConsole.Problems.Arrys
{
    /// <summary>
    /// http://www.geeksforgeeks.org/largest-sum-contiguous-subarray/
    /// Write an efficient program to find the sum of contiguous subarray within a one-dimensional array of numbers which has the largest sum.
    /// </summary>
    public class LargestSum
    {

        public static int FindLargestSum(int[] arr)
        {
            int sum = 0;
            int current = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                current += arr[i];

                if (current < 0)
                {
                    current = 0;
                }

                if (sum < current)
                {
                    sum = current;
                }
            }

            return sum;
        }

    }
}
