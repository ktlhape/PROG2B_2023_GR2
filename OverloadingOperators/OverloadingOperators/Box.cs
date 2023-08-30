using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperators
{
    public class Box
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public Box(int length, int width)
        {
            Length = length;
            Width = width;
        }

        //public static return type operator +(operands)
        public static Box operator + (Box b1, Box b2)
        {
            return new Box(b1.Length + b2.Length, b1.Width + b2.Width);
        }

        public static Box operator ++(Box b)
        {
            return new Box(b.Length + 1, b.Width + 1);
        }

        public static bool operator > (Box b1, Box b2)
        {
            return (b1.Length > b2.Length && b1.Width > b2.Width);
        }
        public static bool operator <(Box b1, Box b2)
        {
            return (b1.Length < b2.Length && b1.Width < b2.Width);
        }
        public override string ToString()
        {
            return $"Length: {Length}\nWidth: {Width}";
        }
    }
}
