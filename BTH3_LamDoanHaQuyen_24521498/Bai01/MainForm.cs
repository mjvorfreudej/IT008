using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai01
{
    public partial class MainForm : Form
    {
        private ListBox lstLog;
        private Button btnClear;

        public MainForm()
        {
            InitializeComponent();
            InitUI();
            Log("Constructor");

            this.Load += MainForm_Load;
            this.Shown += MainForm_Shown;
            this.Activated += MainForm_Activated;
            this.Deactivate += MainForm_Deactivate;
            this.FormClosing += MainForm_FormClosing;
            this.FormClosed += MainForm_FormClosed;
            this.Resize += MainForm_Resize;
            this.HandleCreated += (_, __) => Log("HandleCreated");
            this.HandleDestroyed += (_, __) => Log("HandleDestroyed");
        }

        private void InitUI()
        {
            this.Text = "Minh họa vòng đời của Form";
            this.Size = new Size(800, 500);
            this.StartPosition = FormStartPosition.CenterScreen;

            lstLog = new ListBox
            {
                Dock = DockStyle.Fill,
                Font = new Font("Consolas", 10)
            };

            btnClear = new Button
            {
                Text = "Clear Log",
                Dock = DockStyle.Top,
                Height = 35
            };
            btnClear.Click += (_, __) => lstLog.Items.Clear();

            this.Controls.Add(lstLog);
            this.Controls.Add(btnClear);
        }

        private void Log(string msg)
        {
            string line = $"{DateTime.Now:HH:mm:ss.fff}  {msg}";
            lstLog.Items.Add(line);
            lstLog.TopIndex = lstLog.Items.Count - 1;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Log("Load");
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Log("Shown");
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            Log("Activated");
        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            Log("Deactivate");
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            Log($"Resize: {this.Size}");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Log("FormClosing");

            var result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
                Log("FormClosing: User chọn NO → Cancel = true");
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Log("FormClosed");
        }
    }
}
