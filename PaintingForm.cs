using PainterApp.Models.Shapes;
using PainterApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PainterApp
{
    public partial class PaintingForm : Form
    {
        private MyColor startColor;
        private int startLineWidth;
        private ShapeType startShapeType;

        public WinFormsPictureBoxPainter Painter { get; private set; }
        public PaintingForm()
        {
            InitializeComponent();

            startColor = new MyColor(255, 0, 255, 0);
            startLineWidth = 2;
            startShapeType = ShapeType.Custom;
        }

        public PaintingForm(MyColor startColor, int startLineWidth, ShapeType startShapeType) : this()
        {
            this.startColor = startColor;
            this.startLineWidth = startLineWidth;
            this.startShapeType = startShapeType;
        }

        private void PaintingFormLoad(object sender, EventArgs e)
        {
            Painter = new WinFormsPictureBoxPainter(pictureBox, startShapeType, startColor, startLineWidth);

            PreviewColor(Painter.Color);

            ATextBox.Text = Painter.Color.A.ToString();
            RTextBox.Text = Painter.Color.R.ToString();
            GTextBox.Text = Painter.Color.G.ToString();
            BTextBox.Text = Painter.Color.B.ToString();

            LineWidthTextBox.Text = Painter.LineWidth.ToString();
        }

        #region ColorSelection
        private void PreviewColor(MyColor color)
        {
            if (color.IsValid)
                ColorPreview.BackColor = color.GetColor();
        }

        private void SetColorButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(ATextBox.Text, out int a))
                if (int.TryParse(RTextBox.Text, out int r))
                    if (int.TryParse(GTextBox.Text, out int g))
                        if (int.TryParse(BTextBox.Text, out int b))
                        {
                            var color = new MyColor(a, r, g, b);
                            if (color.IsValid)
                            {
                                Painter.Color = color;
                                PreviewColor(color);
                                return;
                            }
                        }
            MessageBox.Show("You must enter numbers in the range from 0 to 255");
        }
        #endregion

        #region LineWidthSelection
        private void SetLineWidthButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(LineWidthTextBox.Text, out int lineWidth) && lineWidth > 0)
                Painter.LineWidth = lineWidth;
            else
                MessageBox.Show("You must enter a positive number");
        }
        #endregion

        #region ShapeTypeSelection
        private void CustomShapeButton_Click(object sender, EventArgs e)
        {
            Painter.ShapeType = ShapeType.Custom;
        }

        private void LineButton_Click(object sender, EventArgs e)
        {
            Painter.ShapeType = ShapeType.Line;
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            Painter.ShapeType = ShapeType.Rectangle;
        }

        private void EllipseButton_Click(object sender, EventArgs e)
        {
            Painter.ShapeType = ShapeType.Ellipse;
        }
        #endregion

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Painter.CancelLastChange();
        }
    }
}
