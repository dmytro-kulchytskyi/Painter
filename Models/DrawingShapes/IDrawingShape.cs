using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PainterApp.Models.DrawingShapes
{
    public interface IDrawingShape
    {
        void Draw(Graphics graphics);
        void Scale(Point endPoint);
        Point Start { get; }
        Point End { get; }
    }
}
