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
            if (txbIDRoom.Text == "") MessageBox.Show("Vui long nhập mã phòng!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (txbIDRoom.Text == "") MessageBox.Show("Vui long nhap mã phòng!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                connect.Open();
                ViTriCongTac f = new ViTriCongTac();
                cmd = connect.CreateCommand();
                cmd.CommandText = @"select distinct MaNV,HotenNV,Machucvu,GioiTinh,NgaySinh,SoBHXH from NHANVIEN
                                    where MaPhong = '"+txbIDRoom.Text+"'";
                adapter.SelectCommand = cmd;
                table.Clear();
                adapter.Fill(table);
                f.gvViTriCongTac.DataSource = table;
                f.lbTitle.Text = txbTenPhong.Text.ToUpper();
                f.lbIDRoom.Text = "Mã phòng: "+txbIDRoom.Text;
                int i = f.gvViTriCongTac.RowCount - 1;
                f.lbSL.Text = "Số lượng nhân viên: " + i;
                this.Hide();
                f.ShowDialog();
                this.Show();
                connect.Close();
            }
        }
        
        
        void ThemNV()
        {
            cmd = connect.CreateCommand();
            cmd.CommandText = @"update NHANVIEN set MaPhong = '" + txbIDRoom.Text + "'" +
                "where MaNV = '"+txbMaQL.Text+"'";
            cmd.ExecuteNonQuery();
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

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txbIDRoom.Text == "" || txbTenPhong.Text == "")
                    MessageBox.Show("Vui long nhập đầy đủ thông tin!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    connect.Open();
                    cmd = connect.CreateCommand();
                    cmd.CommandText = @"insert into PHONG values ('" + txbIDRoom.Text + "',N'" + txbTenPhong.Text + "','')";
                    cmd.ExecuteNonQuery();
                    ThemNV();
                    connect.Close();
                    MessageBox.Show("Add Completed!", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                    Clear();
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Không được trùng mã phòng!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (txbIDRoom.Text == "" || txbTenPhong.Text == "")
                MessageBox.Show("Vui long nhập mã phòng!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                connect.Open();
                cmd = connect.CreateCommand();
                cmd.CommandText = @"delete from PHONG where Maphong = '" + txbIDRoom.Text + "'";
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Delete Completed!", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
                Clear();
            }
        }
    }
}
