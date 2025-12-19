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
            this.lblFont = new System.Windows.Forms.Label();
            this.cboFont = new System.Windows.Forms.ComboBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkUnderline = new System.Windows.Forms.CheckBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.grpAlign = new System.Windows.Forms.GroupBox();
            this.rdoRight = new System.Windows.Forms.RadioButton();
            this.rdoCenter = new System.Windows.Forms.RadioButton();
            this.rdoLeft = new System.Windows.Forms.RadioButton();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.grpAlign.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(40, 48);
            this.lblFont.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(55, 25);
            this.lblFont.TabIndex = 0;
            this.lblFont.Text = "Font";
            // 
            // cboFont
            // 
            this.cboFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFont.FormattingEnabled = true;
            this.cboFont.Location = new System.Drawing.Point(108, 42);
            this.cboFont.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboFont.Name = "cboFont";
            this.cboFont.Size = new System.Drawing.Size(296, 33);
            this.cboFont.TabIndex = 1;
            this.cboFont.SelectedIndexChanged += new System.EventHandler(this.cboFont_SelectedIndexChanged);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(440, 48);
            this.lblSize.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(54, 25);
            this.lblSize.TabIndex = 2;
            this.lblSize.Text = "Size";
            // 
            // cboSize
            // 
            this.cboSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Location = new System.Drawing.Point(506, 42);
            this.cboSize.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(156, 33);
            this.cboSize.TabIndex = 3;
            this.cboSize.SelectedIndexChanged += new System.EventHandler(this.cboSize_SelectedIndexChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBold.Location = new System.Drawing.Point(46, 115);
            this.chkBold.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(60, 30);
            this.chkBold.TabIndex = 4;
            this.chkBold.Text = "B";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkItalic.Location = new System.Drawing.Point(124, 115);
            this.chkItalic.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(50, 30);
            this.chkItalic.TabIndex = 5;
            this.chkItalic.Text = "I";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            // 
            // chkUnderline
            // 
            this.chkUnderline.AutoSize = true;
            this.chkUnderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUnderline.Location = new System.Drawing.Point(194, 115);
            this.chkUnderline.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkUnderline.Name = "chkUnderline";
            this.chkUnderline.Size = new System.Drawing.Size(60, 30);
            this.chkUnderline.TabIndex = 6;
            this.chkUnderline.Text = "U";
            this.chkUnderline.UseVisualStyleBackColor = true;
            this.chkUnderline.CheckedChanged += new System.EventHandler(this.chkUnderline_CheckedChanged);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(440, 117);
            this.lblColor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(63, 25);
            this.lblColor.TabIndex = 7;
            this.lblColor.Text = "Color";
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.DeepPink;
            this.btnColor.Location = new System.Drawing.Point(514, 108);
            this.btnColor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(80, 44);
            this.btnColor.TabIndex = 8;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // grpAlign
            // 
            this.grpAlign.Controls.Add(this.rdoRight);
            this.grpAlign.Controls.Add(this.rdoCenter);
            this.grpAlign.Controls.Add(this.rdoLeft);
            this.grpAlign.Location = new System.Drawing.Point(46, 183);
            this.grpAlign.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpAlign.Name = "grpAlign";
            this.grpAlign.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpAlign.Size = new System.Drawing.Size(240, 183);
            this.grpAlign.TabIndex = 9;
            this.grpAlign.TabStop = false;
            this.grpAlign.Text = "Align Text";
            // 
            // rdoRight
            // 
            this.rdoRight.AutoSize = true;
            this.rdoRight.Location = new System.Drawing.Point(30, 125);
            this.rdoRight.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdoRight.Name = "rdoRight";
            this.rdoRight.Size = new System.Drawing.Size(93, 29);
            this.rdoRight.TabIndex = 2;
            this.rdoRight.Text = "Right";
            this.rdoRight.UseVisualStyleBackColor = true;
            this.rdoRight.CheckedChanged += new System.EventHandler(this.rdoRight_CheckedChanged);
            // 
            // rdoCenter
            // 
            this.rdoCenter.AutoSize = true;
            this.rdoCenter.Location = new System.Drawing.Point(30, 81);
            this.rdoCenter.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdoCenter.Name = "rdoCenter";
            this.rdoCenter.Size = new System.Drawing.Size(107, 29);
            this.rdoCenter.TabIndex = 1;
            this.rdoCenter.Text = "Center";
            this.rdoCenter.UseVisualStyleBackColor = true;
            this.rdoCenter.CheckedChanged += new System.EventHandler(this.rdoCenter_CheckedChanged);
            // 
            // rdoLeft
            // 
            this.rdoLeft.AutoSize = true;
            this.rdoLeft.Checked = true;
            this.rdoLeft.Location = new System.Drawing.Point(30, 37);
            this.rdoLeft.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdoLeft.Name = "rdoLeft";
            this.rdoLeft.Size = new System.Drawing.Size(79, 29);
            this.rdoLeft.TabIndex = 0;
            this.rdoLeft.TabStop = true;
            this.rdoLeft.Text = "Left";
            this.rdoLeft.UseVisualStyleBackColor = true;
            this.rdoLeft.CheckedChanged += new System.EventHandler(this.rdoLeft_CheckedChanged);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.ForeColor = System.Drawing.Color.DeepPink;
            this.txtDisplay.Location = new System.Drawing.Point(320, 233);
            this.txtDisplay.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(436, 92);
            this.txtDisplay.TabIndex = 10;
            this.txtDisplay.Text = "Hello";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 406);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.grpAlign);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.chkUnderline);
            this.Controls.Add(this.chkItalic);
            this.Controls.Add(this.chkBold);
            this.Controls.Add(this.cboSize);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.cboFont);
            this.Controls.Add(this.lblFont);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MainForm";
            this.Text = "Font Formatter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpAlign.ResumeLayout(false);
            this.grpAlign.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.ComboBox cboFont;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkUnderline;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.GroupBox grpAlign;
        private System.Windows.Forms.RadioButton rdoRight;
        private System.Windows.Forms.RadioButton rdoCenter;
        private System.Windows.Forms.RadioButton rdoLeft;
        private System.Windows.Forms.TextBox txtDisplay;
    }
}

