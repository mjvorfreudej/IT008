namespace Bai11
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpShapes = new System.Windows.Forms.GroupBox();
            this.rbEllipse = new System.Windows.Forms.RadioButton();
            this.rbRectangle = new System.Windows.Forms.RadioButton();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.grpPen = new System.Windows.Forms.GroupBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.grpBrushes = new System.Windows.Forms.GroupBox();
            this.rbLinearGradientBrush = new System.Windows.Forms.RadioButton();
            this.rbTextureBrush = new System.Windows.Forms.RadioButton();
            this.rbHatchBrush = new System.Windows.Forms.RadioButton();
            this.rbSolidBrush = new System.Windows.Forms.RadioButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.grpShapes.SuspendLayout();
            this.grpPen.SuspendLayout();
            this.grpBrushes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // grpShapes
            // 
            this.grpShapes.Controls.Add(this.rbEllipse);
            this.grpShapes.Controls.Add(this.rbRectangle);
            this.grpShapes.Controls.Add(this.rbLine);
            this.grpShapes.Location = new System.Drawing.Point(12, 12);
            this.grpShapes.Name = "grpShapes";
            this.grpShapes.Size = new System.Drawing.Size(150, 100);
            this.grpShapes.TabIndex = 0;
            this.grpShapes.TabStop = false;
            this.grpShapes.Text = "Shapes";
            // 
            // rbEllipse
            // 
            this.rbEllipse.AutoSize = true;
            this.rbEllipse.Location = new System.Drawing.Point(15, 70);
            this.rbEllipse.Name = "rbEllipse";
            this.rbEllipse.Size = new System.Drawing.Size(55, 17);
            this.rbEllipse.TabIndex = 2;
            this.rbEllipse.Text = "Ellipse";
            this.rbEllipse.UseVisualStyleBackColor = true;
            // 
            // rbRectangle
            // 
            this.rbRectangle.AutoSize = true;
            this.rbRectangle.Location = new System.Drawing.Point(15, 46);
            this.rbRectangle.Name = "rbRectangle";
            this.rbRectangle.Size = new System.Drawing.Size(74, 17);
            this.rbRectangle.TabIndex = 1;
            this.rbRectangle.Text = "Rectangle";
            this.rbRectangle.UseVisualStyleBackColor = true;
            // 
            // rbLine
            // 
            this.rbLine.AutoSize = true;
            this.rbLine.Checked = true;
            this.rbLine.Location = new System.Drawing.Point(15, 22);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(45, 17);
            this.rbLine.TabIndex = 0;
            this.rbLine.TabStop = true;
            this.rbLine.Text = "Line";
            this.rbLine.UseVisualStyleBackColor = true;
            // 
            // grpPen
            // 
            this.grpPen.Controls.Add(this.btnColor);
            this.grpPen.Controls.Add(this.txtWidth);
            this.grpPen.Controls.Add(this.lblWidth);
            this.grpPen.Location = new System.Drawing.Point(12, 118);
            this.grpPen.Name = "grpPen";
            this.grpPen.Size = new System.Drawing.Size(150, 85);
            this.grpPen.TabIndex = 1;
            this.grpPen.TabStop = false;
            this.grpPen.Text = "Pen";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(15, 50);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(100, 25);
            this.btnColor.TabIndex = 2;
            this.btnColor.Text = "Color...";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(60, 22);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(55, 20);
            this.txtWidth.TabIndex = 1;
            this.txtWidth.Text = "1";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(15, 25);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(38, 13);
            this.lblWidth.TabIndex = 0;
            this.lblWidth.Text = "Width:";
            // 
            // grpBrushes
            // 
            this.grpBrushes.Controls.Add(this.rbLinearGradientBrush);
            this.grpBrushes.Controls.Add(this.rbTextureBrush);
            this.grpBrushes.Controls.Add(this.rbHatchBrush);
            this.grpBrushes.Controls.Add(this.rbSolidBrush);
            this.grpBrushes.Location = new System.Drawing.Point(12, 209);
            this.grpBrushes.Name = "grpBrushes";
            this.grpBrushes.Size = new System.Drawing.Size(150, 125);
            this.grpBrushes.TabIndex = 2;
            this.grpBrushes.TabStop = false;
            this.grpBrushes.Text = "Brushes";
            // 
            // rbLinearGradientBrush
            // 
            this.rbLinearGradientBrush.AutoSize = true;
            this.rbLinearGradientBrush.Location = new System.Drawing.Point(15, 95);
            this.rbLinearGradientBrush.Name = "rbLinearGradientBrush";
            this.rbLinearGradientBrush.Size = new System.Drawing.Size(121, 17);
            this.rbLinearGradientBrush.TabIndex = 3;
            this.rbLinearGradientBrush.Text = "LinearGradientBrush";
            this.rbLinearGradientBrush.UseVisualStyleBackColor = true;
            // 
            // rbTextureBrush
            // 
            this.rbTextureBrush.AutoSize = true;
            this.rbTextureBrush.Location = new System.Drawing.Point(15, 71);
            this.rbTextureBrush.Name = "rbTextureBrush";
            this.rbTextureBrush.Size = new System.Drawing.Size(88, 17);
            this.rbTextureBrush.TabIndex = 2;
            this.rbTextureBrush.Text = "TextureBrush";
            this.rbTextureBrush.UseVisualStyleBackColor = true;
            // 
            // rbHatchBrush
            // 
            this.rbHatchBrush.AutoSize = true;
            this.rbHatchBrush.Location = new System.Drawing.Point(15, 47);
            this.rbHatchBrush.Name = "rbHatchBrush";
            this.rbHatchBrush.Size = new System.Drawing.Size(81, 17);
            this.rbHatchBrush.TabIndex = 1;
            this.rbHatchBrush.Text = "HatchBrush";
            this.rbHatchBrush.UseVisualStyleBackColor = true;
            // 
            // rbSolidBrush
            // 
            this.rbSolidBrush.AutoSize = true;
            this.rbSolidBrush.Checked = true;
            this.rbSolidBrush.Location = new System.Drawing.Point(15, 23);
            this.rbSolidBrush.Name = "rbSolidBrush";
            this.rbSolidBrush.Size = new System.Drawing.Size(76, 17);
            this.rbSolidBrush.TabIndex = 0;
            this.rbSolidBrush.TabStop = true;
            this.rbSolidBrush.Text = "SolidBrush";
            this.rbSolidBrush.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(168, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(604, 419);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 443);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.grpBrushes);
            this.Controls.Add(this.grpPen);
            this.Controls.Add(this.grpShapes);
            this.Name = "MainForm";
            this.Text = "Bai Thi";
            this.grpShapes.ResumeLayout(false);
            this.grpShapes.PerformLayout();
            this.grpPen.ResumeLayout(false);
            this.grpPen.PerformLayout();
            this.grpBrushes.ResumeLayout(false);
            this.grpBrushes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpShapes;
        private System.Windows.Forms.RadioButton rbEllipse;
        private System.Windows.Forms.RadioButton rbRectangle;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.GroupBox grpPen;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.GroupBox grpBrushes;
        private System.Windows.Forms.RadioButton rbLinearGradientBrush;
        private System.Windows.Forms.RadioButton rbTextureBrush;
        private System.Windows.Forms.RadioButton rbHatchBrush;
        private System.Windows.Forms.RadioButton rbSolidBrush;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}