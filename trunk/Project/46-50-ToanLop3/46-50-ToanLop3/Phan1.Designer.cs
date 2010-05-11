namespace _46_50_ToanLop3
{
    partial class Phan1
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "     BÀI 1",
            "ĐỌC, VIẾT,SO SÁNH CÁC SỐ CÓ BA CHỮ SỐ"}, -1, System.Drawing.Color.Black, System.Drawing.Color.Empty, null);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("     BÀI 2");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("     BÀI 3");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("     BÀI 4");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("     BÀI 5");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("     BÀI 6");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("     BÀI 7");
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lvPhanMot = new System.Windows.Forms.ListView();
            this.clBaihoc = new System.Windows.Forms.ColumnHeader();
            this.clTuade = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Image = global::_46_50_ToanLop3.Properties.Resources.flower10;
            this.button1.Location = new System.Drawing.Point(745, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Thoát";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(187, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "PHẦN I: ÔN TẬP VÀ BỔ SUNG";
            // 
            // lvPhanMot
            // 
            this.lvPhanMot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lvPhanMot.BackgroundImageTiled = true;
            this.lvPhanMot.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clBaihoc,
            this.clTuade});
            this.lvPhanMot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lvPhanMot.ForeColor = System.Drawing.Color.Black;
            listViewItem1.Checked = true;
            listViewItem1.StateImageIndex = 1;
            listViewItem1.Tag = "Bai1";
            listViewItem2.Checked = true;
            listViewItem2.StateImageIndex = 1;
            listViewItem2.Tag = "Bai2";
            listViewItem3.Checked = true;
            listViewItem3.StateImageIndex = 1;
            listViewItem3.Tag = "Bai3";
            listViewItem4.Checked = true;
            listViewItem4.StateImageIndex = 1;
            listViewItem4.Tag = "Bai4";
            listViewItem5.Checked = true;
            listViewItem5.StateImageIndex = 1;
            listViewItem5.Tag = "Bai5";
            listViewItem6.Checked = true;
            listViewItem6.StateImageIndex = 1;
            listViewItem6.Tag = "Bai6";
            listViewItem7.Checked = true;
            listViewItem7.StateImageIndex = 1;
            listViewItem7.Tag = "Bai 7";
            this.lvPhanMot.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7});
            this.lvPhanMot.Location = new System.Drawing.Point(103, 74);
            this.lvPhanMot.Name = "lvPhanMot";
            this.lvPhanMot.Size = new System.Drawing.Size(655, 259);
            this.lvPhanMot.TabIndex = 3;
            this.lvPhanMot.UseCompatibleStateImageBehavior = false;
            this.lvPhanMot.View = System.Windows.Forms.View.Details;
            // 
            // clBaihoc
            // 
            this.clBaihoc.Text = "BÀI HỌC";
            this.clBaihoc.Width = 120;
            // 
            // clTuade
            // 
            this.clTuade.Text = "TỰA ĐỀ";
            this.clTuade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clTuade.Width = 529;
            // 
            // Phan1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< .mine
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::_46_50_ToanLop3.Properties.Resources.flower10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(861, 437);
            this.Controls.Add(this.lvPhanMot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
=======
            this.ClientSize = new System.Drawing.Size(540, 323);
>>>>>>> .r51
            this.Name = "Phan1";
            this.Text = "Phan1";
            this.Load += new System.EventHandler(this.Phan1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvPhanMot;
        private System.Windows.Forms.ColumnHeader clBaihoc;
        private System.Windows.Forms.ColumnHeader clTuade;

    }
}