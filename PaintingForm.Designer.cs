namespace PainterApp
{
    partial class PaintingForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.ATextBox = new System.Windows.Forms.TextBox();
            this.RTextBox = new System.Windows.Forms.TextBox();
            this.GTextBox = new System.Windows.Forms.TextBox();
            this.BTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SetColorButton = new System.Windows.Forms.Button();
            this.LineWidthTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SetLineWidthButton = new System.Windows.Forms.Button();
            this.EllipseButton = new System.Windows.Forms.Button();
            this.RectangleButton = new System.Windows.Forms.Button();
            this.LineButton = new System.Windows.Forms.Button();
            this.CustomShapeButton = new System.Windows.Forms.Button();
            this.ColorPreview = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPreview)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(79, 5);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(620, 476);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // ATextBox
            // 
            this.ATextBox.Location = new System.Drawing.Point(26, 47);
            this.ATextBox.Name = "ATextBox";
            this.ATextBox.Size = new System.Drawing.Size(47, 20);
            this.ATextBox.TabIndex = 1;
            // 
            // RTextBox
            // 
            this.RTextBox.Location = new System.Drawing.Point(26, 74);
            this.RTextBox.Name = "RTextBox";
            this.RTextBox.Size = new System.Drawing.Size(47, 20);
            this.RTextBox.TabIndex = 2;
            // 
            // GTextBox
            // 
            this.GTextBox.Location = new System.Drawing.Point(26, 101);
            this.GTextBox.Name = "GTextBox";
            this.GTextBox.Size = new System.Drawing.Size(47, 20);
            this.GTextBox.TabIndex = 3;
            // 
            // BTextBox
            // 
            this.BTextBox.Location = new System.Drawing.Point(26, 128);
            this.BTextBox.Name = "BTextBox";
            this.BTextBox.Size = new System.Drawing.Size(47, 20);
            this.BTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "R:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "G:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "B:";
            // 
            // SetColorButton
            // 
            this.SetColorButton.Location = new System.Drawing.Point(6, 155);
            this.SetColorButton.Name = "SetColorButton";
            this.SetColorButton.Size = new System.Drawing.Size(67, 23);
            this.SetColorButton.TabIndex = 9;
            this.SetColorButton.Text = "Apply";
            this.SetColorButton.UseVisualStyleBackColor = true;
            this.SetColorButton.Click += new System.EventHandler(this.SetColorButton_Click);
            // 
            // LineWidthTextBox
            // 
            this.LineWidthTextBox.Location = new System.Drawing.Point(7, 211);
            this.LineWidthTextBox.Name = "LineWidthTextBox";
            this.LineWidthTextBox.Size = new System.Drawing.Size(66, 20);
            this.LineWidthTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Line Width:";
            // 
            // SetLineWidthButton
            // 
            this.SetLineWidthButton.Location = new System.Drawing.Point(6, 238);
            this.SetLineWidthButton.Name = "SetLineWidthButton";
            this.SetLineWidthButton.Size = new System.Drawing.Size(67, 23);
            this.SetLineWidthButton.TabIndex = 12;
            this.SetLineWidthButton.Text = "Apply";
            this.SetLineWidthButton.UseVisualStyleBackColor = true;
            this.SetLineWidthButton.Click += new System.EventHandler(this.SetLineWidthButton_Click);
            // 
            // EllipseButton
            // 
            this.EllipseButton.Location = new System.Drawing.Point(-1, 90);
            this.EllipseButton.Name = "EllipseButton";
            this.EllipseButton.Size = new System.Drawing.Size(67, 23);
            this.EllipseButton.TabIndex = 13;
            this.EllipseButton.Text = "Ellipse";
            this.EllipseButton.UseVisualStyleBackColor = true;
            this.EllipseButton.Click += new System.EventHandler(this.EllipseButton_Click);
            // 
            // RectangleButton
            // 
            this.RectangleButton.Location = new System.Drawing.Point(-1, 61);
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Size = new System.Drawing.Size(67, 23);
            this.RectangleButton.TabIndex = 14;
            this.RectangleButton.Text = "Rectangle";
            this.RectangleButton.UseVisualStyleBackColor = true;
            this.RectangleButton.Click += new System.EventHandler(this.RectangleButton_Click);
            // 
            // LineButton
            // 
            this.LineButton.Location = new System.Drawing.Point(0, 32);
            this.LineButton.Name = "LineButton";
            this.LineButton.Size = new System.Drawing.Size(66, 23);
            this.LineButton.TabIndex = 15;
            this.LineButton.Text = "Line";
            this.LineButton.UseVisualStyleBackColor = true;
            this.LineButton.Click += new System.EventHandler(this.LineButton_Click);
            // 
            // CustomShapeButton
            // 
            this.CustomShapeButton.Location = new System.Drawing.Point(0, 3);
            this.CustomShapeButton.Name = "CustomShapeButton";
            this.CustomShapeButton.Size = new System.Drawing.Size(66, 23);
            this.CustomShapeButton.TabIndex = 16;
            this.CustomShapeButton.Text = "Pencil";
            this.CustomShapeButton.UseVisualStyleBackColor = true;
            this.CustomShapeButton.Click += new System.EventHandler(this.CustomShapeButton_Click);
            // 
            // ColorPreview
            // 
            this.ColorPreview.BackColor = System.Drawing.SystemColors.Control;
            this.ColorPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorPreview.Location = new System.Drawing.Point(6, 21);
            this.ColorPreview.Name = "ColorPreview";
            this.ColorPreview.Size = new System.Drawing.Size(67, 20);
            this.ColorPreview.TabIndex = 17;
            this.ColorPreview.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Color:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.CustomShapeButton);
            this.panel1.Controls.Add(this.LineButton);
            this.panel1.Controls.Add(this.RectangleButton);
            this.panel1.Controls.Add(this.EllipseButton);
            this.panel1.Location = new System.Drawing.Point(6, 367);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(67, 115);
            this.panel1.TabIndex = 19;
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CancelButton.Location = new System.Drawing.Point(6, 301);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(66, 23);
            this.CancelButton.TabIndex = 20;
            this.CancelButton.Text = "Step back";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // PaintingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 484);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ColorPreview);
            this.Controls.Add(this.SetLineWidthButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LineWidthTextBox);
            this.Controls.Add(this.SetColorButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTextBox);
            this.Controls.Add(this.GTextBox);
            this.Controls.Add(this.RTextBox);
            this.Controls.Add(this.ATextBox);
            this.Controls.Add(this.pictureBox);
            this.MinimumSize = new System.Drawing.Size(200, 500);
            this.Name = "PaintingForm";
            this.Text = "Painter";
            this.Load += new System.EventHandler(this.PaintingFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPreview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox ATextBox;
        private System.Windows.Forms.TextBox RTextBox;
        private System.Windows.Forms.TextBox GTextBox;
        private System.Windows.Forms.TextBox BTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SetColorButton;
        private System.Windows.Forms.TextBox LineWidthTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SetLineWidthButton;
        private System.Windows.Forms.Button EllipseButton;
        private System.Windows.Forms.Button RectangleButton;
        private System.Windows.Forms.Button LineButton;
        private System.Windows.Forms.Button CustomShapeButton;
        private System.Windows.Forms.PictureBox ColorPreview;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CancelButton;
    }
}

