using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    struct Point3D
    {
        public double X;
        public double Y;
        public double Z;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point3D p;
            p.X = 1;
            p.Y = 2;
            p.Z = 3;
            Console.WriteLine("p1 ({0},{1},{2})",p.X, p.Y,p.Z);

            Point3D p2 = new Point3D();
            Console.WriteLine("p2 ({0},{1},{2})", p2.X, p2.Y, p2.Z);

        }
    }
}
