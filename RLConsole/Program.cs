using RLConsole.Helper;
using RLConsole.Problems.Arrys;
using RLConsole.Problems.Misc;
using RLConsole.Problems.StringProb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Collections;

namespace RLConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Old Tests
            
            //RotateArray();
            //PrintSentences();
            //GetLongestKUnique();
            //Search();
            //UnionInter();
            //QuickSort();
            //PrintLargestPower();
            //Test();
            //CheckSumInArray();
            //FindMajority();

            #endregion

            FindLargestSum();
            Console.ReadLine();
        }

        #region Arrays

        private static void InsertionSort()
        {
            int[] arry = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            for (int i = 0; i < arry.Length; i++)
            {
                Console.Write(" " + arry[i] + " ");
            }

            var tep = Sorts.InsertionSort(arry);
            Console.WriteLine(" ");
            for (int i = 0; i < tep.Length; i++)
            {
                Console.Write(" " + tep[i] + " ");
            }
        }

        private static void FindIslands()
        {
            char[,] mat = new char[8, 6]   {{'X', 'O', 'O', 'O', 'O', 'O'},
                                            {'X', 'O', 'X', 'X', 'X', 'X'},
                                            {'O', 'O', 'O', 'O', 'O', 'O'},
                                            {'X', 'X', 'O', 'O', 'X', 'X'},
                                            {'X', 'X', 'O', 'O', 'X', 'X'},
                                            {'O', 'O', 'X', 'X', 'O', 'O'},
                                            {'X', 'X', 'O', 'O', 'X', 'X'},
                                            {'X', 'X', 'O', 'O', 'X', 'X'}};

            //char[,] mat = new char[6, 3] {{'O', 'O', 'O'},
            //                             {'X', 'X', 'O'},
            //                             {'X', 'X', 'O'},
            //                             {'O', 'O', 'X'},
            //                             {'O', 'O', 'X'},
            //                             {'X', 'X', 'O'} };


            int count = Islands.CountIslands(mat);

        }

        private static void RotateArray()
        {
            int[] ary = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int rotationIndex = 9;

            Console.WriteLine("Input Array : ");
            for (int i = 0; i < ary.Length; i++)
            {
                Console.Write(ary[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Rotation Index: " + rotationIndex);
            Console.WriteLine();
            //ary= Rotate.Juggle(ary, rotationIndex);
            ary = Rotate.leftRotate(ary, rotationIndex, ary.Length);
            Console.WriteLine("Output Array :");
            for (int i = 0; i < ary.Length; i++)
            {
                Console.Write(ary[i] + ", ");
            }
        }

        private static void QuickSort()
        {
            int[] ary = { 3, 9, 7, 2, 10, 6, 8, 11, 13, 21, 1, 4 };

            Console.WriteLine();
            Console.WriteLine("Input array: ");
            Print.Array(ary);

            Sorts srts = new Sorts();
            var op = srts.QuickSort(ary, 0, ary.Length - 1);

            Console.WriteLine();
            Console.WriteLine("Output array: ");
            Print.Array(op);
        }

        private static void UnionInter()
        {
            int[] arr1 = { 7, 1, 5, 2, 3, 6 };
            int[] arr2 = { 3, 8, 6, 20, 7 };

            Console.WriteLine("Array 1: ");
            Print.Array(arr1);

            Console.WriteLine("Array 2: ");
            Print.Array(arr2);

            UnionIntersect.PrintUnion(arr1, arr2);
            Console.WriteLine();
            UnionIntersect.PrintIntersection(arr1, arr2);
        }

        private static void CheckSumInArray()
        {
            int[] arr = new int[] { 0, 1, 4, 45, 6, 10, -8 };
            int sum = 37;
            bool result = SumPair.CheckPair(arr, sum);

            Print.Array(arr);
            Console.WriteLine("Sum: " + sum);

            if (result)
            {
                Console.WriteLine("Sum with the given pair present");
            }
            else
            {
                Console.WriteLine("Sum with the given pair not present");
            }
        }

        private static void FindMajority()
        {
            int[] arr = new int[] { 1, 1, 1, 1, 1, 2, 3, 4 };
            //int[] arr = new int[] { 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, };
            int? majorityElement = MajorityElement.FindMajority(arr);
            Print.Array(arr);
            if (majorityElement != null)
            {
                Console.WriteLine(majorityElement.ToString() + " id the majority element in this array.");
            }
            else
            {
                Console.WriteLine("No majority element found");
            }
        }


        private static void FindLargestSum()
        {
            int[] arr = new int[] { -2, -3, 4, -1, -2, 1, 5, -3 };

            int largestSum = LargestSum.FindLargestSum(arr);
            Print.Array(arr);

            Console.WriteLine("Largest sum in the given array is: " + largestSum.ToString());
        }

        #endregion

        #region Strings

        private static void PrintSentences()
        {
            //string[, ,] ary = new string[1, 3, 4] {{{"you", "we","1a","1b"},
            //                                       {"have", "are", "2a","2b"},
            //                                       {"sleep", "eat", "drink","3a"}}};
            //Sentence.PrintAllSentences3(ary, 0, 0, 0);

            string[,] ary = new string[3, 4] {{"you", "we","1a","1b"},
                                               {"have", "are", "2a","2b"},
                                               {"sleep", "eat", "drink","3a"}};
            Sentence.PrintAllSentences2(ary, 0, 0);
        }

        private static void GetLongestKUnique()
        {
            Console.Write("Enter string to evaluate :  ");
            string str = Console.ReadLine();

            Unique.LongestUniqueSS(str, 2);
        }

        private static void Search()
        {
            int[] arry = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int elem = 11;
            Sorts srts = new Sorts();
            var tt = srts.BinarySearch(arry, elem, 0, arry.Length - 1);
            Console.Write("I/p Array: ");
            for (int i = 0; i < arry.Length; i++)
            {
                Console.Write(" " + arry[i]);
            }
            Console.WriteLine();
            Console.Write("Search element: " + elem);
            Console.WriteLine();
            Console.WriteLine();

            if (tt != null)
                Console.WriteLine("Element found at index: " + tt);
            else
                Console.WriteLine("Element not found");
        }

        #endregion

        #region Misc

        private static void PrintLargestPower()
        {
            FindPower fp = new FindPower();
            char br = 'a';
            while (br != 'b')
            {
                Console.WriteLine();
                Console.Write("n= ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("p= ");
                int p = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                var t = FindPower.largestPower(n, p);
                Console.WriteLine();
                Console.WriteLine("x= " + t);
                Console.WriteLine();
                Console.WriteLine("Enter b to terminate program");
                br = Console.ReadKey().KeyChar;
            }
        }

        #endregion

    }
}
