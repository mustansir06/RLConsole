using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLConsole.Problems.Arrys
{
    /// <summary>
    /// http://www.geeksforgeeks.org/find-the-missing-number/
    /// Find the Missing Number
    /// You are given a list of n-1 integers and these integers are in the range of 1 to n.
    /// There are no duplicates in list.One of the integers is missing in the list. Write an efficient code to find the missing integer.
    /// </summary>
    public class MissingNumber
    {
        public static int FindMissing(int[] arr, int range)
        {

            int rangeResult = 1;
            for (int i = 2; i <= range; i++)
            {
                rangeResult = rangeResult ^ i;
            }

            int arrayResult = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                arrayResult = arrayResult ^ arr[i];
            }
            int missing = rangeResult ^ arrayResult;
            return missing;

        }
    }
}
