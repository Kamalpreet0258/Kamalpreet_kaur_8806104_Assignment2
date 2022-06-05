using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamalpreet_kaur_8806104_Assignment2
{
    internal class Rectangle
    {
        private int width;
        private int length;

        Rectangle()
        { 
           length =1;
           width =1;
        }
        Rectangle (int a, int b)
        {
            length = a;
            width = b;
        }

        public int GetLentgh()
        {
            return length;
        }
        public int SetLength(int length)
        {
            return length;
        }
        public int GetWidth()
        {
            return width;
        }
        public int SetWidth(int width)
        {
            return length;

        }
        public int GetPerimeter(int l, int b)
        {
            return 2*(l + b);

        }
        public int GetArea(int l, int b)
        {
            return (l * b);
        }


    }
}
