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
    public partial class PhongBan : Form
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlConnection connect = new SqlConnection(ConnectSQL.connectString);
        SqlCommand cmd;
        DataTable table = new DataTable();
        public PhongBan()
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
            cmd.CommandText = "select * from PHONG";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            gvPhongBan.DataSource = table;
            connect.Close();
        }


        private void gvPhongBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = gvPhongBan.CurrentRow.Index;
            txbIDRoom.Text = gvPhongBan.Rows[i].Cells[0].Value.ToString();
            txbTenPhong.Text = gvPhongBan.Rows[i].Cells[1].Value.ToString();
            txbMaQL.Text = gvPhongBan.Rows[i].Cells[2].Value.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txbIDRoom.Text == "") MessageBox.Show("Vui long nhap ma phong!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                connect.Open();
                cmd = connect.CreateCommand();
                cmd.CommandText = "select * from PHONG where MaPhong = '" + txbIDRoom.Text + "'";
                adapter.SelectCommand = cmd;
                table.Clear();
                adapter.Fill(table);
                gvPhongBan.DataSource = table;
                connect.Close();
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (txbIDRoom.Text == "") MessageBox.Show("Vui long nhap ma phong!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                connect.Open();
                ViTriCongTac f = new ViTriCongTac();
                cmd = connect.CreateCommand();
                cmd.CommandText = @"select distinct MaNV,HotenNV,Machucvu,GioiTinh,NgaySinh,SoBHXH,SoNgayNghi from NHANVIEN
                                    where MaPhong = '"+txbIDRoom.Text+"'";
                adapter.SelectCommand = cmd;
                table.Clear();
                adapter.Fill(table);
                f.gvViTriCongTac.DataSource = table;
                this.Hide();
                f.ShowDialog();
                this.Show();
                connect.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txbIDRoom.Text == "") MessageBox.Show("Vui long nhap ma phong!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                connect.Open();
                cmd = connect.CreateCommand();
                cmd.CommandText = @"update PHONG set MaQL = '"+txbMaQL.Text+"' where Maphong = '"+txbIDRoom.Text+"'";
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Update Completed!", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbIDRoom.Text == "" || txbTenPhong.Text == "" || txbMaQL.Text == "") 
                MessageBox.Show("Vui long nhap day du thong tin!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                connect.Open();
                cmd = connect.CreateCommand();
                cmd.CommandText = @"insert into PHONG values ('"+txbIDRoom.Text+"',N'"+txbTenPhong.Text+"','"+txbMaQL.Text+"')";
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Add Completed!", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txbIDRoom.Text == "" || txbTenPhong.Text == "" || txbMaQL.Text == "")
                MessageBox.Show("Vui long nhap ma phong!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                connect.Open();
                cmd = connect.CreateCommand();
                cmd.CommandText = @"delete from PHONG where Maphong = '"+txbIDRoom.Text+"'";
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Delete Completed!", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
        }
    }
}
