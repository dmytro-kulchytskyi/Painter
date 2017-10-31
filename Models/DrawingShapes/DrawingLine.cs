using PainterApp.Models.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PainterApp.Models.DrawingShapes
{
    public class DrawingLine : MyLine, IDrawingShape
    {
        public DrawingLine(MyColor color, int lineWidth) : base(color, lineWidth) { }

        public DrawingLine(Point start, Point end, MyColor color, int lineWidth)
            : base(start, end, color, lineWidth) { }

        public void Draw(Graphics graphics)
        {
            graphics.DrawLine(new Pen(Color.GetColor(), LineWidth), Start, End);
        }

        public void Scale(Point endPoint)
        {
            ChangeCordinates(Start, endPoint);
        }
    }
}
