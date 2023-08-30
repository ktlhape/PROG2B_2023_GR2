using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ObjectLifetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            Student st2 = new Student("James");
            st.Dispose();
            st2.Dispose();

            using (Student st3 = new Student("Carol"))
            {

            }//st3 is disposed here


            //GC.Collect();
            Console.Read();
        }
    }
}
