﻿namespace _46_47_48_49_50_ToanLop3
{
    partial class PHAN3
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
            this.groupBox_Button = new System.Windows.Forms.GroupBox();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.groupBox_Button.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Button
            // 
            this.groupBox_Button.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Button.Controls.Add(this.button_Exit);
            this.groupBox_Button.Controls.Add(this.button4);
            this.groupBox_Button.Controls.Add(this.button3);
            this.groupBox_Button.Controls.Add(this.button2);
            this.groupBox_Button.Controls.Add(this.button1);
            this.groupBox_Button.Location = new System.Drawing.Point(555, 56);
            this.groupBox_Button.Name = "groupBox_Button";
            this.groupBox_Button.Size = new System.Drawing.Size(202, 343);
            this.groupBox_Button.TabIndex = 9;
            this.groupBox_Button.TabStop = false;
            // 
            // button_Exit
            // 
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Exit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exit.Location = new System.Drawing.Point(26, 273);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(147, 45);
            this.button_Exit.TabIndex = 7;
            this.button_Exit.Text = "Tạm &Biệt";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.MouseLeave += new System.EventHandler(this.button_Exit_MouseLeave);
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            this.button_Exit.MouseEnter += new System.EventHandler(this.button_Exit_MouseEnter);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(26, 211);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 45);
            this.button4.TabIndex = 5;
            this.button4.Text = "&Ôn Tập";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(26, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 45);
            this.button3.TabIndex = 4;
            this.button3.Text = "&Mở Rộng";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(26, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "&Tính Toán";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(26, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Làm Quen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Red;
            this.Title.Location = new System.Drawing.Point(297, 136);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(99, 31);
            this.Title.TabIndex = 8;
            this.Title.Text = "<Title>";
            // 
            // PHAN3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 455);
            this.Controls.Add(this.groupBox_Button);
            this.Controls.Add(this.Title);
            this.Name = "PHAN3";
            this.Text = "PHAN3";
            this.Load += new System.EventHandler(this.PHAN3_Load);
            this.groupBox_Button.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Button;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Title;
    }
}