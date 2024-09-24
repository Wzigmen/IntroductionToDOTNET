
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Points
{
    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point(int x = 0, int y = 0)
        {
            this.x = x;
            this.y = y;
        }
        public Point(Point other)
        {
            this.x = other.x;
            this.y = other.y;
        }

        public void print()
        {
            Console.WriteLine($"x = {x}\ty = {y}");
        }
        public double Distance(Point other)
        {
            double x_1 = x - other.x;
            double y_1 = y - other.y;
            return Math.Sqrt(x_1 * x_1 + y_1 * y_1);
        }
        public static Point operator +(Point p1, Point p2)
        {
            Point res = new Point();
            res.x = p1.x + p2.x;
            res.y = p1.y + p2.y;
            return res;
        }
        public static Point operator ++(Point odj)
        {
            odj.x++;
            odj.y++;
            return odj;
        }
        public static bool operator ==(Point p1, Point p2)
        {
            return p1.x == p2.x && p1.y == p1.x;
        }
        public static bool operator !=(Point p1, Point p2)
        {
            return p1.x != p2.x && p1.y != p1.x;
        }


    }
}
