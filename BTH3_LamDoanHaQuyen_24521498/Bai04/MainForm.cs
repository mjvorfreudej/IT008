using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai04
{
    public partial class MainForm : Form
    {
        private MenuStrip menuStrip;
        private ToolStripMenuItem formatMenu;
        private ToolStripMenuItem colorMenuItem;
        private ColorDialog colorDialog;

        public MainForm()
        {
            InitializeComponent();

            this.Text = "Minh hoạ Menu và ColorDialog";
            this.Size = new Size(500, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.Beige;

            menuStrip = new MenuStrip();
            formatMenu = new ToolStripMenuItem("Format");
            colorMenuItem = new ToolStripMenuItem("Color");
            colorMenuItem.Click += ColorMenuItem_Click;
            formatMenu.DropDownItems.Add(colorMenuItem);
            menuStrip.Items.Add(formatMenu);
            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);
            colorDialog = new ColorDialog();
        }

        private void ColorMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
                this.BackColor = colorDialog.Color;
        }
    }
}