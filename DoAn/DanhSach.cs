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
        SqlCommand cmd,cmdQTCT;
        DataTable table = new DataTable();
        DataTable tableQTCT = new DataTable();
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

        }

        private void gvDSNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = gvDSNV.CurrentRow.Index;
            txbMaNV.Text = gvDSNV.Rows[i].Cells[0].Value.ToString();
            txbMaPhong.Text = gvDSNV.Rows[i].Cells[3].Value.ToString();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            ChiTietNhanVien f = new ChiTietNhanVien();
            cmd = connect.CreateCommand();
            cmd.CommandText = @"select Distinct NHANVIEN.MaNV, NgaySinh, HotenNV, GioiTinh, NoiSinh, SoBHXH,Tenchucvu,Tenphong,NguyenQuan, HKThuongTru,HKTamTru,CTNHANVIEN.CCCD,NgayCap,NoiCap,Quoctich,NgayvaoDoan,NgayvaoDang,HocVan,ChuyenMon
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
            cmdQTCT.CommandText = @"select distinct Thoigian,Tenchucvu,Tenphong
                                    from QUATRINHCONGTAC,CTNHANVIEN
                                    join NHANVIEN on CTNHANVIEN.MaNV = NHANVIEN.MaNV
                                    join CHUCVU on CHUCVU.Machucvu = NHANVIEN.Machucvu
                                    join PHONG on PHONG.Maphong = NHANVIEN.Maphong
                                    where CTNHANVIEN.MaNV = '"+ txbMaNV.Text + "' ";
            adapter.SelectCommand = cmdQTCT;
            tableQTCT.Clear();
            adapter.Fill(tableQTCT);
            f.gvQTCT.DataSource = tableQTCT;
            this.Hide();          
            f.ShowDialog();
            this.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
