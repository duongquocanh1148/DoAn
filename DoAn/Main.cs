using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void tiềnLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
             
        }

        private void bảngHệSốLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Còn thiếu layout
        }

        private void danhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSach f = new DanhSach();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChucVu f = new ChucVu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void nhàTậpThểToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DKNTT f = new DKNTT();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void tínhTiềnNhàTậpThểToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BangTinhTienSH f = new BangTinhTienSH();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void theoDõiSốNgàyNghỉToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BangTheoDoi f = new BangTheoDoi();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void bảngLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BangLuong f = new BangLuong();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void vịTríCôngTácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Còn thiếu layout
        }

        private void bốTríCôngTácToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            BoTriCongTac f = new BoTriCongTac();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
