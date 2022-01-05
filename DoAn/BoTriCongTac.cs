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
    public partial class BoTriCongTac : Form
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlConnection connect = new SqlConnection(ConnectSQL.connectString);
        SqlCommand cmd,cmd1;
        DataTable table = new DataTable();
        DataTable table1 = new DataTable();
        string dateBD;
        public BoTriCongTac()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            gvNhanVien.Hide();                                            
        }

        void loadData()
        {
            
            if (txbMaNV.Text == "") MessageBox.Show("Vui long nhap ma nhan vien", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                connect.Open();
                cmd = connect.CreateCommand();
                cmd.CommandText = @"select distinct HotenNV, NHANVIEN.Maphong,Tenphong,NHANVIEN.Machucvu,Tenchucvu
                                from NHANVIEN
                                join PHONG on  PHONG.Maphong= NHANVIEN.Maphong 
                                join CHUCVU on CHUCVU.Machucvu = NHANVIEN.Machucvu
                                where NHANVIEN.MaNV = '" + txbMaNV.Text + "'";
                adapter.SelectCommand = cmd;
                table.Clear();
                adapter.Fill(table);
                gvNhanVien.DataSource = table;
                
                int i = gvNhanVien.CurrentRow.Index;
                txbTenNV.Text = gvNhanVien.Rows[i].Cells[0].Value.ToString();
                txbMaPhong.Text = gvNhanVien.Rows[i].Cells[1].Value.ToString();
                txbPhongOld.Text = gvNhanVien.Rows[i].Cells[2].Value.ToString();
                txbMaCV.Text = gvNhanVien.Rows[i].Cells[3].Value.ToString();
                txbChucvuOld.Text = gvNhanVien.Rows[i].Cells[4].Value.ToString();
                cmd1 = connect.CreateCommand();
                cmd1.CommandText = @"select NgayBD from CONGTAC where MaNV = '" + txbMaNV.Text + "'";
                adapter.SelectCommand = cmd1;
                table1.Clear();
                adapter.Fill(table1);
                gvCongTac.DataSource = table1;
                int j = gvCongTac.CurrentRow.Index;     
                dateBD = gvCongTac.Rows[j].Cells[0].Value.ToString();
                connect.Close();
            }
        }

        void Clear()
        {
            txbMaNV.Text = "";
            txbMaCV.Text = "";
            txbMaCVNew.Text = "";
            txbMaPhong.Text = "";
            txbMaPhongNew.Text = "";
            txbPhongOld.Text = "";
            txbPhongNew.Text = "";
            txbSQD.Text = "";
            txbTenNV.Text = "";
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string s = lbSQD.Text + txbSQD.Text;
            try
            {
                if (txbMaPhongNew.Text == "" || txbMaCVNew.Text == "" || txbMaNV.Text == "")
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    connect.Open();
                    cmd = connect.CreateCommand();
                    cmd.CommandText = @"insert into CONGTAC values ('" + s + "','" + txbMaPhongNew.Text + "','" + txbMaCVNew.Text + "','" + txbMaNV.Text + "','" + DateTime.Parse(dtpNgayBD.Text) + "','" + dateBD + "','" + txbLydo.Text + "')";
                    cmd.ExecuteNonQuery();
                   
                    MessageBox.Show("Done!", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    connect.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
