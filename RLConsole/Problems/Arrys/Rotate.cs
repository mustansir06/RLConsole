using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLConsole.Problems.Arrys
{
    public class Rotate
    {

        public static int[] Juggle(int[] ary, int rIndex)
        {
            int gcd = 0;

            for (int i = 1; i < ary.Length; i++)
            {
                if (rIndex % i == 0 && ary.Length % i == 0)
                    gcd = i;
            }

            int k = 0;
            while (k < rIndex)
            {
                int temp = ary[k];
                int i = k;
                while (i < ary.Length - gcd)
                {
                    ary[i] = ary[i + gcd];
                    i = i + gcd;
                }
                ary[i] = temp;
                k++;
            }

            return ary;
        }


        public static int[] leftRotate(int[] arr, int d, int n)
        {
            int i, j, k, temp;
            for (i = 0; i < gcd(d, n); i++)
            {
                /* move i-th values of blocks */
                temp = arr[i];
                j = i;
                while (true)
                {
                    k = j + d;
                    if (k >= n)
                        k = k - n;
                    if (k == i)
                        break;
                    arr[j] = arr[k];
                    j = k;
                }
                arr[j] = temp;
            }

            return arr;
        }

        static int gcd(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return gcd(b, a % b);
        }

    }
}
