using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Bai06
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InstalledFontCollection installedFonts = new InstalledFontCollection();
            
            foreach (FontFamily fontFamily in installedFonts.Families)
            {
                listBoxFonts.Items.Add(fontFamily.Name);
            }
        }

        private void listBoxFonts_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.DrawBackground();

            string fontName = listBoxFonts.Items[e.Index].ToString();

            try
            {
                using (Font font = new Font(fontName, 14))
                {
                    e.Graphics.DrawString("." + fontName, font, Brushes.Black, e.Bounds);
                }
            }
            catch
            {
                using (Font font = new Font("Arial", 14))
                {
                    e.Graphics.DrawString("." + fontName, font, Brushes.Black, e.Bounds);
                }
            }

            e.DrawFocusRectangle();
        }
    }
}
