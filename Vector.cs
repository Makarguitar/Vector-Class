using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector_Class
{
    public class Vector
    {
        public int X;
        public int Y;
        int Length;
        
        public Vector(int x, int y)
        {
            Length = (int)MathF.Sqrt(x * x + y * y);
            X = x;
            Y = y;
        }
        
        public override string ToString()
        {
            return $"Vector's length ({X}, {Y}): {Length}";
        }
    }
}
