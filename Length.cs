using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisionProblem
{
    class Length
    {
        int x1, x2, y1, y2;
        public Length(int x1, int x2, int y1, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
        public double CalculateLength()
        {
            double length = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return length;
        }
    }
}
