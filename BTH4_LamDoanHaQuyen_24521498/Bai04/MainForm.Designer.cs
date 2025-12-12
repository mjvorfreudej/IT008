namespace Bai04
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.heThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taoVanBanMoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moTapTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luuNoiDungVanBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dinhDangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cboFont = new System.Windows.Forms.ToolStripComboBox();
            this.cboSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBold = new System.Windows.Forms.ToolStripButton();
            this.btnItalic = new System.Windows.Forms.ToolStripButton();
            this.btnUnderline = new System.Windows.Forms.ToolStripButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heThongToolStripMenuItem,
            this.dinhDangToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // heThongToolStripMenuItem
            // 
            this.heThongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taoVanBanMoiToolStripMenuItem,
            this.moTapTinToolStripMenuItem,
            this.luuNoiDungVanBanToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            this.heThongToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.heThongToolStripMenuItem.Text = "Hệ thống";
            // 
            // taoVanBanMoiToolStripMenuItem
            // 
            this.taoVanBanMoiToolStripMenuItem.Name = "taoVanBanMoiToolStripMenuItem";
            this.taoVanBanMoiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.taoVanBanMoiToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.taoVanBanMoiToolStripMenuItem.Text = "Tạo văn bản mới";
            this.taoVanBanMoiToolStripMenuItem.Click += new System.EventHandler(this.taoVanBanMoiToolStripMenuItem_Click);
            // 
            // moTapTinToolStripMenuItem
            // 
            this.moTapTinToolStripMenuItem.Name = "moTapTinToolStripMenuItem";
            this.moTapTinToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.moTapTinToolStripMenuItem.Text = "Mở tập tin";
            this.moTapTinToolStripMenuItem.Click += new System.EventHandler(this.moTapTinToolStripMenuItem_Click);
            // 
            // luuNoiDungVanBanToolStripMenuItem
            // 
            this.luuNoiDungVanBanToolStripMenuItem.Name = "luuNoiDungVanBanToolStripMenuItem";
            this.luuNoiDungVanBanToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.luuNoiDungVanBanToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.luuNoiDungVanBanToolStripMenuItem.Text = "Lưu nội dung văn bản";
            this.luuNoiDungVanBanToolStripMenuItem.Click += new System.EventHandler(this.luuNoiDungVanBanToolStripMenuItem_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // dinhDangToolStripMenuItem
            // 
            this.dinhDangToolStripMenuItem.Name = "dinhDangToolStripMenuItem";
            this.dinhDangToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.dinhDangToolStripMenuItem.Text = "Định dạng";
            this.dinhDangToolStripMenuItem.Click += new System.EventHandler(this.dinhDangToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnOpen,
            this.btnSave,
            this.toolStripSeparator1,
            this.cboFont,
            this.cboSize,
            this.toolStripSeparator2,
            this.btnBold,
            this.btnItalic,
            this.btnUnderline});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNew
            // 
            this.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(23, 22);
            this.btnNew.Text = "Tạo mới";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(23, 22);
            this.btnOpen.Text = "Mở";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(23, 22);
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // cboFont
            // 
            this.cboFont.Name = "cboFont";
            this.cboFont.Size = new System.Drawing.Size(200, 25);
            this.cboFont.SelectedIndexChanged += new System.EventHandler(this.cboFont_SelectedIndexChanged);
            // 
            // cboSize
            // 
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(75, 25);
            this.cboSize.SelectedIndexChanged += new System.EventHandler(this.cboSize_SelectedIndexChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnBold
            // 
            this.btnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnBold.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(23, 22);
            this.btnBold.Text = "B";
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnItalic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.btnItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(23, 22);
            this.btnItalic.Text = "I";
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnUnderline.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.btnUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(23, 22);
            this.btnUnderline.Text = "U";
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 49);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 401);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf|All Files (*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Rich Text Format (*.rtf)|*.rtf|Text Files (*.txt)|*.txt";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Soạn thảo văn bản";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem heThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taoVanBanMoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moTapTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem luuNoiDungVanBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dinhDangToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox cboFont;
        private System.Windows.Forms.ToolStripComboBox cboSize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnBold;
        private System.Windows.Forms.ToolStripButton btnItalic;
        private System.Windows.Forms.ToolStripButton btnUnderline;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

