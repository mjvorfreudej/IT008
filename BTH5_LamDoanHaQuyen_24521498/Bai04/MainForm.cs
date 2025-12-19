using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai04
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
                cboFont.Items.Add(font.Name);
            cboFont.SelectedItem = "Arial";

            int[] sizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (int size in sizes)
                cboSize.Items.Add(size);
            cboSize.SelectedItem = 28;

            UpdateTextStyle();
        }

        private void cboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTextStyle();
        }

        private void cboSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTextStyle();
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTextStyle();
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTextStyle();
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTextStyle();
        }

        private void rdoLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLeft.Checked)
                txtDisplay.TextAlign = HorizontalAlignment.Left;
        }

        private void rdoCenter_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCenter.Checked)
                txtDisplay.TextAlign = HorizontalAlignment.Center;
        }

        private void rdoRight_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoRight.Checked)
                txtDisplay.TextAlign = HorizontalAlignment.Right;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    txtDisplay.ForeColor = colorDialog.Color;
                    btnColor.BackColor = colorDialog.Color;
                }
            }
        }

        private void UpdateTextStyle()
        {
            try
            {
                string fontName = cboFont.SelectedItem?.ToString() ?? "Arial";
                float fontSize = float.Parse(cboSize.SelectedItem?.ToString() ?? "28");
                FontStyle fontStyle = FontStyle.Regular;

                if (chkBold.Checked)
                    fontStyle |= FontStyle.Bold;
                if (chkItalic.Checked)
                    fontStyle |= FontStyle.Italic;
                if (chkUnderline.Checked)
                    fontStyle |= FontStyle.Underline;

                txtDisplay.Font = new Font(fontName, fontSize, fontStyle);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating font: " + ex.Message);
            }
        }
    }
}
