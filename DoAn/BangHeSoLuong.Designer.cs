namespace DoAn
{
    partial class BangHeSoLuong
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
            this.btnBack = new System.Windows.Forms.Button();
            this.gvBHSL = new System.Windows.Forms.DataGridView();
            this.lbBangHeSoluong = new System.Windows.Forms.Label();
            this.lbNam = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbMaNV = new System.Windows.Forms.TextBox();
            this.txbChucVu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNhomNgach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbHSPC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbLuongCB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbBac = new System.Windows.Forms.TextBox();
            this.txbHSL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvBHSL)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(923, 626);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 34);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gvBHSL
            // 
            this.gvBHSL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBHSL.Location = new System.Drawing.Point(23, 105);
            this.gvBHSL.Name = "gvBHSL";
            this.gvBHSL.RowHeadersWidth = 51;
            this.gvBHSL.RowTemplate.Height = 24;
            this.gvBHSL.Size = new System.Drawing.Size(1010, 337);
            this.gvBHSL.TabIndex = 4;
            this.gvBHSL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvBHSL_CellContentClick);
            // 
            // lbBangHeSoluong
            // 
            this.lbBangHeSoluong.AutoSize = true;
            this.lbBangHeSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBangHeSoluong.Location = new System.Drawing.Point(377, 26);
            this.lbBangHeSoluong.Name = "lbBangHeSoluong";
            this.lbBangHeSoluong.Size = new System.Drawing.Size(350, 38);
            this.lbBangHeSoluong.TabIndex = 5;
            this.lbBangHeSoluong.Text = "BẢNG HỆ SỐ LƯƠNG";
            // 
            // lbNam
            // 
            this.lbNam.AutoSize = true;
            this.lbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNam.Location = new System.Drawing.Point(18, 72);
            this.lbNam.Name = "lbNam";
            this.lbNam.Size = new System.Drawing.Size(145, 25);
            this.lbNam.TabIndex = 6;
            this.lbNam.Text = "Năm áp dụng : ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(764, 626);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 34);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã nhân viên";
            // 
            // txbMaNV
            // 
            this.txbMaNV.Location = new System.Drawing.Point(167, 481);
            this.txbMaNV.Name = "txbMaNV";
            this.txbMaNV.Size = new System.Drawing.Size(169, 22);
            this.txbMaNV.TabIndex = 11;
            // 
            // txbChucVu
            // 
            this.txbChucVu.Location = new System.Drawing.Point(167, 520);
            this.txbChucVu.Name = "txbChucVu";
            this.txbChucVu.Size = new System.Drawing.Size(169, 22);
            this.txbChucVu.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 526);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã chức vụ";
            // 
            // txbNhomNgach
            // 
            this.txbNhomNgach.Location = new System.Drawing.Point(167, 554);
            this.txbNhomNgach.Name = "txbNhomNgach";
            this.txbNhomNgach.Size = new System.Drawing.Size(169, 22);
            this.txbNhomNgach.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 557);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nhóm ngạch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 526);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Bậc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 557);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Lương cơ bản";
            // 
            // txbHSPC
            // 
            this.txbHSPC.Location = new System.Drawing.Point(764, 554);
            this.txbHSPC.Name = "txbHSPC";
            this.txbHSPC.Size = new System.Drawing.Size(169, 22);
            this.txbHSPC.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(661, 560);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Hệ số phụ cấp";
            // 
            // txbLuongCB
            // 
            this.txbLuongCB.Location = new System.Drawing.Point(463, 554);
            this.txbLuongCB.Name = "txbLuongCB";
            this.txbLuongCB.Size = new System.Drawing.Size(169, 22);
            this.txbLuongCB.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(661, 526);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Hệ số lương";
            // 
            // txbBac
            // 
            this.txbBac.Location = new System.Drawing.Point(463, 520);
            this.txbBac.Name = "txbBac";
            this.txbBac.Size = new System.Drawing.Size(169, 22);
            this.txbBac.TabIndex = 24;
            // 
            // txbHSL
            // 
            this.txbHSL.Location = new System.Drawing.Point(764, 520);
            this.txbHSL.Name = "txbHSL";
            this.txbHSL.Size = new System.Drawing.Size(169, 22);
            this.txbHSL.TabIndex = 25;
            // 
            // BangHeSoLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 801);
            this.Controls.Add(this.txbHSL);
            this.Controls.Add(this.txbBac);
            this.Controls.Add(this.txbLuongCB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbHSPC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbNhomNgach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbChucVu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbMaNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lbNam);
            this.Controls.Add(this.lbBangHeSoluong);
            this.Controls.Add(this.gvBHSL);
            this.Controls.Add(this.btnBack);
            this.Name = "BangHeSoLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng Hệ Số Lương";
            this.Load += new System.EventHandler(this.BangHeSoLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvBHSL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView gvBHSL;
        private System.Windows.Forms.Label lbBangHeSoluong;
        private System.Windows.Forms.Label lbNam;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbMaNV;
        private System.Windows.Forms.TextBox txbChucVu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNhomNgach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbHSPC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbLuongCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbBac;
        private System.Windows.Forms.TextBox txbHSL;
    }
}