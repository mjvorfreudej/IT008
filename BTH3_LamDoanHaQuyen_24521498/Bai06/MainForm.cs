using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Bai06
{
    public partial class MainForm : Form
    {
        const int L = 10;
        const int T = 90;
        const int G = 6;
        const int W = 45;
        const int H = 28;

        static int ColX(int c) => L + c * (W + G);
        static int RowY(int r) => T + r * (H + G);

        public MainForm()
        {
            InitializeComponent();

            Text = "Calculator";
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;

            AutoScaleMode = AutoScaleMode.None;
            AutoScaleDimensions = new SizeF(96f, 96f);
            Font = new Font("Microsoft Sans Serif", 8.25f);

            ClientSize = new Size(ColX(5) + W + L - 2, RowY(4) + H + L);

            var menu = new MenuStrip();
            var mEdit = new ToolStripMenuItem("&Edit");
            var mView = new ToolStripMenuItem("&View");
            var mHelp = new ToolStripMenuItem("&Help");
            menu.Items.AddRange(new ToolStripMenuItem[] { mEdit, mView, mHelp });
            MainMenuStrip = menu;
            Controls.Add(menu);

            var txtDisplay = new TextBox
            {
                ReadOnly = true,
                TabStop = false,
                Text = "0.",
                TextAlign = HorizontalAlignment.Right,
                Font = new Font("Microsoft Sans Serif", 12f),
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(L, 30),
                Size = new Size(ColX(5) + W - L, 26)
            };
            Controls.Add(txtDisplay);

            Controls.Add(new TextBox
            {
                Enabled = false,
                BackColor = SystemColors.Control,
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(L, 60),
                Size = new Size(36, 20)
            });

            Button MakeBtn(string text, int x, int y, Color color, int w = W, int h = H)
            {
                var b = new Button
                {
                    Text = text,
                    ForeColor = color,
                    Location = new Point(x, y),
                    Size = new Size(w, h),
                    TabStop = false,
                    UseVisualStyleBackColor = true
                };
                Controls.Add(b);
                return b;
            }

            string[] redButtons = { "MC", "MR", "MS", "M+", "Backspace", "CE", "C", "*", "-", "+", "=", "/" };

            Color ColorFor(string text) =>
                redButtons.Contains(text) ? Color.Red : Color.Blue;

            MakeBtn("Backspace", ColX(1), RowY(-1), ColorFor("Backspace"), w: (W * 2 + G));
            int spaceStart = ColX(3);
            int spaceEnd = ColX(5) + W;
            int widthEach = (spaceEnd - spaceStart - G) / 2;
            MakeBtn("CE", spaceStart, RowY(-1), ColorFor("CE"), w: widthEach);
            MakeBtn("C", spaceStart + widthEach + G, RowY(-1), ColorFor("C"), w: widthEach);

            MakeBtn("MC", ColX(0), RowY(0), ColorFor("MC"));
            MakeBtn("MR", ColX(0), RowY(1), ColorFor("MR"));
            MakeBtn("MS", ColX(0), RowY(2), ColorFor("MS"));
            MakeBtn("M+", ColX(0), RowY(3), ColorFor("M+"));

            MakeBtn("7", ColX(1), RowY(0), ColorFor("7"));
            MakeBtn("8", ColX(2), RowY(0), ColorFor("8"));
            MakeBtn("9", ColX(3), RowY(0), ColorFor("9"));
            MakeBtn("/", ColX(4), RowY(0), ColorFor("/"));
            MakeBtn("sqrt", ColX(5), RowY(0), ColorFor("sqrt"));

            MakeBtn("4", ColX(1), RowY(1), ColorFor("4"));
            MakeBtn("5", ColX(2), RowY(1), ColorFor("5"));
            MakeBtn("6", ColX(3), RowY(1), ColorFor("6"));
            MakeBtn("*", ColX(4), RowY(1), ColorFor("*"));
            MakeBtn("%", ColX(5), RowY(1), ColorFor("%"));

            MakeBtn("1", ColX(1), RowY(2), ColorFor("1"));
            MakeBtn("2", ColX(2), RowY(2), ColorFor("2"));
            MakeBtn("3", ColX(3), RowY(2), ColorFor("3"));
            MakeBtn("-", ColX(4), RowY(2), ColorFor("-"));
            MakeBtn("1/x", ColX(5), RowY(2), ColorFor("1/x"));

            MakeBtn("0", ColX(1), RowY(3), ColorFor("0"));
            MakeBtn("+/-", ColX(2), RowY(3), ColorFor("+/-"));
            MakeBtn(".", ColX(3), RowY(3), ColorFor("."));
            MakeBtn("+", ColX(4), RowY(3), ColorFor("+"));
            MakeBtn("=", ColX(5), RowY(3), ColorFor("="));
        }
    }
}