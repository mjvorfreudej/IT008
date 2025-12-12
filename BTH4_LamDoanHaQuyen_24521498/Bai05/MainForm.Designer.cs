using System.Windows.Forms;

namespace Bai05
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuChucNang;
        private ToolStripMenuItem mnuThemMoi;
        private ToolStripMenuItem mnuThoat;

        private ToolStrip toolStrip1;
        private ToolStripButton btnThemMoi;
        private ToolStripLabel lblTimKiem;
        private ToolStripTextBox txtTimKiem;

        private DataGridView dgvSinhVien;
        private DataGridViewTextBoxColumn colSTT;
        private DataGridViewTextBoxColumn colMaSV;
        private DataGridViewTextBoxColumn colTenSV;
        private DataGridViewTextBoxColumn colKhoa;
        private DataGridViewTextBoxColumn colDiemTB;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThemMoi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThemMoi = new System.Windows.Forms.ToolStripButton();
            this.lblTimKiem = new System.Windows.Forms.ToolStripLabel();
            this.txtTimKiem = new System.Windows.Forms.ToolStripTextBox();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChucNang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            // 
            // mnuChucNang
            // 
            this.mnuChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThemMoi,
            this.mnuThoat});
            this.mnuChucNang.Name = "mnuChucNang";
            this.mnuChucNang.Size = new System.Drawing.Size(77, 20);
            this.mnuChucNang.Text = "Chức năng";
            // 
            // mnuThemMoi
            // 
            this.mnuThemMoi.Name = "mnuThemMoi";
            this.mnuThemMoi.ShortcutKeys = ((System.Windows.Forms.Keys)
                ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuThemMoi.Size = new System.Drawing.Size(185, 22);
            this.mnuThemMoi.Text = "Thêm mới";
            this.mnuThemMoi.Click += new System.EventHandler(this.mnuThemMoi_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(185, 22);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemMoi,
            this.lblTimKiem,
            this.txtTimKiem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.btnThemMoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(85, 22);
            this.btnThemMoi.Text = "Thêm Mới";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.Margin = new System.Windows.Forms.Padding(50, 1, 0, 2);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(102, 22);
            this.lblTimKiem.Text = "Tìm Kiếm Theo Tên";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(200, 25);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.AllowUserToDeleteRows = false;
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMaSV,
            this.colTenSV,
            this.colKhoa,
            this.colDiemTB});
            this.dgvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSinhVien.Location = new System.Drawing.Point(0, 49);
            this.dgvSinhVien.MultiSelect = false;
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.RowHeadersVisible = true;
            this.dgvSinhVien.RowHeadersWidth = 30;
            this.dgvSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSinhVien.Size = new System.Drawing.Size(800, 401);
            this.dgvSinhVien.TabIndex = 2;
            // 
            // colSTT
            // 
            this.colSTT.HeaderText = "Số TT";
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            this.colSTT.Width = 60;
            // 
            // colMaSV
            // 
            this.colMaSV.DataPropertyName = "MaSV";
            this.colMaSV.HeaderText = "Mã Số SV";
            this.colMaSV.Name = "colMaSV";
            this.colMaSV.ReadOnly = true;
            // 
            // colTenSV
            // 
            this.colTenSV.DataPropertyName = "TenSV";
            this.colTenSV.HeaderText = "Tên Sinh Viên";
            this.colTenSV.Name = "colTenSV";
            this.colTenSV.ReadOnly = true;
            // 
            // colKhoa
            // 
            this.colKhoa.DataPropertyName = "Khoa";
            this.colKhoa.HeaderText = "Khoa";
            this.colKhoa.Name = "colKhoa";
            this.colKhoa.ReadOnly = true;
            // 
            // colDiemTB
            // 
            this.colDiemTB.DataPropertyName = "DiemTB";
            this.colDiemTB.HeaderText = "Điểm TB";
            this.colDiemTB.Name = "colDiemTB";
            this.colDiemTB.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
