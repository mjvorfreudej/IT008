using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai02
{
    public partial class MainForm : Form
    {
        private Random random = new Random();
        private Font textFont = new Font("Arial", 24, FontStyle.Bold);
        private Brush textBrush = Brushes.DarkBlue;

        public MainForm()
        {
            InitializeComponent();

            this.Text = "Minh hoạ sự kiện Paint";
            this.Size = new Size(800, 500);
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Paint += MainForm_Paint;

            Button btnRefresh = new Button()
            {
                Text = "Vẽ lại (Refresh)",
                Dock = DockStyle.Bottom,
                Height = 40
            };
            btnRefresh.Click += (_, __) => this.Invalidate();
            this.Controls.Add(btnRefresh);
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int x = random.Next(0, this.ClientSize.Width - 150);
            int y = random.Next(0, this.ClientSize.Height - 50);

            g.Clear(this.BackColor);
            g.DrawString($"Paint Event ({x},{y})", textFont, textBrush, x, y);
        }
    }
}
