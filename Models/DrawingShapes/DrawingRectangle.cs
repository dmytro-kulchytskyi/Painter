﻿using PainterApp.Models.DrawingShapes;
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
    public class DrawingRectangle : MyRectangle, IDrawingShape
    {

        private Point enterPoint;

        public DrawingRectangle(Point start, Point end, MyColor color, int lineWidth) 
            : base(start, end, color, lineWidth)
        {
            enterPoint = start;
        }

        public void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(new Pen(Color.GetColor(), LineWidth), Start.X, Start.Y, Width, Heigth);
        }

        public void Scale(Point endPoint)
        {
            ChangeCordinates(enterPoint, endPoint);
        }
    }
}