namespace DoAn
{
    partial class TinhLuong
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.gvBangLuong = new System.Windows.Forms.DataGridView();
            this.lbID = new System.Windows.Forms.Label();
            this.txbMaNV = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbLuongBD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbLydo = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvBangLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(676, 478);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(124, 34);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbTitle.Location = new System.Drawing.Point(281, 45);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(264, 29);
            this.lbTitle.TabIndex = 6;
            this.lbTitle.Text = "Tính Lương Nhân Viên";
            // 
            // gvBangLuong
            // 
            this.gvBangLuong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvBangLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBangLuong.Location = new System.Drawing.Point(12, 150);
            this.gvBangLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gvBangLuong.Name = "gvBangLuong";
            this.gvBangLuong.RowHeadersWidth = 51;
            this.gvBangLuong.RowTemplate.Height = 24;
            this.gvBangLuong.Size = new System.Drawing.Size(889, 309);
            this.gvBangLuong.TabIndex = 9;
            this.gvBangLuong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvBangLuong_CellContentClick);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(42, 110);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(100, 18);
            this.lbID.TabIndex = 1;
            this.lbID.Text = "Mã Nhân Viên";
            // 
            // txbMaNV
            // 
            this.txbMaNV.Location = new System.Drawing.Point(148, 109);
            this.txbMaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbMaNV.Name = "txbMaNV";
            this.txbMaNV.Size = new System.Drawing.Size(269, 22);
            this.txbMaNV.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(443, 103);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(124, 34);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txbLuongBD
            // 
            this.txbLuongBD.Location = new System.Drawing.Point(202, 478);
            this.txbLuongBD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbLuongBD.Name = "txbLuongBD";
            this.txbLuongBD.Size = new System.Drawing.Size(269, 22);
            this.txbLuongBD.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 482);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Lương biến động";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 520);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Lý do";
            // 
            // txbLydo
            // 
            this.txbLydo.Location = new System.Drawing.Point(202, 520);
            this.txbLydo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbLydo.Name = "txbLydo";
            this.txbLydo.Size = new System.Drawing.Size(269, 22);
            this.txbLydo.TabIndex = 15;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(520, 478);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(124, 34);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // TinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 620);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbLydo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbLuongBD);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.gvBangLuong);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.txbMaNV);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbTitle);
            this.Name = "TinhLuong";
            this.Text = "Tính Lương Nhân Viên";
            this.Load += new System.EventHandler(this.TinhLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvBangLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridView gvBangLuong;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txbMaNV;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbLuongBD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbLydo;
        private System.Windows.Forms.Button btnUpdate;
    }
}