namespace DoAn
{
    partial class BangTheoDoi
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
            this.gvTDSNN = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.txbMaNV = new System.Windows.Forms.TextBox();
            this.txbNghiKP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNghiBHXH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNghiCP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbLydo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvTDSNN)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbTitle.Location = new System.Drawing.Point(198, 24);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(398, 29);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "BẢNG THEO DÕI SỐ NGÀY NGHỈ";
            // 
            // gvTDSNN
            // 
            this.gvTDSNN.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvTDSNN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTDSNN.Location = new System.Drawing.Point(0, 76);
            this.gvTDSNN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gvTDSNN.Name = "gvTDSNN";
            this.gvTDSNN.RowHeadersWidth = 51;
            this.gvTDSNN.RowTemplate.Height = 24;
            this.gvTDSNN.Size = new System.Drawing.Size(800, 256);
            this.gvTDSNN.TabIndex = 4;
            this.gvTDSNN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTDSNN_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(669, 24);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 33);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFix
            // 
            this.btnFix.Location = new System.Drawing.Point(669, 378);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(100, 37);
            this.btnFix.TabIndex = 8;
            this.btnFix.Text = "Chỉnh sửa";
            this.btnFix.UseVisualStyleBackColor = true;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Location = new System.Drawing.Point(25, 350);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(86, 16);
            this.lbMaNV.TabIndex = 10;
            this.lbMaNV.Text = "Mã nhân viên";
            // 
            // txbMaNV
            // 
            this.txbMaNV.Location = new System.Drawing.Point(153, 347);
            this.txbMaNV.Name = "txbMaNV";
            this.txbMaNV.Size = new System.Drawing.Size(180, 22);
            this.txbMaNV.TabIndex = 11;
            // 
            // txbNghiKP
            // 
            this.txbNghiKP.Location = new System.Drawing.Point(153, 375);
            this.txbNghiKP.Name = "txbNghiKP";
            this.txbNghiKP.Size = new System.Drawing.Size(180, 22);
            this.txbNghiKP.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nghỉ không phép";
            // 
            // txbNghiBHXH
            // 
            this.txbNghiBHXH.Location = new System.Drawing.Point(153, 406);
            this.txbNghiBHXH.Name = "txbNghiBHXH";
            this.txbNghiBHXH.Size = new System.Drawing.Size(180, 22);
            this.txbNghiBHXH.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nghỉ BHXH";
            // 
            // txbNghiCP
            // 
            this.txbNghiCP.Location = new System.Drawing.Point(513, 378);
            this.txbNghiCP.Name = "txbNghiCP";
            this.txbNghiCP.Size = new System.Drawing.Size(142, 22);
            this.txbNghiCP.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nghỉ có phép";
            // 
            // txbLydo
            // 
            this.txbLydo.Location = new System.Drawing.Point(513, 409);
            this.txbLydo.Name = "txbLydo";
            this.txbLydo.Size = new System.Drawing.Size(142, 22);
            this.txbLydo.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Lý do";
            // 
            // BangTheoDoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.txbLydo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbNghiCP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbNghiBHXH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNghiKP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbMaNV);
            this.Controls.Add(this.lbMaNV);
            this.Controls.Add(this.btnFix);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.gvTDSNN);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BangTheoDoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng Theo Dõi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvTDSNN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridView gvTDSNN;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.TextBox txbMaNV;
        private System.Windows.Forms.TextBox txbNghiKP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNghiBHXH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNghiCP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbLydo;
        private System.Windows.Forms.Label label4;
    }
}