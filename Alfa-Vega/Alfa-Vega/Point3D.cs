using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfa_Vega
{
    public class Point3D
    {
        /// <summary>
        /// 3 boyutlu nokta sınıfı.
        /// </summary>
        public Point3D(int _x, int _y, int _z)
        {
            x = _x; y = _y; z = _z;
        }
        /// <summary>
        /// Coordinate of Point X.
        /// </summary>
        public int x { get; set; }
        /// <summary>
        /// Coordinate of Point Y.
        /// </summary>
        public int y { get; set; }
        /// <summary>
        /// Coordinate of Point Z.
        /// </summary>
        public int z { get; set; }
    }
}
