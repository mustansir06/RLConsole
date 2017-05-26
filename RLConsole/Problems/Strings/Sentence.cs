using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLConsole.Problems.StringProb
{
    public class Sentence
    {
        //http://www.geeksforgeeks.org/recursively-print-all-sentences-that-can-be-formed-from-list-of-word-lists/
        //Recursively print all sentences that can be formed from list of word lists
        //Given a list of word lists How to print all sentences possible taking one word from a list at a time via recursion?
        //Input: {{{"you", "we","1a","1b"},
        //         {"have", "are", "2a","2b"},
        //         {"sleep", "eat", "drink","3a"}}};
        //Output:
        //  you have sleep
        //  you have eat
        //  you have drink
        //  you are sleep
        //  you are eat
        //  you are drink
        //  we have sleep
        //  we have eat
        //  we have drink
        //  we are sleep
        //  we are eat
        //  we are drink 

        public static void PrintAllSentences3(string[, ,] ipStr, int l1, int l2, int l3)
        {
            if (l1 == ipStr.GetLength(0)  && l2 == ipStr.GetLength(1)  && l3 == ipStr.GetLength(2) )
                return;

            //Console.WriteLine(ipStr[l1, l2, l3]);

            if (l1 < ipStr.GetLength(0) - 1)
                PrintAllSentences3(ipStr, l1 + 1, l2, l3);
            if (l2 < ipStr.GetLength(1) - 1)
                PrintAllSentences3(ipStr, l1, l2 + 1, l3);
            if (l3 < ipStr.GetLength(2) - 1)
                PrintAllSentences3(ipStr, l1, l2, l3 + 1);

            //Console.WriteLine(ipStr[l1, 0, 0] + " " + ipStr[0, l2, 0] + " " + ipStr[0, 0, l3]);
            Console.WriteLine(ipStr[l1, l2, l3]);
            
        }

        

        public static void PrintAllSentences2(string[ ,] ipStr, int l1, int l2)
        {
            if (l1 == ipStr.GetLength(0) && l2 == ipStr.GetLength(1))
                return;

            if (l1 < ipStr.GetLength(0) - 1)
                PrintAllSentences2(ipStr, l1 + 1, l2);
            if (l2 < ipStr.GetLength(1) - 1)
            {
                Console.WriteLine(ipStr[l1, l2]);
                PrintAllSentences2(ipStr, l1, l2 + 1);
            }

            
            //Console.WriteLine(ipStr[l1, l2]);

        }

    }
}
