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
    public partial class DanhSach : Form
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlConnection connect = new SqlConnection(ConnectSQL.connectString);
        SqlCommand cmd,cmdQTCT,cmdNTT,cmdTN;
        DataTable table = new DataTable();
        DataTable tableQTCT = new DataTable();
        DataTable tableNTT = new DataTable();
        DataTable tableTN = new DataTable();
        public DanhSach()
        {
            InitializeComponent();
        }      
        

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {                      
            loadData();
        }
        void loadData()
        {
            connect.Open();
            cmd = connect.CreateCommand();
            cmd.CommandText = "Select * from NHANVIEN ";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            gvDSNV.DataSource = table;
            int i = gvDSNV.CurrentRow.Index;
            txbMaNV.Text = gvDSNV.Rows[i].Cells[0].Value.ToString();
            txbMaPhong.Text = gvDSNV.Rows[i].Cells[3].Value.ToString();
            connect.Close();
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChucVu f = new ChucVu();    
            f.ShowDialog();
        }     
        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main f = new Main();
            this.Close();
            f.ShowDialog();
            this.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            FormThemNhanVien f = new FormThemNhanVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void gvDSNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = gvDSNV.CurrentRow.Index;
            txbMaNV.Text = gvDSNV.Rows[i].Cells[0].Value.ToString();
            txbMaPhong.Text = gvDSNV.Rows[i].Cells[3].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txbMaNV.Text == "") MessageBox.Show("Vui lòng nhập mã nhân viên!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                connect.Open();
                cmd = connect.CreateCommand();
                cmd.CommandText = "Select * from NHANVIEN where MaNV = '" + txbMaNV.Text + "'";                
                adapter.SelectCommand = cmd;
                table.Clear();
                adapter.Fill(table);
                gvDSNV.DataSource = table;
                connect.Close();
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if(txbMaNV.Text == "") MessageBox.Show("Vui lòng nhập mã nhân viên!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                connect.Open();
                ChiTietNhanVien f = new ChiTietNhanVien();
                cmd = connect.CreateCommand();
                cmd.CommandText = @"select Distinct NHANVIEN.MaNV, NgaySinh, HotenNV, GioiTinh, NoiSinh, SoBHXH,Tenchucvu,Tenphong,NguyenQuan, HKThuongTru,HKTamTru,CTNHANVIEN.CCCD,NgayCap,NoiCap,Quoctich,TonGiao,NgayvaoDoan,NgayvaoDang,HocVan,ChuyenMon,NgoaiNgu
                                from CTNHANVIEN
                                join NHANVIEN on CTNHANVIEN.MaNV = NHANVIEN.MaNV
                                join CHUCVU on CHUCVU.Machucvu = NHANVIEN.Machucvu
                                join PHONG on PHONG.Maphong = NHANVIEN.Maphong
                                WHERE CTNHANVIEN.MaNV = '" + txbMaNV.Text + "'";
                adapter.SelectCommand = cmd;
                table.Clear();
                adapter.Fill(table);
                f.gvCTNV.DataSource = table;
                //gvQTCT
                cmdQTCT = connect.CreateCommand();
                cmdQTCT.CommandText = @"select ThoigianBD,ThoigianKT,Chucvu,NoiCongTac from QUATRINHCONGTAC where MaNV = '"+txbMaNV.Text+"'";                                  
                adapter.SelectCommand = cmdQTCT;
                tableQTCT.Clear();
                adapter.Fill(tableQTCT);
                f.gvQTCT.DataSource = tableQTCT;
                //gvNTT
                cmdNTT = connect.CreateCommand();
                cmdNTT.CommandText = @"select TenPhongNTT,DienTichThue,SLNguoiDK from DANGKYNHATT where MaNV = '"+txbMaNV.Text+"'";
                adapter.SelectCommand = cmdNTT;
                tableNTT.Clear();
                adapter.Fill(tableNTT);
                f.gvNTT.DataSource = tableNTT;
                //gvTN
                cmdTN = connect.CreateCommand();
                cmdTN.CommandText = @"select TenTN,QuanHe,NamSinh,NgheNghiep,NoiCongTacTN from THANNHAN where MaNV = '"+txbMaNV.Text+"'";
                adapter.SelectCommand = cmdTN;
                tableTN.Clear();
                adapter.Fill(tableTN);
                f.gvTN.DataSource = tableTN;
                this.Hide();
                f.ShowDialog();
                this.Show();
                connect.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormThemNhanVien f = new FormThemNhanVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
