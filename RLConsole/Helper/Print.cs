using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLConsole.Helper
{
    public class Print
    {
        
        public static void Array(int[] array)
        {
            Console.WriteLine("");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + array[i]);
            }
            Console.WriteLine();
        }

        public static void Array(char[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + array[i]);
            }
            Console.WriteLine();
        }

        public static void Array(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + array[i]);
            }
            Console.WriteLine();
        }


    }
}
