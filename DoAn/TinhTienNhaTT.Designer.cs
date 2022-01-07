namespace DoAn
{
    partial class TinhTienNhaTT
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.gvDSNhaTT = new System.Windows.Forms.DataGridView();
            this.txbMaNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSoDien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbSoNuoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbChiphikhac = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSNhaTT)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(332, 30);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(271, 29);
            this.lbTitle.TabIndex = 8;
            this.lbTitle.Text = "Tính Tiền Nhà Tập Thể";
            // 
            // gvDSNhaTT
            // 
            this.gvDSNhaTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDSNhaTT.Location = new System.Drawing.Point(40, 80);
            this.gvDSNhaTT.Name = "gvDSNhaTT";
            this.gvDSNhaTT.RowHeadersWidth = 51;
            this.gvDSNhaTT.RowTemplate.Height = 24;
            this.gvDSNhaTT.Size = new System.Drawing.Size(844, 341);
            this.gvDSNhaTT.TabIndex = 7;
            this.gvDSNhaTT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDSNhaTT_CellContentClick);
            // 
            // txbMaNV
            // 
            this.txbMaNV.Location = new System.Drawing.Point(169, 451);
            this.txbMaNV.Name = "txbMaNV";
            this.txbMaNV.Size = new System.Drawing.Size(151, 22);
            this.txbMaNV.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã nhân viên";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(780, 470);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 36);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Số điện";
            // 
            // txbSoDien
            // 
            this.txbSoDien.Location = new System.Drawing.Point(452, 451);
            this.txbSoDien.Name = "txbSoDien";
            this.txbSoDien.Size = new System.Drawing.Size(151, 22);
            this.txbSoDien.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 494);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Số nước";
            // 
            // txbSoNuoc
            // 
            this.txbSoNuoc.Location = new System.Drawing.Point(452, 491);
            this.txbSoNuoc.Name = "txbSoNuoc";
            this.txbSoNuoc.Size = new System.Drawing.Size(151, 22);
            this.txbSoNuoc.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 490);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Chí phí khác";
            // 
            // txbChiphikhac
            // 
            this.txbChiphikhac.Location = new System.Drawing.Point(169, 491);
            this.txbChiphikhac.Name = "txbChiphikhac";
            this.txbChiphikhac.Size = new System.Drawing.Size(151, 22);
            this.txbChiphikhac.TabIndex = 16;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(660, 470);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 36);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // TinhTienNhaTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 602);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbChiphikhac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbSoNuoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbSoDien);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbMaNV);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.gvDSNhaTT);
            this.Name = "TinhTienNhaTT";
            this.Text = "TinhTienNhaTT";
            this.Load += new System.EventHandler(this.TinhTienNhaTT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDSNhaTT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridView gvDSNhaTT;
        private System.Windows.Forms.TextBox txbMaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbSoDien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbSoNuoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbChiphikhac;
        private System.Windows.Forms.Button btnUpdate;
    }
}