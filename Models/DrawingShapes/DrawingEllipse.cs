using PainterApp.Models.DrawingShapes;
using PainterApp.Models.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using PainterApp.Models;

namespace PainterApp.Models.DrawingShapes
{
    public class DrawingEllipse : MyEllipse, IDrawingShape
    {
        private Point enterPoint;

        public DrawingEllipse(Point start, Point end, MyColor color, int lineWidth)
            : base(start, end, color, lineWidth)
        {
            enterPoint = start;
        }

        public void Draw(Graphics graphics)
        {
            var width = Width == 0 ? 1 : Width;
            var heigth = Heigth == 0 ? 1 : Heigth;
            graphics.DrawEllipse(new Pen(Color.GetColor(), LineWidth), Start.X, Start.Y, width, heigth);
        }

        public void Scale(Point endPoint)
        {
            ChangeCordinates(enterPoint, endPoint);
        }
    }
}
