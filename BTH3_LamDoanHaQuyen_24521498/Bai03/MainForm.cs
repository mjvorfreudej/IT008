using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai03
{
    public partial class MainForm : Form
    {
        private Button btnChangeColor;
        private Random random = new Random();

        public MainForm()
        {
            InitializeComponent();

            this.Text = "Minh hoạ sự kiện Click trên Button";
            this.Size = new Size(400, 300);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.Beige;

            btnChangeColor = new Button()
            {
                Text = "Change Color",
                Size = new Size(120, 40),
                Location = new Point((this.ClientSize.Width - 120) / 2, (this.ClientSize.Height - 40) / 2)
            };

            btnChangeColor.Click += BtnChangeColor_Click;
            this.Controls.Add(btnChangeColor);
        }

        private void BtnChangeColor_Click(object sender, EventArgs e)
        {
            Color newColor = Color.FromArgb(
                random.Next(256),
                random.Next(256),
                random.Next(256));
            this.BackColor = newColor;
        }
    }
}
