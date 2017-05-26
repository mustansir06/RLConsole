using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLConsole.Problems.Arrys
{
    public class Sorts
    {

        #region Insertion Sort

        public static int[] InsertionSort(int[] arry)
        {
            int[] temp = new int[arry.Length];
            for (int i = 0; i < arry.Length; i++)
            {
                int x = arry[i];
                int j = i;
                while (j > 0 && arry[j - 1] > x)
                {
                    arry[j] = arry[j - 1];
                    j -= 1;
                }
                arry[j] = x;

            }
            return arry;


        }

        #endregion

        #region Quick Sort

        public int[] QuickSort(int[] ary, int start, int end)
        {
            if (start < end)
            {
                int pivot = Partition(ary, start, end);
                QuickSort(ary, start, pivot - 1);
                QuickSort(ary, pivot + 1, end);
            }
            return ary;
        }



        private int Partition(int[] ary, int start, int end)
        {
            for (int i = start; i <= end - 1; i++)
            {
                // If current element is smaller than or equal to pivot 
                if (ary[i] <= ary[end])
                {
                    Swap(ref ary[start], ref ary[i]);
                    start++; // increment index of smaller element
                }
            }
            Swap(ref ary[start], ref ary[end]);
            return start;
        }



        private void Swap(ref int a, ref int b)
        {
            int t1 = a;
            a = b;
            b = t1;
        }
        
        #endregion






        public int? BinarySearch(int[] arry, int k, int start, int end)
        {
            if (start > end)
                return null;

            int mid = start + (int)Math.Floor((end - start) / 2d);

            if (arry[mid] > k)
                return BinarySearch(arry, k, start, mid - 1);
            else if (arry[mid] < k)
                return BinarySearch(arry, k, mid + 1, end);
            else if (arry[mid] == k)
                return mid;

            return null;
        }

    }
}
