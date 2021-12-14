namespace DoAn
{
    partial class FormThemChucVu
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
            this.lbIDChucVu = new System.Windows.Forms.Label();
            this.lbNameChucVu = new System.Windows.Forms.Label();
            this.tbxIDChucVu = new System.Windows.Forms.TextBox();
            this.tbxNameChucVu = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(662, 64);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(286, 45);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(205, 29);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "THÊM CHỨC VỤ";
            // 
            // lbIDChucVu
            // 
            this.lbIDChucVu.AutoSize = true;
            this.lbIDChucVu.Location = new System.Drawing.Point(43, 114);
            this.lbIDChucVu.Name = "lbIDChucVu";
            this.lbIDChucVu.Size = new System.Drawing.Size(78, 16);
            this.lbIDChucVu.TabIndex = 2;
            this.lbIDChucVu.Text = "Mã Chức Vụ";
            // 
            // lbNameChucVu
            // 
            this.lbNameChucVu.AutoSize = true;
            this.lbNameChucVu.Location = new System.Drawing.Point(43, 159);
            this.lbNameChucVu.Name = "lbNameChucVu";
            this.lbNameChucVu.Size = new System.Drawing.Size(83, 16);
            this.lbNameChucVu.TabIndex = 3;
            this.lbNameChucVu.Text = "Tên Chức Vụ";
            // 
            // tbxIDChucVu
            // 
            this.tbxIDChucVu.Location = new System.Drawing.Point(150, 111);
            this.tbxIDChucVu.Name = "tbxIDChucVu";
            this.tbxIDChucVu.Size = new System.Drawing.Size(252, 22);
            this.tbxIDChucVu.TabIndex = 5;
            // 
            // tbxNameChucVu
            // 
            this.tbxNameChucVu.Location = new System.Drawing.Point(150, 156);
            this.tbxNameChucVu.Name = "tbxNameChucVu";
            this.tbxNameChucVu.Size = new System.Drawing.Size(252, 22);
            this.tbxNameChucVu.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(662, 208);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormThemChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbxNameChucVu);
            this.Controls.Add(this.tbxIDChucVu);
            this.Controls.Add(this.lbNameChucVu);
            this.Controls.Add(this.lbIDChucVu);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnBack);
            this.Name = "FormThemChucVu";
            this.Text = "Thêm Chức Vụ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbIDChucVu;
        private System.Windows.Forms.Label lbNameChucVu;
        private System.Windows.Forms.TextBox tbxIDChucVu;
        private System.Windows.Forms.TextBox tbxNameChucVu;
        private System.Windows.Forms.Button btnSave;
    }
}