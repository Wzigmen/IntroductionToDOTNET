#define NUMERIC_TYPES
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Diagnostics.Eventing.Reader;

namespace DataTypes
{
    internal class Urok
    {
        static readonly string delimiter1 = "\n------------------------------------------\n";
        static readonly string delimiter2 = "\n==========================================\n";
        public static int Clamp(int value, int min, int max)
        {
            if (value < min)
            {
                return min;
            }
            else if (value > max)
            {
                return max;
            }
            else
            {
                return value;
            }
        } 
        static void Main(string[] args)
        {
            



        }
    }
}
