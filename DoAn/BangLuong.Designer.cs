namespace DoAn
{
    partial class BangLuong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        // sửa lại code
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbMaNV = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.gvBangLuong = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbLuongBD = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvBangLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(464, 20);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(370, 39);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Bảng Lương Nhân Viên";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(460, 95);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(124, 34);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbMaNV
            // 
            this.txbMaNV.Location = new System.Drawing.Point(170, 101);
            this.txbMaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbMaNV.Name = "txbMaNV";
            this.txbMaNV.Size = new System.Drawing.Size(269, 22);
            this.txbMaNV.TabIndex = 3;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(17, 101);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(137, 25);
            this.lbID.TabIndex = 1;
            this.lbID.Text = "Mã Nhân Viên";
            // 
            // gvBangLuong
            // 
            this.gvBangLuong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvBangLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBangLuong.Location = new System.Drawing.Point(12, 146);
            this.gvBangLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gvBangLuong.Name = "gvBangLuong";
            this.gvBangLuong.RowHeadersWidth = 51;
            this.gvBangLuong.RowTemplate.Height = 24;
            this.gvBangLuong.Size = new System.Drawing.Size(1593, 309);
            this.gvBangLuong.TabIndex = 4;
            this.gvBangLuong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvBangLuong_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1213, 94);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(124, 35);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1051, 94);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(124, 35);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(599, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Lương biến động";
            // 
            // txbLuongBD
            // 
            this.txbLuongBD.Location = new System.Drawing.Point(775, 104);
            this.txbLuongBD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbLuongBD.Name = "txbLuongBD";
            this.txbLuongBD.Size = new System.Drawing.Size(251, 22);
            this.txbLuongBD.TabIndex = 18;
            // 
            // BangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1621, 699);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbLuongBD);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.txbMaNV);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.gvBangLuong);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BangLuong";
            this.Text = "Bảng lương";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvBangLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbMaNV;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.DataGridView gvBangLuong;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbLuongBD;
    }
}
