using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PainterApp.Models.Shapes
{
    public abstract class ShapeBase
    {
        public int LineWidth { get; set; }
        public MyColor Color { get; set; }
        public Point Start { get; private set; }
        public Point End { get; private set; }

        public ShapeBase(MyColor color, int lineWidth)
        {
            Color = color;
            LineWidth = lineWidth;
        }

        public ShapeBase(Point start, Point end, MyColor color, int lineWidth)
        {
            Start = start;
            End = end;
            Color = color;
            LineWidth = lineWidth;
        }

        public virtual void ChangeCordinates(Point start, Point end)
        {
            Start = start;
            End = end;
        }

        protected void OrderCordinates()
        {
            int leftX, topY, rightX, bottomY;

            if (Start.X < End.X)
            {
                leftX = Start.X;
                rightX = End.X;
            }
            else
            {
                leftX = End.X;
                rightX = Start.X;
            }

            if (Start.Y < End.Y)
            {
                topY = Start.Y;
                bottomY = End.Y;
            }
            else
            {
                topY = End.Y;
                bottomY = Start.Y;
            }

            Start = new Point(leftX, topY);
            End = new Point(rightX, bottomY);
        }
    }
}
