namespace Bai06
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
            this.listBoxFonts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxFonts
            // 
            this.listBoxFonts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxFonts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxFonts.FormattingEnabled = true;
            this.listBoxFonts.ItemHeight = 30;
            this.listBoxFonts.Location = new System.Drawing.Point(24, 23);
            this.listBoxFonts.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxFonts.Name = "listBoxFonts";
            this.listBoxFonts.Size = new System.Drawing.Size(733, 844);
            this.listBoxFonts.TabIndex = 0;
            this.listBoxFonts.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxFonts_DrawItem);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 887);
            this.Controls.Add(this.listBoxFonts);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Fonts";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFonts;
    }
}

