using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector_Class
{
    public class Vector
    {
        int X;
        int Y;
        int Length;
        public Vector()
        {
            Length = MathF.Sqrt(X * X + Y * Y);
        }
        public override string ToString()
        {
            return $"Длина вектора ({X}, {Y}): {Length}";
        }
    }
}
