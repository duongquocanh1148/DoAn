namespace DoAn
{
    partial class DanhSachNhaTT
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
            this.gvDSNhaTT = new System.Windows.Forms.DataGridView();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnDK = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSNhaTT)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDSNhaTT
            // 
            this.gvDSNhaTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDSNhaTT.Location = new System.Drawing.Point(12, 104);
            this.gvDSNhaTT.Name = "gvDSNhaTT";
            this.gvDSNhaTT.RowHeadersWidth = 51;
            this.gvDSNhaTT.RowTemplate.Height = 24;
            this.gvDSNhaTT.Size = new System.Drawing.Size(844, 341);
            this.gvDSNhaTT.TabIndex = 0;
            this.gvDSNhaTT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDSNhaTT_CellContentClick);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(259, 55);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(334, 29);
            this.lbTitle.TabIndex = 6;
            this.lbTitle.Text = "DANH SÁCH NHÀ TẬP THỂ";
            // 
            // btnDK
            // 
            this.btnDK.Location = new System.Drawing.Point(366, 468);
            this.btnDK.Name = "btnDK";
            this.btnDK.Size = new System.Drawing.Size(98, 42);
            this.btnDK.TabIndex = 7;
            this.btnDK.Text = "Đăng ký";
            this.btnDK.UseVisualStyleBackColor = true;
            this.btnDK.Click += new System.EventHandler(this.btnDK_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(774, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 30);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(681, 58);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 32);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // DanhSachNhaTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 522);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDK);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.gvDSNhaTT);
            this.Name = "DanhSachNhaTT";
            this.Text = "Danh Sách Nhà Tập Thể";
            this.Load += new System.EventHandler(this.DanhSachNhaTT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDSNhaTT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvDSNhaTT;
        public System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnDK;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
    }
}