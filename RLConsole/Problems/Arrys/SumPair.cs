using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace RLConsole.Problems.Arrys
{

    /// <summary>
    /// http://www.geeksforgeeks.org/write-a-c-program-that-given-a-set-a-of-n-numbers-and-another-number-x-determines-whether-or-not-there-exist-two-elements-in-s-whose-sum-is-exactly-x/
    /// Given an array A[] of n numbers and another number x, determines whether or not there exist two elements in S whose sum is exactly x.
    /// </summary>
    public class SumPair
    {

        public static bool CheckPair(int[] arr, int sum)
        {
            Hashtable objHT = new Hashtable();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!objHT.ContainsKey(arr[i]))
                {
                    objHT[arr[i]] = arr[i];
                }
            }

            int currentVal = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                currentVal = sum - arr[i];
                if (objHT.ContainsKey(currentVal))
                {
                    return true;
                }
            }

            return false;
        }

    }
}
