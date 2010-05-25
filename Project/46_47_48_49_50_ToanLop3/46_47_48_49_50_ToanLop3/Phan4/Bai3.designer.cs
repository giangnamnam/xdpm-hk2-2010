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
            this.SuspendLayout();
            // 
            // tbNum1
            // 
            this.tbNum1.Location = new System.Drawing.Point(111, 126);
            this.tbNum1.Name = "tbNum1";
            this.tbNum1.Size = new System.Drawing.Size(70, 20);
            this.tbNum1.TabIndex = 1;
            // 
            // tbNum2
            // 
            this.tbNum2.Location = new System.Drawing.Point(368, 126);
            this.tbNum2.Name = "tbNum2";
            this.tbNum2.Size = new System.Drawing.Size(70, 20);
            this.tbNum2.TabIndex = 3;
            this.tbNum2.TextChanged += new System.EventHandler(this.tbNum2_TextChanged);
            // 
            // bttBeHon
            // 
            this.bttBeHon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttBeHon.Location = new System.Drawing.Point(259, 84);
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
            this.bttBang.Location = new System.Drawing.Point(259, 120);
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
            this.bttLonHon.Location = new System.Drawing.Point(259, 156);
            this.bttLonHon.Name = "bttLonHon";
            this.bttLonHon.Size = new System.Drawing.Size(40, 30);
            this.bttLonHon.TabIndex = 6;
            this.bttLonHon.Text = ">";
            this.bttLonHon.UseVisualStyleBackColor = true;
            this.bttLonHon.Click += new System.EventHandler(this.bttLonHon_Click);
            // 
            // bttLamLai
            // 
            this.bttLamLai.Location = new System.Drawing.Point(362, 192);
            this.bttLamLai.Name = "bttLamLai";
            this.bttLamLai.Size = new System.Drawing.Size(75, 23);
            this.bttLamLai.TabIndex = 8;
            this.bttLamLai.Text = "Làm lại";
            this.bttLamLai.UseVisualStyleBackColor = true;
            this.bttLamLai.Click += new System.EventHandler(this.bttLamLai_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SoSanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 329);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bttLamLai);
            this.Controls.Add(this.bttLonHon);
            this.Controls.Add(this.bttBang);
            this.Controls.Add(this.bttBeHon);
            this.Controls.Add(this.tbNum2);
            this.Controls.Add(this.tbNum1);
            this.Name = "SoSanh";
            this.Text = "SoSanh";
            this.Load += new System.EventHandler(this.SoSanh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNum1;
        private System.Windows.Forms.TextBox tbNum2;
        private System.Windows.Forms.Button bttBeHon;
        private System.Windows.Forms.Button bttBang;
        private System.Windows.Forms.Button bttLonHon;
        private System.Windows.Forms.Button bttLamLai;
        private System.Windows.Forms.TextBox textBox1;
    }
}