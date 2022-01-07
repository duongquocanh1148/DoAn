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
        SqlConnection connect = new SqlConnection(ConnectSQL.connectString);
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
            txbMaNV.ReadOnly = true;
            txbCCCD.ReadOnly = true;
            txbChucVu.ReadOnly = true;
            int i = gvCTNV.CurrentRow.Index;
            txbMaNV.Text = gvCTNV.Rows[i].Cells[0].Value.ToString();
            txbHoTen.Text = gvCTNV.Rows[i].Cells[1].Value.ToString();
            txbGioiTinh.Text = gvCTNV.Rows[i].Cells[4].Value.ToString();
            if (txbGioiTinh.Text == "False") txbGioiTinh.Text = "Nam";
            else txbGioiTinh.Text = "Nu";
            dtpNgaySinh.Text = gvCTNV.Rows[i].Cells[5].Value.ToString();
            txbBHXH.Text = gvCTNV.Rows[i].Cells[6].Value.ToString();
            txbNoiSinh.Text = gvCTNV.Rows[i].Cells[7].Value.ToString();
            txbChucVu.Text = gvCTNV.Rows[i].Cells[8].Value.ToString();
            txbNoiCT.Text = gvCTNV.Rows[i].Cells[9].Value.ToString();
            txbNguyenQuan.Text = gvCTNV.Rows[i].Cells[10].Value.ToString();
            txbHoKhauThuongTru.Text = gvCTNV.Rows[i].Cells[11].Value.ToString();
            txbHoKhauTamTru.Text = gvCTNV.Rows[i].Cells[12].Value.ToString();
            txbCCCD.Text = gvCTNV.Rows[i].Cells[13].Value.ToString();
            dtpNgayCap.Text = gvCTNV.Rows[i].Cells[14].Value.ToString();
            txbNoiCap.Text = gvCTNV.Rows[i].Cells[15].Value.ToString();
            txbQuocTich.Text = gvCTNV.Rows[i].Cells[16].Value.ToString();
            txbTonGiao.Text = gvCTNV.Rows[i].Cells[17].Value.ToString();
            dtpNgayVaoDoan.Text = gvCTNV.Rows[i].Cells[18].Value.ToString();
            dtpNgayVaoDang.Text = gvCTNV.Rows[i].Cells[19].Value.ToString();
            txbTrinhDoHocVan.Text = gvCTNV.Rows[i].Cells[20].Value.ToString();
            txbTrinhDoChuyenMon.Text = gvCTNV.Rows[i].Cells[21].Value.ToString();
            txbNgoaiNgu.Text = gvCTNV.Rows[i].Cells[22].Value.ToString();
            gvCTNV.Hide();
        }







        private void btnUpLoad_Click(object sender, EventArgs e)
        {
            connect.Open();
            cmd = connect.CreateCommand();
            cmd.CommandText = @"update CTNHANVIEN set HKTamTru =N'" + txbHoKhauTamTru.Text + "'" +
                ", NguyenQuan = N'"+txbNguyenQuan.Text+"'" +
                ", HKThuongTru = N'"+txbHoKhauThuongTru.Text+"'" +
                ", NoiSinh = '"+txbNoiSinh.Text+"'" +
                ", Quoctich = '"+txbQuocTich.Text+"'" +
                ", TonGiao = N'"+txbTonGiao.Text+"'"
                + ", NgayCap = '" + DateTime.Parse(dtpNgayCap.Text) + "'"
                + ", NoiCap = N'" + txbNoiCap.Text + "'"
                + ", NgayvaoDoan = '" + DateTime.Parse(dtpNgayVaoDoan.Text) + "'"
                + ", NgayvaoDang = '" + DateTime.Parse(dtpNgayVaoDang.Text) + "'" +
                ", HocVan = N'"+txbTrinhDoHocVan.Text+"'" +
                ", ChuyenMon = N'"+txbTrinhDoChuyenMon.Text+"'" +
                ", NgoaiNgu = N'"+txbNgoaiNgu.Text+"'"
                + "where MaNV = '" + txbMaNV.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cập nhật thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connect.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
