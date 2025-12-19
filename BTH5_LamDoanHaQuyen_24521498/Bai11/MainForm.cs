using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Bai11
{
    public partial class MainForm : Form
    {
        private Bitmap bitmap;
        private Graphics graphics;
        private bool isDrawing = false;
        private Point startPoint;
        private Point endPoint;
        private Color penColor = Color.Black;
        private Bitmap tempBitmap;

        public MainForm()
        {
            InitializeComponent();
            InitializeBitmap();
        }

        private void InitializeBitmap()
        {
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            pictureBox.Image = bitmap;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                penColor = colorDialog.Color;
            }
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                startPoint = e.Location;
                endPoint = e.Location;
                tempBitmap = (Bitmap)bitmap.Clone();
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing && e.Button == MouseButtons.Left)
            {
                endPoint = e.Location;
                DrawPreview();
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                isDrawing = false;
                endPoint = e.Location;
                DrawFinalShape();
                if (tempBitmap != null)
                {
                    tempBitmap.Dispose();
                    tempBitmap = null;
                }
            }
        }

        private void DrawPreview()
        {
            Bitmap previewBitmap = (Bitmap)bitmap.Clone();
            using (Graphics g = Graphics.FromImage(previewBitmap))
            {
                DrawShapeOnGraphics(g, startPoint, endPoint);
            }
            pictureBox.Image = previewBitmap;
        }

        private void DrawFinalShape()
        {
            DrawShapeOnGraphics(graphics, startPoint, endPoint);
            pictureBox.Image = bitmap;
            pictureBox.Invalidate();
        }

        private void DrawShapeOnGraphics(Graphics g, Point start, Point end)
        {
            int width = 1;
            int.TryParse(txtWidth.Text, out width);
            if (width < 1) width = 1;

            if (rbLine.Checked)
            {
                using (Pen pen = new Pen(penColor, width))
                {
                    g.DrawLine(pen, start, end);
                }
            }
            else
            {
                Rectangle rect = GetRectangle(start, end);
                if (rect.Width > 0 && rect.Height > 0)
                {
                    using (Brush brush = GetSelectedBrush(rect))
                    {
                        if (rbRectangle.Checked)
                        {
                            g.FillRectangle(brush, rect);
                        }
                        else if (rbEllipse.Checked)
                        {
                            g.FillEllipse(brush, rect);
                        }
                    }
                }
            }
        }

        private Rectangle GetRectangle(Point start, Point end)
        {
            int x = Math.Min(start.X, end.X);
            int y = Math.Min(start.Y, end.Y);
            int width = Math.Abs(start.X - end.X);
            int height = Math.Abs(start.Y - end.Y);
            return new Rectangle(x, y, width, height);
        }

        private Brush GetSelectedBrush(Rectangle rect)
        {
            if (rbSolidBrush.Checked)
            {
                return new SolidBrush(Color.Green);
            }
            else if (rbHatchBrush.Checked)
            {
                return new HatchBrush(HatchStyle.Horizontal, Color.Blue, Color.Green);
            }
            else if (rbTextureBrush.Checked)
            {
                Bitmap textureBitmap = CreateTextureBitmap();
                return new TextureBrush(textureBitmap);
            }
            else if (rbLinearGradientBrush.Checked)
            {
                if (rect.Width > 0 && rect.Height > 0)
                {
                    return new LinearGradientBrush(rect, Color.Red, Color.Green, LinearGradientMode.Vertical);
                }
                else
                {
                    return new SolidBrush(Color.Green);
                }
            }
            return new SolidBrush(Color.Green);
        }

        private Bitmap CreateTextureBitmap()
        {
            Bitmap textureBmp = new Bitmap(24, 24);
            using (Graphics g = Graphics.FromImage(textureBmp))
            {
                g.Clear(Color.White);
                using (Pen pen = new Pen(Color.Blue, 1))
                {
                    g.DrawEllipse(pen, 2, 2, 20, 20);
                    g.DrawLine(pen, 2, 2, 22, 22);
                    g.DrawLine(pen, 22, 2, 2, 22);
                }
            }
            return textureBmp;
        }
    }
}