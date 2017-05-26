using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLConsole.Problems.StringProb
{
    public class Unique
    {

        //http://www.geeksforgeeks.org/find-the-longest-substring-with-k-unique-characters-in-a-given-string/
        //Find the longest substring with k unique characters in a given string
        //Given a string you need to print longest possible substring that has exactly M unique characters. If there are more than one substring of longest possible length, then print any one of them.
        //Example:
        //"aabbcc", k = 2
        //Max substring can be any one from "aabb" or "bbcc" 
        //https://ideone.com/baatUf

        public static void LongestUniqueSS(string ip, int k)
        {
            char[] chr = ip.ToArray();
            int index1 = 0, index2 = 0, diff=-1;
            char[] comp = new char[k];
            string result = string.Empty;
            for (int i = 0; i < k; i++)
            {
                comp[i] = '\n';
            }

            for (int i = 0; i < chr.Length; i++)
            {
                if (ContainsChar(comp, '\n'))
                {
                    if (!ContainsChar(comp, ip[i]))
                        comp = AddChar(comp, ip[i]);

                    index2 = i;
                }
                else if (ContainsChar(comp, ip[i]))
                {
                    index2 = i;
                }
                else if (!ContainsChar(comp, ip[i]))
                {
                    comp = AddChar(comp, ip[i]);

                    while (!ContainsChar(comp, ip[index1]))
                    {
                        index1++;
                    }
                    index2 = i;
                }

                if (diff < index2 - index1)
                {
                    result = string.Empty;
                    diff = index2 - index1;
                    for (int j = index1; j <= index2; j++)
                    {
                        result += ip[j];
                    }
                }

            }


            Console.WriteLine(result);

        }


        private static bool ContainsChar(char[] ary, char chr)
        {
            for (int i = 0; i < ary.Length; i++)
            {
                if (ary[i]==chr)
                {
                    return true;
                }
            }
            return false;
        }


        private static char[] AddChar(char[] ary, char chr)
        {
            for (int i = 0; i < ary.Length-1; i++)
            {
                ary[i] = ary[i + 1];
            }
            ary[ary.Length - 1] = chr;
            return ary;
        }

    }
}
