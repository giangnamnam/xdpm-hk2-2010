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
            this.label1 = new System.Windows.Forms.Label();
            this.btCacSo100000 = new System.Windows.Forms.Button();
            this.btCacSoDen100000tt = new System.Windows.Forms.Button();
            this.btDaiLuong = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "ÔN TẬP CUỐI NĂM";
            // 
            // btCacSo100000
            // 
            this.btCacSo100000.Location = new System.Drawing.Point(63, 100);
            this.btCacSo100000.Name = "btCacSo100000";
            this.btCacSo100000.Size = new System.Drawing.Size(227, 23);
            this.btCacSo100000.TabIndex = 2;
            this.btCacSo100000.Text = "Các Số Đến 100 000\r\n";
            this.btCacSo100000.UseVisualStyleBackColor = true;
            this.btCacSo100000.Click += new System.EventHandler(this.btCacSo100000_Click);
            // 
            // btCacSoDen100000tt
            // 
            this.btCacSoDen100000tt.Location = new System.Drawing.Point(63, 146);
            this.btCacSoDen100000tt.Name = "btCacSoDen100000tt";
            this.btCacSoDen100000tt.Size = new System.Drawing.Size(227, 23);
            this.btCacSoDen100000tt.TabIndex = 3;
            this.btCacSoDen100000tt.Text = "Các Số Đến 100 000 (tiếp theo)";
            this.btCacSoDen100000tt.UseVisualStyleBackColor = true;
            this.btCacSoDen100000tt.Click += new System.EventHandler(this.btCacSoDen100000tt_Click);
            // 
            // btDaiLuong
            // 
            this.btDaiLuong.Location = new System.Drawing.Point(63, 195);
            this.btDaiLuong.Name = "btDaiLuong";
            this.btDaiLuong.Size = new System.Drawing.Size(227, 23);
            this.btDaiLuong.TabIndex = 4;
            this.btDaiLuong.Text = "Ôn Tập Về Đại Lượng";
            this.btDaiLuong.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(63, 250);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(227, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // PHAN5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 330);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btDaiLuong);
            this.Controls.Add(this.btCacSoDen100000tt);
            this.Controls.Add(this.btCacSo100000);
            this.Controls.Add(this.label1);
            this.Name = "PHAN5";
            this.Text = "PHẦN 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCacSo100000;
        private System.Windows.Forms.Button btCacSoDen100000tt;
        private System.Windows.Forms.Button btDaiLuong;
        private System.Windows.Forms.Button button4;
    }
}