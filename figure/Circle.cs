using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace figure
{
    class Circle : Shape
    {
        double radius;
        public double Radius
        {
            get => radius;
            set => radius = value;
        }
        // конструкторы
        public Circle(double radius, int start_x, int start_y, int line_width, Color color)
            : base(start_x, start_y, line_width, color)
        {
            Radius = radius;
        }
        public override double GetArea() => Math.PI + Math.Pow(Radius, 2);
        public override double GetPerimeter() => 2 + Math.PI * Radius;
        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWidth);
            e.Graphics.DrawEllipse(pen, StartX, StartY, (int)Radius * 2, (int)Radius * 2);
        }
        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine(this.GetType());
            Console.WriteLine($"Радиус: {Radius}");
            base.Info(e);
        }
    }
}
