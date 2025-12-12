using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace Bai06
{
    public partial class MainForm : Form
    {
        private string[] filesToCopy;
        private string sourcePath;
        private string destinationPath;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBrowseSource_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.Description = "Chọn thư mục nguồn";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtSource.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnBrowseDestination_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.Description = "Chọn thư mục đích";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtDestination.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            sourcePath = txtSource.Text.Trim();
            destinationPath = txtDestination.Text.Trim();

            // Kiểm tra thư mục nguồn
            if (string.IsNullOrEmpty(sourcePath))
            {
                MessageBox.Show("Vui lòng chọn thư mục nguồn!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Directory.Exists(sourcePath))
            {
                MessageBox.Show("Thư mục nguồn không tồn tại!", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra thư mục đích
            if (string.IsNullOrEmpty(destinationPath))
            {
                MessageBox.Show("Vui lòng chọn thư mục đích!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo thư mục đích nếu chưa tồn tại
            if (!Directory.Exists(destinationPath))
            {
                try
                {
                    Directory.CreateDirectory(destinationPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tạo thư mục đích: " + ex.Message, "Lỗi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Lấy danh sách tất cả các file trong thư mục nguồn
            filesToCopy = Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories);

            if (filesToCopy.Length == 0)
            {
                MessageBox.Show("Thư mục nguồn không có tập tin nào!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Thiết lập ProgressBar
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            progressBar.Value = 0;

            // Vô hiệu hóa các nút trong khi sao chép
            btnCopy.Enabled = false;
            btnBrowseSource.Enabled = false;
            btnBrowseDestination.Enabled = false;

            // Bắt đầu sao chép trong background
            backgroundWorker.RunWorkerAsync();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            int totalFiles = filesToCopy.Length;

            for (int i = 0; i < totalFiles; i++)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                string sourceFile = filesToCopy[i];
                string relativePath = sourceFile.Substring(sourcePath.Length).TrimStart('\\');
                string destFile = Path.Combine(destinationPath, relativePath);

                // Tạo thư mục con nếu cần
                string destDir = Path.GetDirectoryName(destFile);
                if (!Directory.Exists(destDir))
                {
                    Directory.CreateDirectory(destDir);
                }

                // Sao chép file
                try
                {
                    File.Copy(sourceFile, destFile, true);
                }
                catch (Exception)
                {
                    // Bỏ qua lỗi và tiếp tục với file tiếp theo
                }

                // Báo cáo tiến trình
                int progress = (int)(((double)(i + 1) / totalFiles) * 100);
                worker.ReportProgress(progress, sourceFile);

                // Delay nhỏ để có thể thấy được tiến trình
                System.Threading.Thread.Sleep(50);
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            string currentFile = e.UserState as string;
            
            if (!string.IsNullOrEmpty(currentFile))
            {
                lblStatus.Text = "Đang sao chép: " + currentFile;
                toolTip.SetToolTip(progressBar, "Đang sao chép: " + currentFile);
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Kích hoạt lại các nút
            btnCopy.Enabled = true;
            btnBrowseSource.Enabled = true;
            btnBrowseDestination.Enabled = true;

            if (e.Cancelled)
            {
                lblStatus.Text = "Đã hủy sao chép!";
                MessageBox.Show("Quá trình sao chép đã bị hủy!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (e.Error != null)
            {
                lblStatus.Text = "Lỗi sao chép!";
                MessageBox.Show("Có lỗi xảy ra: " + e.Error.Message, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblStatus.Text = "Hoàn thành sao chép!";
                toolTip.SetToolTip(progressBar, "Hoàn thành!");
                MessageBox.Show("Sao chép hoàn tất!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
