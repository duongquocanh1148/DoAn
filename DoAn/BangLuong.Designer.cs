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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxIDRoom = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.lbIDRoom = new System.Windows.Forms.Label();
            this.gvBangLuong = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBangLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbTitle.Location = new System.Drawing.Point(644, 13);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(149, 29);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Bảng Lương";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDetails);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.textBoxID);
            this.groupBox1.Controls.Add(this.textBoxIDRoom);
            this.groupBox1.Controls.Add(this.lbID);
            this.groupBox1.Controls.Add(this.lbIDRoom);
            this.groupBox1.Location = new System.Drawing.Point(342, 53);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(800, 139);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(613, 80);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(104, 23);
            this.btnDetails.TabIndex = 5;
            this.btnDetails.Text = "Xem Chi Tiết";
            this.btnDetails.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(613, 30);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(139, 80);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(451, 22);
            this.textBoxID.TabIndex = 3;
            // 
            // textBoxIDRoom
            // 
            this.textBoxIDRoom.Location = new System.Drawing.Point(92, 30);
            this.textBoxIDRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxIDRoom.Name = "textBoxIDRoom";
            this.textBoxIDRoom.Size = new System.Drawing.Size(497, 22);
            this.textBoxIDRoom.TabIndex = 2;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(12, 84);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(111, 16);
            this.lbID.TabIndex = 1;
            this.lbID.Text = "Mã Số Nhân Viên";
            // 
            // lbIDRoom
            // 
            this.lbIDRoom.AutoSize = true;
            this.lbIDRoom.Location = new System.Drawing.Point(12, 33);
            this.lbIDRoom.Name = "lbIDRoom";
            this.lbIDRoom.Size = new System.Drawing.Size(68, 16);
            this.lbIDRoom.TabIndex = 0;
            this.lbIDRoom.Text = "Mã Phòng";
            this.lbIDRoom.Click += new System.EventHandler(this.label2_Click);
            // 
            // gvBangLuong
            // 
            this.gvBangLuong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvBangLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBangLuong.Location = new System.Drawing.Point(12, 213);
            this.gvBangLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gvBangLuong.Name = "gvBangLuong";
            this.gvBangLuong.RowHeadersWidth = 51;
            this.gvBangLuong.RowTemplate.Height = 24;
            this.gvBangLuong.Size = new System.Drawing.Size(1366, 217);
            this.gvBangLuong.TabIndex = 4;
            this.gvBangLuong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvBangLuong_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1262, 13);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // BangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.gvBangLuong);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BangLuong";
            this.Text = "Bảng lương";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBangLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbIDRoom;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxIDRoom;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.DataGridView gvBangLuong;
        private System.Windows.Forms.Button btnBack;
    }
}
