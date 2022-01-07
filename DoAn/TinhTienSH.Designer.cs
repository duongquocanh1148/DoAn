namespace DoAn
{
    partial class TinhTienSH
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
            this.gvTTSH = new System.Windows.Forms.DataGridView();
            this.txbMaNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbChiphikhac = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbSoNuoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbSoDien = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvTTSH)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbTitle.Location = new System.Drawing.Point(323, 31);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(389, 29);
            this.lbTitle.TabIndex = 6;
            this.lbTitle.Text = "Tính Tiền Sinh Hoạt Nhà Tập Thể";
            // 
            // gvTTSH
            // 
            this.gvTTSH.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvTTSH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTTSH.Location = new System.Drawing.Point(19, 87);
            this.gvTTSH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gvTTSH.Name = "gvTTSH";
            this.gvTTSH.RowHeadersWidth = 51;
            this.gvTTSH.RowTemplate.Height = 24;
            this.gvTTSH.Size = new System.Drawing.Size(1034, 322);
            this.gvTTSH.TabIndex = 7;
            this.gvTTSH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTTSH_CellContentClick);
            // 
            // txbMaNV
            // 
            this.txbMaNV.Location = new System.Drawing.Point(139, 432);
            this.txbMaNV.Name = "txbMaNV";
            this.txbMaNV.Size = new System.Drawing.Size(174, 22);
            this.txbMaNV.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Chi phí khác";
            // 
            // txbChiphikhac
            // 
            this.txbChiphikhac.Location = new System.Drawing.Point(139, 471);
            this.txbChiphikhac.Name = "txbChiphikhac";
            this.txbChiphikhac.Size = new System.Drawing.Size(174, 22);
            this.txbChiphikhac.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 474);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Số nước";
            // 
            // txbSoNuoc
            // 
            this.txbSoNuoc.Location = new System.Drawing.Point(454, 471);
            this.txbSoNuoc.Name = "txbSoNuoc";
            this.txbSoNuoc.Size = new System.Drawing.Size(100, 22);
            this.txbSoNuoc.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Số điện";
            // 
            // txbSoDien
            // 
            this.txbSoDien.Location = new System.Drawing.Point(454, 432);
            this.txbSoDien.Name = "txbSoDien";
            this.txbSoDien.Size = new System.Drawing.Size(100, 22);
            this.txbSoDien.TabIndex = 18;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(612, 429);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(612, 474);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // TinhTienSH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 597);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbSoDien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbSoNuoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbChiphikhac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbMaNV);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.gvTTSH);
            this.Name = "TinhTienSH";
            this.Text = "Nhập Số Liệu Tiền Nhà Tập Thể";
            this.Load += new System.EventHandler(this.TinhTienSH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvTTSH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridView gvTTSH;
        private System.Windows.Forms.TextBox txbMaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbChiphikhac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbSoNuoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbSoDien;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBack;
    }
}