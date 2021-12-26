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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSach));
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
            this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsbtnFix = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSNV)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbTitle.Location = new System.Drawing.Point(253, 199);
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
            this.groupBox1.Location = new System.Drawing.Point(0, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(800, 139);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(667, 80);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(104, 23);
            this.btnDetails.TabIndex = 5;
            this.btnDetails.Text = "Xem Chi Tiết";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(683, 30);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
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
            this.gvDSNV.Location = new System.Drawing.Point(0, 236);
            this.gvDSNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gvDSNV.Name = "gvDSNV";
            this.gvDSNV.RowHeadersWidth = 51;
            this.gvDSNV.RowTemplate.Height = 24;
            this.gvDSNV.Size = new System.Drawing.Size(800, 217);
            this.gvDSNV.TabIndex = 4;
            this.gvDSNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDSNV_CellContentClick);
            // 
            // tsbtnAdd
            // 
            this.tsbtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAdd.Image")));
            this.tsbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAdd.Name = "tsbtnAdd";
            this.tsbtnAdd.Size = new System.Drawing.Size(29, 24);
            this.tsbtnAdd.Text = "Thêm";
            this.tsbtnAdd.Click += new System.EventHandler(this.tsbtnAdd_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(46, 24);
            this.toolStripLabel1.Text = "Thêm";
            // 
            // tsbtnFix
            // 
            this.tsbtnFix.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnFix.Image = global::DoAn.Properties.Resources.toolStripButton2_Image;
            this.tsbtnFix.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFix.Name = "tsbtnFix";
            this.tsbtnFix.Size = new System.Drawing.Size(29, 24);
            this.tsbtnFix.Text = "Sửa";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(34, 24);
            this.toolStripLabel2.Text = "Sửa";
            // 
            // tsbtnDelete
            // 
            this.tsbtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnDelete.Image = global::DoAn.Properties.Resources.toolStripButton3_Image;
            this.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDelete.Name = "tsbtnDelete";
            this.tsbtnDelete.Size = new System.Drawing.Size(29, 24);
            this.tsbtnDelete.Text = "Xóa";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(35, 24);
            this.toolStripLabel3.Text = "Xóa";
            // 
            // tsbtnSave
            // 
            this.tsbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSave.Image = global::DoAn.Properties.Resources.toolStripButton4_Image;
            this.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSave.Name = "tsbtnSave";
            this.tsbtnSave.Size = new System.Drawing.Size(29, 24);
            this.tsbtnSave.Text = "Lưu";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(33, 24);
            this.toolStripLabel4.Text = "Lưu";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::DoAn.Properties.Resources.toolStripButton5_Image;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton5.Text = "Hủy";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(35, 24);
            this.toolStripLabel5.Text = "Hủy";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = global::DoAn.Properties.Resources.toolStripButton6_Image;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton6.Text = "Cập Nhật";
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(71, 24);
            this.toolStripLabel6.Text = "Cập Nhật";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = global::DoAn.Properties.Resources.toolStripButton7_Image;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton7.Text = "In";
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.RightToLeftAutoMirrorImage = true;
            this.toolStripLabel7.Size = new System.Drawing.Size(66, 24);
            this.toolStripLabel7.Text = "Quay Lai";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAdd,
            this.toolStripLabel1,
            this.tsbtnFix,
            this.toolStripLabel2,
            this.tsbtnDelete,
            this.toolStripLabel3,
            this.tsbtnSave,
            this.toolStripLabel4,
            this.toolStripButton5,
            this.toolStripLabel5,
            this.toolStripButton6,
            this.toolStripLabel6,
            this.toolStripButton7,
            this.toolStripLabel7});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(667, 201);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // DanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gvDSNV);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DanhSach";
            this.Text = "Danh Sách Nhân Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSNV)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsbtnFix;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button btnBack;
    }
}