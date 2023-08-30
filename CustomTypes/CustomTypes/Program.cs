using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle(3, 5);
            Shape sh = new Shape(5, 8);
            Console.WriteLine(rec.ToString());
            Console.WriteLine(sh.ToString());
            //Implicit: Convert Rectangle to a Shape
            Rectangle r = sh;

            //Explicit: Convert Shape to a Rectangle
            Shape s = (Shape)rec;

            int n = 5;

            Rectangle rrr = (Rectangle)n;

            Console.WriteLine("=====After Conversion====");
            Console.WriteLine(r.ToString());
            Console.WriteLine(s.ToString());
            Console.Read();






        }
    }
}
