using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTypes
{
    public class Rectangle
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public Rectangle(int theLength, int theWidth) => (this.Length, this.Width) = (theLength, theWidth);

        //public Rectangle(int length, int width)
        //{
        //    Length = length;
        //    Width = width;
        //}
        public override string ToString()
        {
            return $"{this.GetType().Name}:\nLength : {Length}\nWidth : {Width}";
        }
        /// <summary>
        /// Implicit Conversion
        /// </summary>
        /// <param name="s"></param>
        public static implicit operator Rectangle(Shape s)
        {
            return new Rectangle(s.Length, s.Width);
        }
        //public static explicit operator Rectangle(Shape s)
        //{
        //    return new Rectangle(s.Length, s.Width);
        //}

        /*Using explicit, convert from an integer to a Rectangle.
         * the length should be the integer value, 
         * the width should double the integer value
         */
        public static explicit operator Rectangle(int x)
        {
            return new Rectangle(x, x * 2);
        }
    }
}
