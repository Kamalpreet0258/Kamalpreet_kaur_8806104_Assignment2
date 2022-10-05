using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamalpreetkaur_8806104_Assignment2
{
    public class Rectangle
    {
        // declaring private integers for length and width
        private int length;
        private int width;

        // declaring the default constructor to set length and width
        public Rectangle()
        {
            length = 1;
            width = 1;
        }

        // declaring parameterised constructor to set length and width
        public Rectangle(int a, int b)
        {
            length = a;
            width = b;
        }

        // GetLength method
        public int GetLength()
        {
            return length;
        }
        // SetLength method
        public int SetLength(int length)
        {
            this.length = length;
            return this.length;
        }

        // GetWidth method
        public int GetWidth()
        {
            return width;
        }

        // SetWidth method
        public int SetWidth(int width)
        {
            this.width = width;
            return this.width;
        }

        // GetPerimeter method
        public int GetPerimeter()
        {
            return 2 * (length + width);
        }

        //GetArea method
        public int GetArea()
        {
            return length * width;
        }

    }
}
