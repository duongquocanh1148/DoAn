namespace DoAn
{
    partial class DanhSach
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbMaPhong = new System.Windows.Forms.TextBox();
            this.txbMaNV = new System.Windows.Forms.TextBox();
            this.lbIDRoom = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.gvDSNV = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSNV)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbTitle.Location = new System.Drawing.Point(507, 161);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(263, 29);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Danh Sách Nhân Viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDetails);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txbMaPhong);
            this.groupBox1.Controls.Add(this.txbMaNV);
            this.groupBox1.Controls.Add(this.lbIDRoom);
            this.groupBox1.Controls.Add(this.lbID);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(800, 139);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(667, 75);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(104, 33);
            this.btnDetails.TabIndex = 5;
            this.btnDetails.Text = "Xem Chi Tiết";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(667, 25);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 33);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbMaPhong
            // 
            this.txbMaPhong.Location = new System.Drawing.Point(107, 80);
            this.txbMaPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbMaPhong.Name = "txbMaPhong";
            this.txbMaPhong.Size = new System.Drawing.Size(483, 22);
            this.txbMaPhong.TabIndex = 3;
            // 
            // txbMaNV
            // 
            this.txbMaNV.Location = new System.Drawing.Point(107, 30);
            this.txbMaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbMaNV.Name = "txbMaNV";
            this.txbMaNV.Size = new System.Drawing.Size(483, 22);
            this.txbMaNV.TabIndex = 2;
            // 
            // lbIDRoom
            // 
            this.lbIDRoom.AutoSize = true;
            this.lbIDRoom.Location = new System.Drawing.Point(12, 80);
            this.lbIDRoom.Name = "lbIDRoom";
            this.lbIDRoom.Size = new System.Drawing.Size(68, 16);
            this.lbIDRoom.TabIndex = 1;
            this.lbIDRoom.Text = "Mã Phòng";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(12, 30);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(46, 16);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "Mã Số";
            // 
            // gvDSNV
            // 
            this.gvDSNV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvDSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDSNV.Location = new System.Drawing.Point(12, 192);
            this.gvDSNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gvDSNV.Name = "gvDSNV";
            this.gvDSNV.RowHeadersWidth = 51;
            this.gvDSNV.RowTemplate.Height = 24;
            this.gvDSNV.Size = new System.Drawing.Size(1142, 217);
            this.gvDSNV.TabIndex = 4;
            this.gvDSNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDSNV_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(830, 36);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 33);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1056, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Quay lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.gvDSNV);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DanhSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Nhân Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbMaPhong;
        private System.Windows.Forms.TextBox txbMaNV;
        private System.Windows.Forms.Label lbIDRoom;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.DataGridView gvDSNV;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button1;
    }
}