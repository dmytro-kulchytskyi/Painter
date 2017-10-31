using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PainterApp.Models.Shapes
{
    public class MyCustomShape : ShapeBase
    {
        public List<Point> Points { get; private set; } = new List<Point>();

        public MyCustomShape(MyColor color, int lineWidth) : base(color, lineWidth) { }
        
        public MyCustomShape(Point start, Point end, MyColor color, int lineWidth)
            : base(start, end, color, lineWidth)
        {
            Points.AddRange(new Point[] { start, end });
        }

        public override void ChangeCordinates(Point start, Point end)
        {
            Points.Add(end);
        }
    }
}
