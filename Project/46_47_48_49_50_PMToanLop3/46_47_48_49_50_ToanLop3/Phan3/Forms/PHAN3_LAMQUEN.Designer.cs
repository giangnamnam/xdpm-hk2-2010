namespace _46_47_48_49_50_ToanLop3
{
    partial class PHAN3_LAMQUEN
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
            this.button_Sau = new System.Windows.Forms.Button();
            this.button_Truoc = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.tabControl_ = new System.Windows.Forms.TabControl();
            this.tabPage_LyThuyet = new System.Windows.Forms.TabPage();
            this.tabPage_BaiTap = new System.Windows.Forms.TabPage();
            this.pictureBox_NoiDung = new System.Windows.Forms.PictureBox();
            this.tabControl_.SuspendLayout();
            this.tabPage_LyThuyet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_NoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Sau
            // 
            this.button_Sau.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Sau.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Sau.Location = new System.Drawing.Point(273, 180);
            this.button_Sau.Name = "button_Sau";
            this.button_Sau.Size = new System.Drawing.Size(147, 45);
            this.button_Sau.TabIndex = 3;
            this.button_Sau.Text = " ";
            this.button_Sau.UseVisualStyleBackColor = true;
            this.button_Sau.Click += new System.EventHandler(this.button_Sau_Click);
            // 
            // button_Truoc
            // 
            this.button_Truoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Truoc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Truoc.Location = new System.Drawing.Point(105, 180);
            this.button_Truoc.Name = "button_Truoc";
            this.button_Truoc.Size = new System.Drawing.Size(147, 45);
            this.button_Truoc.TabIndex = 2;
            this.button_Truoc.Text = " ";
            this.button_Truoc.UseVisualStyleBackColor = true;
            this.button_Truoc.Click += new System.EventHandler(this.button_Truoc_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Red;
            this.Title.Location = new System.Drawing.Point(423, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(99, 31);
            this.Title.TabIndex = 8;
            this.Title.Text = "<Title>";
            // 
            // tabControl_
            // 
            this.tabControl_.Controls.Add(this.tabPage_LyThuyet);
            this.tabControl_.Controls.Add(this.tabPage_BaiTap);
            this.tabControl_.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_.Location = new System.Drawing.Point(83, 58);
            this.tabControl_.Name = "tabControl_";
            this.tabControl_.SelectedIndex = 0;
            this.tabControl_.Size = new System.Drawing.Size(471, 293);
            this.tabControl_.TabIndex = 7;
            // 
            // tabPage_LyThuyet
            // 
            this.tabPage_LyThuyet.BackColor = System.Drawing.Color.White;
            this.tabPage_LyThuyet.Controls.Add(this.pictureBox_NoiDung);
            this.tabPage_LyThuyet.Controls.Add(this.button_Truoc);
            this.tabPage_LyThuyet.Controls.Add(this.button_Sau);
            this.tabPage_LyThuyet.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_LyThuyet.ForeColor = System.Drawing.Color.Blue;
            this.tabPage_LyThuyet.Location = new System.Drawing.Point(4, 31);
            this.tabPage_LyThuyet.Name = "tabPage_LyThuyet";
            this.tabPage_LyThuyet.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_LyThuyet.Size = new System.Drawing.Size(463, 258);
            this.tabPage_LyThuyet.TabIndex = 0;
            this.tabPage_LyThuyet.Text = "Lý Thuyết";
            // 
            // tabPage_BaiTap
            // 
            this.tabPage_BaiTap.BackColor = System.Drawing.Color.White;
            this.tabPage_BaiTap.Location = new System.Drawing.Point(4, 31);
            this.tabPage_BaiTap.Name = "tabPage_BaiTap";
            this.tabPage_BaiTap.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_BaiTap.Size = new System.Drawing.Size(463, 258);
            this.tabPage_BaiTap.TabIndex = 1;
            this.tabPage_BaiTap.Text = "Bài Tập";
            // 
            // pictureBox_NoiDung
            // 
            this.pictureBox_NoiDung.Location = new System.Drawing.Point(105, 32);
            this.pictureBox_NoiDung.Name = "pictureBox_NoiDung";
            this.pictureBox_NoiDung.Size = new System.Drawing.Size(315, 120);
            this.pictureBox_NoiDung.TabIndex = 4;
            this.pictureBox_NoiDung.TabStop = false;
            // 
            // PHAN3_LAMQUEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 718);
            this.Controls.Add(this.tabControl_);
            this.Controls.Add(this.Title);
            this.Name = "PHAN3_LAMQUEN";
            this.Text = "PHAN3_LAMQUEN";
            this.Load += new System.EventHandler(this.PHAN3_LAMQUEN_Load);
            this.tabControl_.ResumeLayout(false);
            this.tabPage_LyThuyet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_NoiDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Sau;
        private System.Windows.Forms.Button button_Truoc;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TabControl tabControl_;
        private System.Windows.Forms.TabPage tabPage_LyThuyet;
        private System.Windows.Forms.TabPage tabPage_BaiTap;
        private System.Windows.Forms.PictureBox pictureBox_NoiDung;
    }
}