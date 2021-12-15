namespace DoAn
{
    partial class ChucVu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// Thay đổi code
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChucVu));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsbtnFix = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tsbtnUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.tsbtnBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.gvChucVu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxIDChucVu = new System.Windows.Forms.TextBox();
            this.tbxNameChucVu = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvChucVu)).BeginInit();
            this.SuspendLayout();
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
            this.tsbtnUpdate,
            this.toolStripLabel6,
            this.tsbtnBack,
            this.toolStripLabel5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnAdd
            // 
            this.tsbtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAdd.Image = global::DoAn.Properties.Resources.toolStripButton1_Image;
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
            this.tsbtnDelete.Click += new System.EventHandler(this.tsbtnDelete_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(35, 24);
            this.toolStripLabel3.Text = "Xóa";
            // 
            // tsbtnUpdate
            // 
            this.tsbtnUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnUpdate.Image = global::DoAn.Properties.Resources.toolStripButton6_Image;
            this.tsbtnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUpdate.Name = "tsbtnUpdate";
            this.tsbtnUpdate.Size = new System.Drawing.Size(29, 24);
            this.tsbtnUpdate.Text = "Cập Nhật";
            this.tsbtnUpdate.Click += new System.EventHandler(this.tsbtnUpdate_Click);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(71, 24);
            this.toolStripLabel6.Text = "Cập Nhật";
            // 
            // tsbtnBack
            // 
            this.tsbtnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnBack.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnBack.Image")));
            this.tsbtnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnBack.Name = "tsbtnBack";
            this.tsbtnBack.Size = new System.Drawing.Size(29, 24);
            this.tsbtnBack.Text = "Hủy";
            this.tsbtnBack.Click += new System.EventHandler(this.tsbtnBack_Click);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(63, 24);
            this.toolStripLabel5.Text = "Quay lại";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbTitle.Location = new System.Drawing.Point(286, 48);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(176, 29);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Bảng Chức Vụ";
            // 
            // gvChucVu
            // 
            this.gvChucVu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvChucVu.Location = new System.Drawing.Point(0, 93);
            this.gvChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gvChucVu.Name = "gvChucVu";
            this.gvChucVu.RowHeadersWidth = 51;
            this.gvChucVu.RowTemplate.Height = 24;
            this.gvChucVu.Size = new System.Drawing.Size(800, 214);
            this.gvChucVu.TabIndex = 4;
            this.gvChucVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvChucVu_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã chức vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên chức vụ";
            // 
            // tbxIDChucVu
            // 
            this.tbxIDChucVu.Location = new System.Drawing.Point(138, 326);
            this.tbxIDChucVu.Name = "tbxIDChucVu";
            this.tbxIDChucVu.Size = new System.Drawing.Size(100, 22);
            this.tbxIDChucVu.TabIndex = 8;
            // 
            // tbxNameChucVu
            // 
            this.tbxNameChucVu.Location = new System.Drawing.Point(496, 325);
            this.tbxNameChucVu.Name = "tbxNameChucVu";
            this.tbxNameChucVu.Size = new System.Drawing.Size(100, 22);
            this.tbxNameChucVu.TabIndex = 9;
            // 
            // ChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxNameChucVu);
            this.Controls.Add(this.tbxIDChucVu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gvChucVu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChucVu";
            this.Text = "Chức Vụ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvChucVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsbtnFix;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton tsbtnBack;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripButton tsbtnUpdate;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridView gvChucVu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxIDChucVu;
        private System.Windows.Forms.TextBox tbxNameChucVu;
    }
}