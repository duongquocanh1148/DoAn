namespace DoAn
{
    partial class BangTinhTienSH
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
            this.gvTienNhaTT = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvTienNhaTT)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbTitle.Location = new System.Drawing.Point(364, 50);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(333, 29);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Tiền Sinh Hoạt Nhà Tập Thể";
            // 
            // gvTienNhaTT
            // 
            this.gvTienNhaTT.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvTienNhaTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTienNhaTT.Location = new System.Drawing.Point(25, 117);
            this.gvTienNhaTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gvTienNhaTT.Name = "gvTienNhaTT";
            this.gvTienNhaTT.RowHeadersWidth = 51;
            this.gvTienNhaTT.RowTemplate.Height = 24;
            this.gvTienNhaTT.Size = new System.Drawing.Size(1034, 322);
            this.gvTienNhaTT.TabIndex = 4;
            this.gvTienNhaTT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTTSH_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(959, 55);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // BangTinhTienSH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.gvTienNhaTT);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BangTinhTienSH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính Tiền Sinh Hoạt Nhà Tập Thể";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvTienNhaTT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridView gvTienNhaTT;
        private System.Windows.Forms.Button btnBack;
    }
}