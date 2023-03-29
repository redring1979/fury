using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Numerics
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Point2f
    {
        public float X { get; set; }

        public float Y { get; set; }

        public Point2f(float x, float y)
        {
            X = x;
            Y = y;
        }
    }
}
