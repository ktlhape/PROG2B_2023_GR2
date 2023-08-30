using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTypes
{
    public class Shape
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public Shape(int length, int width)
        {
            Length = length;
            Width = width;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}:\nLength : {Length}\nWidth : {Width}";
        }
        public static explicit operator Shape(Rectangle r)
        {
            return new Shape(r.Length, r.Width);
        }
    }
}
