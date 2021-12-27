namespace DoAn
{
    partial class BangHeSoLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BangHeSoLuong));
            this.btnBack = new System.Windows.Forms.Button();

            this.gvBHSL = new System.Windows.Forms.DataGridView();
         
            ((System.ComponentModel.ISupportInitialize)(this.gvBHSL)).BeginInit();

            this.SuspendLayout();
            // 
            // btnBack
            // 

            this.btnBack.Location = new System.Drawing.Point(713, 44);

            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 

            // gvBHSL
            // 
            this.gvBHSL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBHSL.Location = new System.Drawing.Point(12, 101);
            this.gvBHSL.Name = "gvBHSL";
            this.gvBHSL.RowHeadersWidth = 51;
            this.gvBHSL.RowTemplate.Height = 24;
            this.gvBHSL.Size = new System.Drawing.Size(776, 337);
            this.gvBHSL.TabIndex = 4;

            // 
            // BangHeSoLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gvBHSL);

            this.Controls.Add(this.btnBack);
            this.Name = "BangHeSoLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng Hệ Số Lương";

            this.Load += new System.EventHandler(this.BangHeSoLuong_Load);
           
            ((System.ComponentModel.ISupportInitialize)(this.gvBHSL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView gvBHSL;

    }
}