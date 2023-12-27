using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Rotation
{
    public class Angle
    {
        private readonly int _angle;
        public Angle(int angle)
        {
            _angle = angle % 360;
        }

        public static Angle operator +(Angle a, Angle b) => new(a._angle + b._angle);
    }
}
