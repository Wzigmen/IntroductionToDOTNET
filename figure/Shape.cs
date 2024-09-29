using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace figure
{
    abstract class Shape
    {
        public static readonly int min_start_x = 50;
        public static readonly int max_start_x = 500;
        public static readonly int min_start_y = 50;
        public static readonly int max_start_y = 500;
        public static readonly int min_line_width = 1;
        public static readonly int max_line_width = 16;
        public static readonly int min_side = 30;
        public static readonly int max_side = 300;

        int start_x;
        int start_y;
        int line_width;
        public Color Color { get; set; }

        public int StartX
        {
            get => start_x;
            set
            {
                if(value < min_start_x) value = min_start_x;
                if(value > max_start_x) value = max_start_x;
                this.start_x = value;
            }
        }
        public int StartY
        {
            get => start_y;
            set => start_y = 
                value < min_start_y ? min_start_y :
                value > max_start_y ? max_start_y :
                value;
        }

        public int LineWidth
        {
            get => line_width;
            set => line_width = 
                value < min_line_width ? min_line_width :
                value > max_line_width ? max_line_width :
                value;
        }
        // конструкторы
        public Shape(int start_x, int start_y, int line_width, Color color)
        {
            StartX = start_x;
            StartY = start_y;
            LineWidth = line_width;
            Color = color;
        }
        public abstract double GetArea();
        public abstract double GetPerimeter();
        public abstract void Draw(PaintEventArgs e);
        public virtual void Info (PaintEventArgs e)
        {
            Console.WriteLine($"Площадь фигуры: {GetArea()}");
            Console.WriteLine($"Периметр фигуры: {GetPerimeter()}");
            Draw(e);
        }

    }
}
