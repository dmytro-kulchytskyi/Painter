using PainterApp.Models;
using PainterApp.Models.DrawingShapes;
using PainterApp.Models.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PainterApp.Models.DrawingShapes
{
    public class DrawingCustomShape : MyCustomShape, IDrawingShape
    {
        public DrawingCustomShape(Point start, Point end, MyColor color, int lineWidth)
            : base(start, end, color, lineWidth) { }

        public void Draw(Graphics graphics)
        {
            var pen = new Pen(Color.GetColor(), LineWidth);
            Point last = Points.FirstOrDefault();
            foreach (var point in Points)
            {
                graphics.DrawLine(pen, last, point);
                last = point;
            }
        }

        public void Scale(Point endPoint)
        {
            ChangeCordinates(Start, endPoint);
        }
    }
}
