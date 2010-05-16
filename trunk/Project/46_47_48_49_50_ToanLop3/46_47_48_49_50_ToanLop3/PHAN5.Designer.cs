namespace _46_47_48_49_50_ToanLop3
{
    partial class PHAN5
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ChonBai = new System.Windows.Forms.ToolStripMenuItem();
            this.bài1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bài2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bài1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bài2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChonBai});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ChonBai
            // 
            this.ChonBai.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bài1ToolStripMenuItem,
            this.bài2ToolStripMenuItem});
            this.ChonBai.Name = "ChonBai";
            this.ChonBai.Size = new System.Drawing.Size(70, 20);
            this.ChonBai.Text = "Chọn bài ";
            this.ChonBai.Click += new System.EventHandler(this.chọnBàiToolStripMenuItem_Click);
            // 
            // bài1ToolStripMenuItem
            // 
            this.bài1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bài1ToolStripMenuItem1,
            this.bài2ToolStripMenuItem1});
            this.bài1ToolStripMenuItem.Name = "bài1ToolStripMenuItem";
            this.bài1ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.bài1ToolStripMenuItem.Text = "Các số đến 100 000";
            this.bài1ToolStripMenuItem.Click += new System.EventHandler(this.bài1ToolStripMenuItem_Click_1);
            // 
            // bài2ToolStripMenuItem
            // 
            this.bài2ToolStripMenuItem.Name = "bài2ToolStripMenuItem";
            this.bài2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bài2ToolStripMenuItem.Text = "Bài 2";
            // 
            // bài1ToolStripMenuItem1
            // 
            this.bài1ToolStripMenuItem1.Name = "bài1ToolStripMenuItem1";
            this.bài1ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.bài1ToolStripMenuItem1.Text = "Bài 1";
            this.bài1ToolStripMenuItem1.Click += new System.EventHandler(this.bài1ToolStripMenuItem1_Click);
            // 
            // bài2ToolStripMenuItem1
            // 
            this.bài2ToolStripMenuItem1.Name = "bài2ToolStripMenuItem1";
            this.bài2ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.bài2ToolStripMenuItem1.Text = "Bài 2";
            this.bài2ToolStripMenuItem1.Click += new System.EventHandler(this.bài2ToolStripMenuItem1_Click);
            // 
            // PHAN5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PHAN5";
            this.Text = "PHAN5";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ChonBai;
        private System.Windows.Forms.ToolStripMenuItem bài1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bài2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bài1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bài2ToolStripMenuItem1;
    }
}