using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PainterApp.Models.Shapes
{
    public class MyLine : ShapeBase
    {
        public MyLine(MyColor color, int lineWidth) : base(color, lineWidth) { }
        public MyLine(Point start, Point end, MyColor color, int lineWidth) : base(start, end, color, lineWidth) { }
    }
}
