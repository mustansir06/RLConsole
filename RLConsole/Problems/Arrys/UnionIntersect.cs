using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLConsole.Problems.Arrys
{
    public class UnionIntersect
    {

        //http://www.geeksforgeeks.org/find-union-and-intersection-of-two-unsorted-arrays/
        //Find Union and Intersection of two unsorted arrays
        //Given two unsorted arrays that represent two sets (elements in every array are distinct), find union and intersection of two arrays.

        //For example, if the input arrays are:
        //arr1[] = {7, 1, 5, 2, 3, 6}
        //arr2[] = {3, 8, 6, 20, 7}
        //Then your program should print Union as {1, 2, 3, 5, 6, 7, 8, 20} and Intersection as {3, 6}. Note that the elements of union and intersection can be printed in any order


        public static void PrintUnion(int[] a, int[] b)
        {
            int[] u = new int[a.Length + b.Length];
            for (int i = 0; i < u.Length; i++)
                u[i] = -1;

            int end = 0;

            UnionIntersect ui = new UnionIntersect();

            if (a.Length>=b.Length)
            {
                Sorts srts = new Sorts();
                var op = srts.QuickSort(a, 0, a.Length - 1);
                end = a.Length-1;
                for (int i = 0; i <= end; i++)
                    u[i] = a[i];

                for (int i = 0; i < b.Length; i++)
                {
                    if (!ui.BinarySearch(u, b[i], 0, end))
                    {
                        u[end] = b[i];
                        end++;
                    } 
                }
            }
            else
            {
                Array.Sort(b);
                end = b.Length - 1;
                for (int i = 0; i <= end; i++)
                    u[i] = b[i];

                for (int i = 0; i < a.Length; i++)
                {
                    if (!ui.BinarySearch(u, a[i], 0, end))
                    {
                        u[end] = a[i];
                        end++;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Union: ");
            for (int i = 0; i < end; i++)
            {
                Console.Write(" " + u[i]);
            }


        }








        private bool BinarySearch(int[] arry, int k, int start, int end)
        {
            if (start > end)
                return false;
            int mid = start + (int)Math.Floor((end - start) / 2d);
            if (arry[mid] > k)
                return BinarySearch(arry, k, start, mid - 1);
            else if (arry[mid] < k)
                return BinarySearch(arry, k, mid + 1, end);
            else if (arry[mid] == k)
                return true;

            return false;
        }

        private bool LinearSearch(int[] arry)
        {
            for (int i = 0; i < arry.Length; i++)
            {
                if (true)
                {
                    
                }
            }
            return false;
        }

        public static void PrintIntersection(int[] a1, int[] a2)
        {
            int[] inter = new int[a1.Length > a2.Length ? a2.Length : a1.Length];
            int end = 0;
            for (int i = 0; i < inter.Length; i++)
                inter[i] = -1;

            Sorts srts = new Sorts();
            UnionIntersect ui = new UnionIntersect();

            if (a1.Length>a2.Length)
            {
                a2 = srts.QuickSort(a2, 0, a2.Length-1);
                for (int i = 0; i < a1.Length; i++)
                {
                    if (ui.BinarySearch(a2, a1[i], 0, a2.Length)) 
                    {
                        inter[end] = a1[i];
                        end++;
                    }
                }
            }
            else
            {
                a1 = srts.QuickSort(a1, 0, a1.Length - 1);
                for (int i = 0; i < a2.Length; i++)
                {
                    if (ui.BinarySearch(a1, a2[i], 0, a1.Length))
                    {
                        inter[end] = a2[i];
                        end++;
                    }
                }
            }
            
            Console.WriteLine();
            Console.WriteLine("Intersection: ");
            for (int i = 0; i < end; i++)
                Console.Write(" " + inter[i]); ;

            Console.WriteLine();

        }


    }
}
