using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace figure
{
    class Rectangle : Shape
    {
        double width;
        double height;
        public double Width 
        {
            get => width;
            set => width = 
                value < min_side ? min_side :
                value > max_side ? max_side : value;
        }
        public double Height
        {
            get => height;
            set => height =
                value < min_side ? min_side :
                value > max_side ? max_side : value;
        }
        // конструкторы
        public Rectangle(double width, double height, int start_x, int start_y, int line_wigth, Color color)
            : base(start_x, start_y, line_wigth, color)
        {
            Width = width;
            Height = height;
        }
        public override double GetArea() => Width * Height;
        public override double GetPerimeter() => (Width + Height) * 2;
        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWidth);
            e.Graphics.DrawRectangle(pen, StartX, StartY, (float)Width, (float)Height);
        }
        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine(this.GetType()+":");
            Console.WriteLine($"Ширина: {Width}");
            Console.WriteLine($"Высота: {Height}");
            base.Info(e);
        }
    }
}
