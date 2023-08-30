using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fruit fruit = new Fruit();
            //int[] ar = new int[3];

            //fruit[0] = "Apple";
            //fruit[1] = "Mango";
            //fruit[2] = "Banana";
            //fruit[3] = "Pear";
            //fruit[4] = "Orange";

            ////Display all the elements
            //for (int i = 0; i < fruit.Length(); i++)
            //{
            //    Console.WriteLine(fruit[i]);
            //}

            Student st = new Student();
            Console.WriteLine(st["ST100"].ToString());
            Console.WriteLine("=========================");

            List<Student> stList = st[60];
            foreach (Student item in stList)
            {
                Console.WriteLine(item.ToString());
            }



        }
    }
}
