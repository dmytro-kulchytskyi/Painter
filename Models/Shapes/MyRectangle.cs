using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PainterApp.Models.Shapes
{
    public class MyRectangle : ShapeBase
    {
        public int Width { get => Math.Abs(End.X - Start.X); }
        public int Heigth { get => Math.Abs(End.Y - Start.Y); }

        public MyRectangle(MyColor color, int lineWidth) : base(color, lineWidth) { }

        public MyRectangle(Point start, Point end, MyColor color, int lineWidth) : base(start, end, color, lineWidth)
        {
            ChangeCordinates(start, end);
        }

        public override void ChangeCordinates(Point start, Point end)
        {
            base.ChangeCordinates(start, end);
            OrderCordinates();
        }
    }
}
