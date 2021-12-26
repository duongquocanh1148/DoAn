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
            ((System.ComponentModel.ISupportInitialize)(this.gvDSNhaTT)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDSNhaTT
            // 
            this.gvDSNhaTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDSNhaTT.Location = new System.Drawing.Point(108, 51);
            this.gvDSNhaTT.Name = "gvDSNhaTT";
            this.gvDSNhaTT.RowHeadersWidth = 51;
            this.gvDSNhaTT.RowTemplate.Height = 24;
            this.gvDSNhaTT.Size = new System.Drawing.Size(581, 341);
            this.gvDSNhaTT.TabIndex = 0;
            // 
            // DanhSachNhaTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gvDSNhaTT);
            this.Name = "DanhSachNhaTT";
            this.Text = "Danh Sách Nhà Tập Thể";
            ((System.ComponentModel.ISupportInitialize)(this.gvDSNhaTT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvDSNhaTT;
    }
}