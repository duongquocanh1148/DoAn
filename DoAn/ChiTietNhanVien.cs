using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{

    public partial class ChiTietNhanVien : Form
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlConnection connect;
        SqlCommand cmd;
        DataTable table = new DataTable();
        public ChiTietNhanVien()
        {
            InitializeComponent();
        }
     

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i = gvCTNV.CurrentRow.Index;
            txbMaNV.Text = gvCTNV.Rows[i].Cells[0].Value.ToString();
            txbHoTen.Text = gvCTNV.Rows[i].Cells[1].Value.ToString();
            txbGioiTinh.Text = gvCTNV.Rows[i].Cells[4].Value.ToString();
            txbNgaySinh.Text = gvCTNV.Rows[i].Cells[5].Value.ToString();
            txbBHXH.Text = gvCTNV.Rows[i].Cells[6].Value.ToString();
            txbNoiSinh.Text = gvCTNV.Rows[i].Cells[8].Value.ToString();
            txbChucVu.Text = gvCTNV.Rows[i].Cells[9].Value.ToString();
            txbNoiCT.Text = gvCTNV.Rows[i].Cells[10].Value.ToString();
            txbNguyenQuan.Text = gvCTNV.Rows[i].Cells[11].Value.ToString();
            txbHoKhauThuongTru.Text = gvCTNV.Rows[i].Cells[12].Value.ToString();
            txbHoKhauTamTru.Text = gvCTNV.Rows[i].Cells[13].Value.ToString();
            txbNgayCap.Text = gvCTNV.Rows[i].Cells[14].Value.ToString();
            txbNoiCap.Text = gvCTNV.Rows[i].Cells[15].Value.ToString();
            txbQuocTich.Text = gvCTNV.Rows[i].Cells[16].Value.ToString();
            txbNgayVaoDoan.Text = gvCTNV.Rows[i].Cells[17].Value.ToString();
            txbNgayVaoDang.Text = gvCTNV.Rows[i].Cells[18].Value.ToString();
            txbTrinhDoHocVan.Text = gvCTNV.Rows[i].Cells[19].Value.ToString();
            txbTrinhDoChuyenMon.Text = gvCTNV.Rows[i].Cells[20].Value.ToString();

        }
        
 

        private void tsbtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
