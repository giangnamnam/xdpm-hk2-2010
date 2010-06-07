namespace _46_47_48_49_50_ToanLop3.Phan4
{
    partial class SoSanh
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
            this.tbNum1 = new System.Windows.Forms.TextBox();
            this.tbNum2 = new System.Windows.Forms.TextBox();
            this.bttBeHon = new System.Windows.Forms.Button();
            this.bttBang = new System.Windows.Forms.Button();
            this.bttLonHon = new System.Windows.Forms.Button();
            this.bttLamLai = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLyThuyet = new System.Windows.Forms.RichTextBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btQuayLai = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNum1
            // 
            this.tbNum1.Location = new System.Drawing.Point(71, 143);
            this.tbNum1.Name = "tbNum1";
            this.tbNum1.Size = new System.Drawing.Size(70, 20);
            this.tbNum1.TabIndex = 1;
            // 
            // tbNum2
            // 
            this.tbNum2.Location = new System.Drawing.Point(328, 143);
            this.tbNum2.Name = "tbNum2";
            this.tbNum2.Size = new System.Drawing.Size(70, 20);
            this.tbNum2.TabIndex = 3;
            this.tbNum2.TextChanged += new System.EventHandler(this.tbNum2_TextChanged);
            // 
            // bttBeHon
            // 
            this.bttBeHon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttBeHon.Location = new System.Drawing.Point(226, 101);
            this.bttBeHon.Name = "bttBeHon";
            this.bttBeHon.Size = new System.Drawing.Size(40, 30);
            this.bttBeHon.TabIndex = 4;
            this.bttBeHon.Text = "<";
            this.bttBeHon.UseVisualStyleBackColor = true;
            this.bttBeHon.Click += new System.EventHandler(this.bttBeHon_Click);
            // 
            // bttBang
            // 
            this.bttBang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttBang.Location = new System.Drawing.Point(226, 137);
            this.bttBang.Name = "bttBang";
            this.bttBang.Size = new System.Drawing.Size(40, 30);
            this.bttBang.TabIndex = 5;
            this.bttBang.Text = "=";
            this.bttBang.UseVisualStyleBackColor = true;
            this.bttBang.Click += new System.EventHandler(this.bttBang_Click);
            // 
            // bttLonHon
            // 
            this.bttLonHon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLonHon.Location = new System.Drawing.Point(226, 173);
            this.bttLonHon.Name = "bttLonHon";
            this.bttLonHon.Size = new System.Drawing.Size(40, 30);
            this.bttLonHon.TabIndex = 6;
            this.bttLonHon.Text = ">";
            this.bttLonHon.UseVisualStyleBackColor = true;
            this.bttLonHon.Click += new System.EventHandler(this.bttLonHon_Click);
            // 
            // bttLamLai
            // 
            this.bttLamLai.Location = new System.Drawing.Point(322, 209);
            this.bttLamLai.Name = "bttLamLai";
            this.bttLamLai.Size = new System.Drawing.Size(75, 23);
            this.bttLamLai.TabIndex = 8;
            this.bttLamLai.Text = "Làm lại";
            this.bttLamLai.UseVisualStyleBackColor = true;
            this.bttLamLai.Click += new System.EventHandler(this.bttLamLai_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bài tập 3: So Sánh";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbNum1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.tbNum2);
            this.groupBox1.Controls.Add(this.bttLamLai);
            this.groupBox1.Controls.Add(this.bttBeHon);
            this.groupBox1.Controls.Add(this.bttLonHon);
            this.groupBox1.Controls.Add(this.bttBang);
            this.groupBox1.Location = new System.Drawing.Point(496, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 382);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Luyện tập";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtLyThuyet);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 382);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // txtLyThuyet
            // 
            this.txtLyThuyet.Location = new System.Drawing.Point(16, 20);
            this.txtLyThuyet.Name = "txtLyThuyet";
            this.txtLyThuyet.Size = new System.Drawing.Size(429, 356);
            this.txtLyThuyet.TabIndex = 0;
            this.txtLyThuyet.Text = "";
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(867, 409);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(113, 45);
            this.btThoat.TabIndex = 14;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btQuayLai
            // 
            this.btQuayLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuayLai.Location = new System.Drawing.Point(738, 409);
            this.btQuayLai.Name = "btQuayLai";
            this.btQuayLai.Size = new System.Drawing.Size(113, 45);
            this.btQuayLai.TabIndex = 13;
            this.btQuayLai.Text = "Quay lại";
            this.btQuayLai.UseVisualStyleBackColor = false;
            this.btQuayLai.Click += new System.EventHandler(this.btQuayLai_Click);
            // 
            // SoSanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_46_47_48_49_50_ToanLop3.Properties.Resources.hinh2;
            this.ClientSize = new System.Drawing.Size(992, 466);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btQuayLai);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SoSanh";
            this.Text = "SoSanh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SoSanh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbNum1;
        private System.Windows.Forms.TextBox tbNum2;
        private System.Windows.Forms.Button bttBeHon;
        private System.Windows.Forms.Button bttBang;
        private System.Windows.Forms.Button bttLonHon;
        private System.Windows.Forms.Button bttLamLai;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txtLyThuyet;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btQuayLai;
    }
}