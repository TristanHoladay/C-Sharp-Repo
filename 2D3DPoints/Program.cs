using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D3DPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Point2D firstPoint = new Point2D(7, 5);
            Console.WriteLine(firstPoint);  
            Point3D secondPoint = new Point3D(7, 5, 12);
            Console.WriteLine(secondPoint);
            Console.WriteLine(firstPoint.Equals(secondPoint));
            Console.Read();
        }
    }

    class Point2D
    {
        protected int X;
        protected int Y;

        public Point2D() : this(0, 0)
        {
        }

        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return "(" + X + "," + Y + ")";
        }

        //this is to compare instances for value equality
        public override bool Equals(Object obj)
        {
            if((obj == null) || ! this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Point2D p = (Point2D)obj;
                return (X == p.X) && (Y == p.Y);
            }
        }
    }

    class Point3D : Point2D
    {
        public int Z;

        public Point3D(int x, int y, int z) : base (x, y)
        {
            Z = z;
        }

        public override string ToString()
        {
            return "(" + X + "," + Y + "," + Z + ")";
        }

        //This is to compare instances for value equality
        public override bool Equals(object obj)
        {
            if((obj == null) || ! this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Point3D p = (Point3D) obj;
                return (X == p.X) && (Y == p.Y) && (Z == p.Z);
            }
        }
    }

}
