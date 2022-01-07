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

       

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void bảngHệSốLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BangHeSoLuong f = new BangHeSoLuong();
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
            DanhSachNhaTT f = new DanhSachNhaTT();
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
        private void bốTríCôngTácToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            BoTriCongTac f = new BoTriCongTac();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhongBan f = new PhongBan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnTNTT_Click(object sender, EventArgs e)
        {
            BangTinhTienSH f = new BangTinhTienSH();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }       
        private void btnDSNV_Click(object sender, EventArgs e)
        {
            DanhSach f = new DanhSach();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            FormThemNhanVien f = new FormThemNhanVien();
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

        private void btnTinhTienNhaTT_Click(object sender, EventArgs e)
        {
            TinhTienNhaTT f = new TinhTienNhaTT();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
