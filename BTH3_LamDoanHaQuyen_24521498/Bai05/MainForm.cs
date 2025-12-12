using System;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

namespace Bai05
{
    public partial class MainForm : Form
    {
        private TextBox txtA, txtB, txtAns;
        private Button btnAdd, btnSub, btnMul, btnDiv;

        public MainForm()
        {
            InitializeComponent();

            Text = "Lab02-Example";
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(520, 330);

            var root = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 3,
                RowCount = 5,
                Padding = new Padding(30)
            };
            root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));
            root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            root.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            root.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            root.RowStyles.Add(new RowStyle(SizeType.Absolute, 70));
            root.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            root.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            Controls.Add(root);

            var lblA = new Label
            {
                Text = "Number 1",
                AutoSize = true,
                Anchor = AnchorStyles.Left,
                Font = new Font(Font, FontStyle.Regular)
            };
            txtA = new TextBox
            {
                Anchor = AnchorStyles.Left | AnchorStyles.Right
            };
            root.Controls.Add(lblA, 0, 0);
            root.SetColumnSpan(txtA, 2);
            root.Controls.Add(txtA, 1, 0);

            var lblB = new Label
            {
                Text = "Number 2",
                AutoSize = true,
                Anchor = AnchorStyles.Left
            };
            txtB = new TextBox
            {
                Anchor = AnchorStyles.Left | AnchorStyles.Right
            };
            root.Controls.Add(lblB, 0, 1);
            root.SetColumnSpan(txtB, 2);
            root.Controls.Add(txtB, 1, 1);

            var pnlButtons = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.LeftToRight,
                Anchor = AnchorStyles.None,
                AutoSize = true,
                WrapContents = false
            };

            btnAdd = MakeOpButton("+");
            btnSub = MakeOpButton("-");
            btnMul = MakeOpButton("×");
            btnDiv = MakeOpButton("÷");

            pnlButtons.Controls.AddRange(new Control[] { btnAdd, btnSub, btnMul, btnDiv });
            root.SetColumnSpan(pnlButtons, 3);
            root.Controls.Add(pnlButtons, 0, 2);

            var lblAns = new Label
            {
                Text = "Answer",
                AutoSize = true,
                Anchor = AnchorStyles.Left
            };
            txtAns = new TextBox
            {
                Anchor = AnchorStyles.Left | AnchorStyles.Right,
                ReadOnly = true
            };
            root.Controls.Add(lblAns, 0, 3);
            root.SetColumnSpan(txtAns, 2);
            root.Controls.Add(txtAns, 1, 3);

            txtA.KeyDown += EnterToCalculate;
            txtB.KeyDown += EnterToCalculate;
        }

        private Button MakeOpButton(string text)
        {
            var b = new Button
            {
                Text = text,
                Width = 60,
                Height = 36,
                Margin = new Padding(18)
            };
            b.Tag = text;
            b.Click += Calc_Click;
            return b;
        }

        private void EnterToCalculate(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void Calc_Click(object sender, EventArgs e)
        {
            if (!TryReadInputs(out double a, out double b)) return;

            string op = (string)((Button)sender).Tag;
            double result;

            try
            {
                switch (op)
                {
                    case "+":
                        result = a + b;
                        break;
                    case "-":
                        result = a - b;
                        break;
                    case "x":
                        result = a * b;
                        break;
                    case "÷":
                        if (b == 0)
                        {
                            MessageBox.Show("Không thể chia cho 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        result = a / b;
                        break;
                    default:
                        return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tính toán: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtAns.Text = result.ToString(CultureInfo.InvariantCulture);
        }

        private bool TryReadInputs(out double a, out double b)
        {
            var style = NumberStyles.Float | NumberStyles.AllowThousands;
            var culture = CultureInfo.InvariantCulture;

            if (!double.TryParse(txtA.Text.Trim().Replace(',', '.'), style, culture, out a))
            {
                MessageBox.Show("Vui lòng nhập Number 1 hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtA.Focus(); b = 0; return false;
            }
            if (!double.TryParse(txtB.Text.Trim().Replace(',', '.'), style, culture, out b))
            {
                MessageBox.Show("Vui lòng nhập Number 2 hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtB.Focus(); return false;
            }
            return true;
        }
    }
}