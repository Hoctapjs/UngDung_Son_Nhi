﻿namespace UngDung
{
    partial class import
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
            this.lbl_username = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_path_import = new System.Windows.Forms.TextBox();
            this.btn_submit_import = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_thoat_im = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_sanpham = new System.Windows.Forms.Button();
            this.btn_nhanvien = new System.Windows.Forms.Button();
            this.btn_khach = new System.Windows.Forms.Button();
            this.btn_hoadon = new System.Windows.Forms.Button();
            this.btn_chitietdh = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_import = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.BackColor = System.Drawing.Color.LightGreen;
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_username.Location = new System.Drawing.Point(20, 12);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(81, 35);
            this.lbl_username.TabIndex = 3;
            this.lbl_username.Text = "label1";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(20, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(802, 504);
            this.panel3.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_path_import);
            this.groupBox1.Controls.Add(this.btn_submit_import);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(15, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 190);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Import Table";
            // 
            // txt_path_import
            // 
            this.txt_path_import.Location = new System.Drawing.Point(29, 118);
            this.txt_path_import.Name = "txt_path_import";
            this.txt_path_import.Size = new System.Drawing.Size(515, 41);
            this.txt_path_import.TabIndex = 6;
            // 
            // btn_submit_import
            // 
            this.btn_submit_import.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_submit_import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(187)))), ((int)(((byte)(146)))));
            this.btn_submit_import.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_submit_import.ForeColor = System.Drawing.Color.White;
            this.btn_submit_import.Location = new System.Drawing.Point(563, 116);
            this.btn_submit_import.Name = "btn_submit_import";
            this.btn_submit_import.Size = new System.Drawing.Size(188, 43);
            this.btn_submit_import.TabIndex = 5;
            this.btn_submit_import.Text = "Import";
            this.btn_submit_import.UseVisualStyleBackColor = false;
            this.btn_submit_import.Click += new System.EventHandler(this.btn_submit_import_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(187)))), ((int)(((byte)(146)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chọn File Excel cần Import:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::UngDung.Properties.Resources.Layer_11;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lbl_username);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 631);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_thoat_im);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(828, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 631);
            this.panel2.TabIndex = 5;
            // 
            // btn_thoat_im
            // 
            this.btn_thoat_im.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_thoat_im.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(187)))), ((int)(((byte)(146)))));
            this.btn_thoat_im.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_thoat_im.ForeColor = System.Drawing.Color.White;
            this.btn_thoat_im.Location = new System.Drawing.Point(16, 568);
            this.btn_thoat_im.Name = "btn_thoat_im";
            this.btn_thoat_im.Size = new System.Drawing.Size(237, 51);
            this.btn_thoat_im.TabIndex = 10;
            this.btn_thoat_im.Text = "Thoát";
            this.btn_thoat_im.UseVisualStyleBackColor = false;
            this.btn_thoat_im.Click += new System.EventHandler(this.btn_thoat_im_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Turquoise;
            this.pictureBox1.Image = global::UngDung.Properties.Resources.Layer_2;
            this.pictureBox1.Location = new System.Drawing.Point(16, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_sanpham);
            this.flowLayoutPanel1.Controls.Add(this.btn_nhanvien);
            this.flowLayoutPanel1.Controls.Add(this.btn_khach);
            this.flowLayoutPanel1.Controls.Add(this.btn_hoadon);
            this.flowLayoutPanel1.Controls.Add(this.btn_chitietdh);
            this.flowLayoutPanel1.Controls.Add(this.btn_export);
            this.flowLayoutPanel1.Controls.Add(this.btn_import);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 112);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(237, 407);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // btn_sanpham
            // 
            this.btn_sanpham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_sanpham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(187)))), ((int)(((byte)(146)))));
            this.btn_sanpham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sanpham.ForeColor = System.Drawing.Color.White;
            this.btn_sanpham.Location = new System.Drawing.Point(3, 3);
            this.btn_sanpham.Name = "btn_sanpham";
            this.btn_sanpham.Size = new System.Drawing.Size(234, 51);
            this.btn_sanpham.TabIndex = 9;
            this.btn_sanpham.Text = "Sản Phẩm";
            this.btn_sanpham.UseVisualStyleBackColor = false;
            // 
            // btn_nhanvien
            // 
            this.btn_nhanvien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_nhanvien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(187)))), ((int)(((byte)(146)))));
            this.btn_nhanvien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_nhanvien.ForeColor = System.Drawing.Color.White;
            this.btn_nhanvien.Location = new System.Drawing.Point(3, 60);
            this.btn_nhanvien.Name = "btn_nhanvien";
            this.btn_nhanvien.Size = new System.Drawing.Size(234, 51);
            this.btn_nhanvien.TabIndex = 7;
            this.btn_nhanvien.Text = "Nhân Viên";
            this.btn_nhanvien.UseVisualStyleBackColor = false;
            // 
            // btn_khach
            // 
            this.btn_khach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_khach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(187)))), ((int)(((byte)(146)))));
            this.btn_khach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_khach.ForeColor = System.Drawing.Color.White;
            this.btn_khach.Location = new System.Drawing.Point(3, 117);
            this.btn_khach.Name = "btn_khach";
            this.btn_khach.Size = new System.Drawing.Size(234, 51);
            this.btn_khach.TabIndex = 8;
            this.btn_khach.Text = "Khách";
            this.btn_khach.UseVisualStyleBackColor = false;
            // 
            // btn_hoadon
            // 
            this.btn_hoadon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_hoadon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(187)))), ((int)(((byte)(146)))));
            this.btn_hoadon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_hoadon.ForeColor = System.Drawing.Color.White;
            this.btn_hoadon.Location = new System.Drawing.Point(3, 174);
            this.btn_hoadon.Name = "btn_hoadon";
            this.btn_hoadon.Size = new System.Drawing.Size(234, 51);
            this.btn_hoadon.TabIndex = 6;
            this.btn_hoadon.Text = "Hóa Đơn";
            this.btn_hoadon.UseVisualStyleBackColor = false;
            // 
            // btn_chitietdh
            // 
            this.btn_chitietdh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_chitietdh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(187)))), ((int)(((byte)(146)))));
            this.btn_chitietdh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_chitietdh.ForeColor = System.Drawing.Color.White;
            this.btn_chitietdh.Location = new System.Drawing.Point(3, 231);
            this.btn_chitietdh.Name = "btn_chitietdh";
            this.btn_chitietdh.Size = new System.Drawing.Size(234, 51);
            this.btn_chitietdh.TabIndex = 10;
            this.btn_chitietdh.Text = "Chi Tiết DH";
            this.btn_chitietdh.UseVisualStyleBackColor = false;
            // 
            // btn_export
            // 
            this.btn_export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(187)))), ((int)(((byte)(146)))));
            this.btn_export.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_export.ForeColor = System.Drawing.Color.White;
            this.btn_export.Location = new System.Drawing.Point(3, 288);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(234, 51);
            this.btn_export.TabIndex = 11;
            this.btn_export.Text = "Export to XLS";
            this.btn_export.UseVisualStyleBackColor = false;
            // 
            // btn_import
            // 
            this.btn_import.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(187)))), ((int)(((byte)(146)))));
            this.btn_import.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_import.ForeColor = System.Drawing.Color.White;
            this.btn_import.Location = new System.Drawing.Point(3, 345);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(234, 51);
            this.btn_import.TabIndex = 12;
            this.btn_import.Text = "Import from XLS";
            this.btn_import.UseVisualStyleBackColor = false;
            // 
            // import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 631);
            this.Controls.Add(this.panel1);
            this.Name = "import";
            this.Text = "import";
            this.Load += new System.EventHandler(this.import_Load);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label lbl_username;
        private Panel panel3;
        private GroupBox groupBox1;
        private TextBox txt_path_import;
        private Button btn_submit_import;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn_sanpham;
        private Button btn_nhanvien;
        private Button btn_khach;
        private Button btn_hoadon;
        private Button btn_chitietdh;
        private Button btn_export;
        private Button btn_import;
        private PictureBox pictureBox1;
        private Button btn_thoat_im;
    }
}