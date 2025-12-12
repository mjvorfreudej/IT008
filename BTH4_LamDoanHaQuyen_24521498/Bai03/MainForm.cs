using System;
using System.Windows.Forms;
using AxWMPLib;

namespace Bai03
{
    public partial class MainForm : Form
    {
        public class MediaFile
        {
            public string FileName { get; set; }
            public string Path { get; set;  }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timerDateTime.Start();
            UpdateDateTimeStatus();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn tập tin media";
                ofd.Filter =
                    "Media Files|*.avi;*.mpeg;*.wav;*.midi;*.mp4;*.mp3|Video Files|*.avi;*.mpeg;*.mp4|Audio Files|*.wav;*.midi;*.mp3|All Files|*.*";
                ofd.Multiselect = false;
                if (ofd.ShowDialog(this) == DialogResult.OK)
                {
                    axWindowsMediaPlayer1.URL = ofd.FileName;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }
        }

        public void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void timerDateTime_Tick(object sender, EventArgs e)
        {
            UpdateDateTimeStatus();
        }

        public void UpdateDateTimeStatus()
        {
            if (toolStripStatusLabelDateTime != null)
                toolStripStatusLabelDateTime.Text = $"Hôm nay là ngày {DateTime.Now:dd/MM/yyyy} - Bây giờ là {DateTime.Now:HH:mm:ss}";
        }
    }
}
