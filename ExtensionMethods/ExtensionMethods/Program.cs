using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Today is Tuesday, right?";
            Console.WriteLine($"{phrase}, has {phrase.WordCount()} words");

            phrase = "Yesterday was Monday, right?";
            Console.WriteLine($"{phrase}, has {phrase.CountVowels()} vowels");

            int x = 5;
            Console.WriteLine(x.IsEven());

            int[] ar = new int[] { 8,1,2,47,62,22,18,10};

            foreach (int item in ar)
            {
                /*using the extension method (isEven)
                 * display all the even numbers*/
            }

            
        }
    }
}
