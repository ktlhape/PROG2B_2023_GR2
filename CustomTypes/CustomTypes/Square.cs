using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTypes
{
    public class Square
    {
        public int Length { get; set; }

        public Square(int theLength) => (this.Length) = (theLength);

        public override string ToString()
        {
            return $"{this.GetType().Name}:\nLength : {Length}";
        }

        /*1. Using implicit, convert from Rectangle to a Square.
         * Only use the length from the Rectangle
         */

        /*2. Using explicit, convert from Shape to a Square.
        * Only use the width from the Shape
        */
    }
}
