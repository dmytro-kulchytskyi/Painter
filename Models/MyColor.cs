using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PainterApp.Models
{
    public class MyColor
    {
        public int A { get; }
        public int R { get; }
        public int G { get; }
        public int B { get; }
        public MyColor(int a, int r, int g, int b)
        {
            A = a;
            R = r;
            G = g;
            B = b;
        }

        public Color GetColor()
        {
            return Color.FromArgb(A, R, G, B);
        }

        public bool IsValid
        {
            get
            {
                bool Check(params int[] values)
                {
                    foreach (var value in values)
                        if (value < 0 || value > 255) return false;
                    return true;
                }

                return Check(A, R, G, B);
            }
        }
    }
}
