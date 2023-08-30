using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class Extensions
    {
        //modifier static return type name (this classToExtend variableToUse)

        public static int CountVowels(this string str)
        {
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                string letter = str.Substring(i, 1).ToLower();
                if (letter.Equals("a") || letter.Equals("e") || 
                    letter.Equals("i") || letter.Equals("o") || 
                    letter.Equals("u") )
                {
                    count++;
                }

            }
            return count;

        }

        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '!', '?', ',', ';' }, 
                StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static bool IsEven(this int num) =>
            num % 2 == 0;

        /*Extend the integer array. The method
         * should return the last element in the
         * array. Name your method "Peek"*/
        public static int Peek(this int[] ar) =>
         ar[ar.Length - 1];
        

        
    }
}
