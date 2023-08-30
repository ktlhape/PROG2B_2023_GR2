using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Lazy<targetObject Type> name = 
             * new Lazy<targetObject Type>(target object)*/

            Lazy<string[]> lazyhobbies = 
                new Lazy<string[]>(Hobbies);


            //string[] ar = Hobbies();
            Console.WriteLine(lazyhobbies.Value[1]);
            Console.Read();
        }

        static string[] Hobbies()
        {
            return new string[] { "Tennis","Soccer","Hockey"};
        }


    }
}
