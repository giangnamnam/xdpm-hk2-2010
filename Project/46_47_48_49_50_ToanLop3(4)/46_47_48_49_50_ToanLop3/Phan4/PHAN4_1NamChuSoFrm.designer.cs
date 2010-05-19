namespace _46_47_48_49_50_ToanLop3
{
    partial class NamChuSoFrm
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
            this.LuyenTap = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LuyenTap
            // 
            this.LuyenTap.Location = new System.Drawing.Point(18, 23);
            this.LuyenTap.Name = "LuyenTap";
            this.LuyenTap.Size = new System.Drawing.Size(231, 54);
            this.LuyenTap.TabIndex = 0;
            this.LuyenTap.Text = "Luyen Tap";
            this.LuyenTap.UseVisualStyleBackColor = true;
            this.LuyenTap.Click += new System.EventHandler(this.LuyenTap_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 91);
            this.button2.TabIndex = 1;
            this.button2.Text = "So Sanh";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // NamChuSoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LuyenTap);
            this.Name = "NamChuSoFrm";
            this.Text = "NamChuSoFrm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LuyenTap;
        private System.Windows.Forms.Button button2;
    }
}