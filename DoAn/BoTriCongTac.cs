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
        SqlCommand cmdNV,cmdCT,cmdQTCT;
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
                cmdNV = connect.CreateCommand();
                cmdNV.CommandText = @"select distinct HotenNV, NHANVIEN.Maphong,Tenphong,NHANVIEN.Machucvu,Tenchucvu
                                from NHANVIEN
                                join PHONG on  PHONG.Maphong= NHANVIEN.Maphong 
                                join CHUCVU on CHUCVU.Machucvu = NHANVIEN.Machucvu
                                where NHANVIEN.MaNV = '" + txbMaNV.Text + "'";
                adapter.SelectCommand = cmdNV;
                table.Clear();
                adapter.Fill(table);
                gvNhanVien.DataSource = table;
                
                int i = gvNhanVien.CurrentRow.Index;
                txbTenNV.Text = gvNhanVien.Rows[i].Cells[0].Value.ToString();
                txbMaPhong.Text = gvNhanVien.Rows[i].Cells[1].Value.ToString();
                txbPhongOld.Text = gvNhanVien.Rows[i].Cells[2].Value.ToString();
                txbMaCV.Text = gvNhanVien.Rows[i].Cells[3].Value.ToString();
                txbChucvuOld.Text = gvNhanVien.Rows[i].Cells[4].Value.ToString();
                cmdCT = connect.CreateCommand();
                cmdCT.CommandText = @"select ThoigianBD from QUATRINHCONGTAC where MaNV = '" + txbMaNV.Text + "'";
                adapter.SelectCommand = cmdCT;
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
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
            
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
            
            try
            {
                if (txbMaPhongNew.Text == "" || txbMaCVNew.Text == "" || txbMaNV.Text == "" || txbSQD.Text == "")
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    connect.Open();
                    string s = lbSQD.Text + txbSQD.Text;
                    cmdNV = connect.CreateCommand();
                    cmdNV.CommandText = @"insert into CONGTAC values ('" + s + "','" + txbMaPhongNew.Text + "','" + txbMaCVNew.Text + "','" + txbMaNV.Text + "','" + dateBD + "','" + DateTime.Parse(dtpNgayBD.Text) + "',N'" + txbLydo.Text + "')";
                    cmdNV.ExecuteNonQuery();
                    cmdCT = connect.CreateCommand();
                    cmdCT.CommandText = @"insert into QUATRINHCONGTAC values('"+txbMaNV.Text+"','"+DateTime.Parse(dtpNgayBD.Text)+"','"+null+"',N'"+txbChucvuNew.Text+"',N'"+txbPhongNew.Text+"')";
                    cmdCT.ExecuteNonQuery();
                    cmdQTCT = connect.CreateCommand();
                    cmdQTCT.CommandText = @"update QUATRINHCONGTAC set ThoigianKT = CASE WHEN ThoigianBD = '"+dateBD+"' THEN '"+ DateTime.Parse(dtpNgayBD.Text) + "' END where MaNV = '"+txbMaNV.Text+"'";
                    cmdQTCT.ExecuteNonQuery();
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
