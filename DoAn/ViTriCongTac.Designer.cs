namespace DoAn
{
    partial class ViTriCongTac
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbSL = new System.Windows.Forms.Label();
            this.lbIDRoom = new System.Windows.Forms.Label();
            this.gvViTriCongTac = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvViTriCongTac)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1216, 151);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 33);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(551, 38);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(118, 29);
            this.lbTitle.TabIndex = 5;
            this.lbTitle.Text = "PHÒNG :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbSL);
            this.groupBox1.Controls.Add(this.lbIDRoom);
            this.groupBox1.Location = new System.Drawing.Point(304, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 113);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // lbSL
            // 
            this.lbSL.AutoSize = true;
            this.lbSL.Location = new System.Drawing.Point(12, 71);
            this.lbSL.Name = "lbSL";
            this.lbSL.Size = new System.Drawing.Size(120, 16);
            this.lbSL.TabIndex = 4;
            this.lbSL.Text = "Số lượng nhân viên";
            // 
            // lbIDRoom
            // 
            this.lbIDRoom.AutoSize = true;
            this.lbIDRoom.Location = new System.Drawing.Point(12, 24);
            this.lbIDRoom.Name = "lbIDRoom";
            this.lbIDRoom.Size = new System.Drawing.Size(68, 16);
            this.lbIDRoom.TabIndex = 1;
            this.lbIDRoom.Text = "Mã Phòng";
            // 
            // gvViTriCongTac
            // 
            this.gvViTriCongTac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvViTriCongTac.Location = new System.Drawing.Point(0, 216);
            this.gvViTriCongTac.Name = "gvViTriCongTac";
            this.gvViTriCongTac.RowHeadersWidth = 51;
            this.gvViTriCongTac.RowTemplate.Height = 24;
            this.gvViTriCongTac.Size = new System.Drawing.Size(1357, 235);
            this.gvViTriCongTac.TabIndex = 7;
            this.gvViTriCongTac.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvViTriCongTac_CellContentClick);
            // 
            // ViTriCongTac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 450);
            this.Controls.Add(this.gvViTriCongTac);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnBack);
            this.Name = "ViTriCongTac";
            this.Text = "Vị Trí Công Tác";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvViTriCongTac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label lbSL;
        public System.Windows.Forms.Label lbIDRoom;
        public System.Windows.Forms.DataGridView gvViTriCongTac;
    }
}