﻿namespace _46_47_48_49_50_ToanLop3
{
    partial class PHAN4
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
            System.Windows.Forms.ListViewItem listViewItem31 = new System.Windows.Forms.ListViewItem(new string[] {
            "Bài 1",
            "Làm quen với số có 5 chữ số"}, -1);
            System.Windows.Forms.ListViewItem listViewItem32 = new System.Windows.Forms.ListViewItem(new string[] {
            "Bài 2",
            "Nhân số có 5 chữ số với số có 1 chữ số"}, -1);
            System.Windows.Forms.ListViewItem listViewItem33 = new System.Windows.Forms.ListViewItem(new string[] {
            "Bài 3",
            "Chia số có 5 chữ số với số có 1 chữ số"}, -1);
            System.Windows.Forms.ListViewItem listViewItem34 = new System.Windows.Forms.ListViewItem(new string[] {
            "Bài 4",
            "Tính chu vi hình chữ nhật"}, -1);
            System.Windows.Forms.ListViewItem listViewItem35 = new System.Windows.Forms.ListViewItem(new string[] {
            "Bài 5",
            "Tính diện tích hình chữ nhật"}, -1);
            System.Windows.Forms.ListViewItem listViewItem36 = new System.Windows.Forms.ListViewItem(new string[] {
            "Bài 6",
            "Ôn tập"}, -1);
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.btBatDau = new System.Windows.Forms.Button();
            this.btQuayLai = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listViewItem31.Tag = "bai1";
            listViewItem32.Tag = "bai2";
            listViewItem33.Tag = "bai3";
            listViewItem34.Tag = "bai4";
            listViewItem35.Tag = "bai5";
            listViewItem36.Tag = "bai5";
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem31,
            listViewItem32,
            listViewItem33,
            listViewItem34,
            listViewItem35,
            listViewItem36});
            this.listView1.Location = new System.Drawing.Point(15, 36);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(965, 215);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "MỤC LỤC";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Chọn bài học";
            this.columnHeader1.Width = 185;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tựa đề";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 476;
            // 
            // btBatDau
            // 
            this.btBatDau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBatDau.Location = new System.Drawing.Point(225, 291);
            this.btBatDau.Name = "btBatDau";
            this.btBatDau.Size = new System.Drawing.Size(140, 45);
            this.btBatDau.TabIndex = 2;
            this.btBatDau.Text = "Bắt đầu";
            this.btBatDau.UseVisualStyleBackColor = false;
            this.btBatDau.Click += new System.EventHandler(this.btBatDau_Click);
            // 
            // btQuayLai
            // 
            this.btQuayLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuayLai.Location = new System.Drawing.Point(450, 291);
            this.btQuayLai.Name = "btQuayLai";
            this.btQuayLai.Size = new System.Drawing.Size(140, 45);
            this.btQuayLai.TabIndex = 3;
            this.btQuayLai.Text = "Quay lại";
            this.btQuayLai.UseVisualStyleBackColor = false;
            this.btQuayLai.Click += new System.EventHandler(this.btQuayLai_Click);
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(686, 291);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(140, 45);
            this.btThoat.TabIndex = 4;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // PHAN4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 366);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btQuayLai);
            this.Controls.Add(this.btBatDau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PHAN4";
            this.Text = "PHAN4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btBatDau;
        private System.Windows.Forms.Button btQuayLai;
        private System.Windows.Forms.Button btThoat;
    }
}