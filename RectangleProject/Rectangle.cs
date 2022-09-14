using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleProject
{
    internal class Rectangle
    {
        int l, b, p;
       
            public Rectangle(int l,int b)
        {
            this.l = l;
            this.b = b;
        }
        public int calculate()
        {
            { return p = 2 * (l + b); }
        }
        public int display()
            { return p; }
            
    }
}
