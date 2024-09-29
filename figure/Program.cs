using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace figure
{
    class Program
    {
        static void Main(string[] args)
        {
            IntPtr hwnd = GetConsoleWindows();
            Graphics graphics = Graphics.FromHwnd(hwnd);
            System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
                (
                Console.WindowLeft, Console.WindowTop, 
                Console.WindowWidth, Console.WindowHeight
                );
            PaintEventArgs e = new PaintEventArgs(graphics, window_rect);
            // прямоугольник
            Rectangle rectangle = new Rectangle(80, 50, 400, 50, 2, Color.AliceBlue);
            rectangle.Info(null);
            // квадрат
            Square square = new Square(75, 500, 50, 3, Color.Red);
            square.Info(e);
            // круг
            Circle circle= new Circle(80,700,50,1,Color.Blue);
            circle.Info(e);
        }
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindows();
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);
    }
}
