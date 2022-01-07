namespace DoAn
{
    partial class PhongBan
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbIDRoom = new System.Windows.Forms.TextBox();
            this.lbIDRoom = new System.Windows.Forms.Label();
            this.btnDetails = new System.Windows.Forms.Button();
            this.gvPhongBan = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.txbMaQL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTenPhong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhongBan)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(887, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbTitle.Location = new System.Drawing.Point(376, 27);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(138, 29);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Phòng Ban";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(15, 156);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 34);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbIDRoom
            // 
            this.txbIDRoom.Location = new System.Drawing.Point(370, 125);
            this.txbIDRoom.Name = "txbIDRoom";
            this.txbIDRoom.Size = new System.Drawing.Size(177, 22);
            this.txbIDRoom.TabIndex = 3;
            // 
            // lbIDRoom
            // 
            this.lbIDRoom.AutoSize = true;
            this.lbIDRoom.Location = new System.Drawing.Point(12, 128);
            this.lbIDRoom.Name = "lbIDRoom";
            this.lbIDRoom.Size = new System.Drawing.Size(68, 16);
            this.lbIDRoom.TabIndex = 1;
            this.lbIDRoom.Text = "Mã Phòng";
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(139, 156);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(122, 34);
            this.btnDetails.TabIndex = 5;
            this.btnDetails.Text = "Xem Chi Tiết";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // gvPhongBan
            // 
            this.gvPhongBan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPhongBan.Location = new System.Drawing.Point(15, 206);
            this.gvPhongBan.Name = "gvPhongBan";
            this.gvPhongBan.RowHeadersWidth = 51;
            this.gvPhongBan.RowTemplate.Height = 24;
            this.gvPhongBan.Size = new System.Drawing.Size(860, 292);
            this.gvPhongBan.TabIndex = 4;
            this.gvPhongBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvPhongBan_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(760, 156);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 34);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txbMaQL
            // 
            this.txbMaQL.Location = new System.Drawing.Point(663, 125);
            this.txbMaQL.Name = "txbMaQL";
            this.txbMaQL.Size = new System.Drawing.Size(183, 22);
            this.txbMaQL.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(569, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã quản lý";
            // 
            // txbTenPhong
            // 
            this.txbTenPhong.Location = new System.Drawing.Point(98, 125);
            this.txbTenPhong.Name = "txbTenPhong";
            this.txbTenPhong.Size = new System.Drawing.Size(177, 22);
            this.txbTenPhong.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên Phòng";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(370, 156);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 34);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(486, 156);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 34);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // PhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 510);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbIDRoom);
            this.Controls.Add(this.txbIDRoom);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.txbTenPhong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbMaQL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gvPhongBan);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PhongBan";
            this.Text = "Phòng Ban";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvPhongBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbIDRoom;
        private System.Windows.Forms.Label lbIDRoom;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.DataGridView gvPhongBan;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txbMaQL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTenPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
    }
}