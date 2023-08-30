using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Box boxA = new Box(8, 4);
            Box boxB = new Box(6, 3);

            bool isGreater = boxA > boxB;
            //Box boxC = new Box(boxA.Length + boxB.Length,boxA.Width + boxB.Width);
            Box boxC = boxA + boxB;

            boxA++;

            //Box boxAA = boxA + 5;
            Console.WriteLine(boxC.ToString());

     



        }
    }

}
