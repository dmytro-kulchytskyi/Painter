using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PainterApp.Models.Shapes
{
    public class MyEllipse : ShapeBase
    {
        public Point Center { get => new Point((Start.X + End.X) / 2, (Start.Y + End.Y) / 2); }

        public int Width { get => Math.Abs(End.X - Start.X); }
        public int Heigth { get => Math.Abs(End.Y - Start.Y); }

        public MyEllipse(Point start, Point end, MyColor color, int lineWidth) : base(start, end, color, lineWidth)
        {
            ChangeCordinates(start, end);
        }

        public MyEllipse(MyColor color, int lineWidth) : base(color, lineWidth) { }

        public override void ChangeCordinates(Point start, Point end)
        {
            base.ChangeCordinates(start, end);
            OrderCordinates();
        }
    }
}
