﻿using PainterApp.Models.Shapes;
using PainterApp.Models;
using PainterApp.Models.DrawingShapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PainterApp
{
    public class WinFormsPictureBoxPainter
    {
        public WinFormsPictureBoxPainter(PictureBox pictureBox, ShapeType shapeType, MyColor color, int lineWidth)
        {
            PictureBox = pictureBox;
            ShapeType = shapeType;
            Color = color;
            LineWidth = lineWidth;

            SetHandlers();
        }

        private void SetHandlers()
        {
            PictureBox.Paint += new PaintEventHandler(Refresh);
            PictureBox.MouseDown += new MouseEventHandler(Draw);
            PictureBox.MouseMove += new MouseEventHandler(DrawProcess);
            PictureBox.MouseUp += new MouseEventHandler(EndDraw);
        }

        public PictureBox PictureBox { get; private set; }
        public ShapeType ShapeType { get; set; }

        private MyColor color;
        public MyColor Color
        {
            get => color;
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Argument must have a value");
                if (!value.IsValid)
                    throw new ArgumentException("Invalid value");
                color = value;
            }
        }

        private int lineWidth;
        public int LineWidth
        {
            get => lineWidth;
            set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException("Value must be positive");

                lineWidth = value;
            }
        }

        private List<IDrawingShape> shapes = new List<IDrawingShape>();
        private List<IDrawingShape> cancaledShapes = new List<IDrawingShape>();

        private void DrawAll(Graphics graphics)
        {
            foreach (var shape in shapes)
                shape.Draw(graphics);
        }

        private IDrawingShape shape;

        private void Draw(object sender, MouseEventArgs e)
        {
            var start = e.Location;
            switch (ShapeType)
            {
                case ShapeType.Line:
                    shape = new DrawingLine(start, start, color, lineWidth);
                    break;
                case ShapeType.Custom:
                    shape = new DrawingCustomShape(start, start, color, lineWidth);
                    break;
                case ShapeType.Ellipse:
                    shape = new DrawingEllipse(start, start, color, lineWidth);
                    break;
                case ShapeType.Rectangle:
                    shape = new DrawingRectangle(start, start, color, lineWidth);
                    break;
                default:
                    throw new NotImplementedException("Unsupported shape type");
            }

        }

        private void DrawProcess(object sender, MouseEventArgs e)
        {
            if (shape != null)
            {
                shape.Scale(e.Location);
                PictureBox.Invalidate();
            }
        }

        private void EndDraw(object sender, MouseEventArgs e)
        {
            if (shape != null)
            {
                shapes.Add(shape);
                shape = null;
            }
        }

        private void Refresh(object sender, PaintEventArgs e)
        {
            DrawAll(e.Graphics);
            shape?.Draw(e.Graphics);
        }

        public void StepBack()
        {
            if (shapes.Count > 0)
            {
                var shape = shapes.Last();
                shapes.RemoveAt(shapes.Count - 1);

                cancaledShapes.Add(shape);
                PictureBox.Invalidate();
            }
        }

        public void StepForward()
        {
            if (cancaledShapes.Count > 0)
            {
                var shape = cancaledShapes.Last();
                cancaledShapes.RemoveAt(cancaledShapes.Count - 1);

                shapes.Add(shape);
                PictureBox.Invalidate();
            }
        }

        public void Clear(bool saveHistory)
        {
            if (saveHistory)
                cancaledShapes.AddRange(shapes);
            else
                cancaledShapes.Clear();

            shapes.Clear();
            PictureBox.Invalidate();
        }
    }
}
