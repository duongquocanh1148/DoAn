using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class BangHeSoLuong : Form
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlConnection connect = new SqlConnection(ConnectSQL.connectString);
        SqlCommand cmd;
        DataTable table = new DataTable();
        public BangHeSoLuong()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BangHeSoLuong_Load(object sender, EventArgs e)
        {
            string[] s = DateTime.Now.ToString().Split(' ');
            string[] year = s[0].Split('/');
            loadData();
            lbNam.Text = "Năm áp dụng : " + year[2];
            

        }
        void loadData()
        {
            connect.Open();
            cmd = connect.CreateCommand();
            cmd.CommandText = @"select MaNV,Machucvu,Nhomngach,Hesoluong,Bac,MucluongCB,HeSoPhuCap from HESOLUONG ";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            gvBHSL.DataSource = table;
            connect.Close();
        }
        private void gvBHSL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = gvBHSL.CurrentRow.Index;
            txbMaNV.Text = gvBHSL.Rows[i].Cells[0].Value.ToString();
            txbChucVu.Text = gvBHSL.Rows[i].Cells[1].Value.ToString();
            txbNhomNgach.Text = gvBHSL.Rows[i].Cells[2].Value.ToString();
            txbHSL.Text = gvBHSL.Rows[i].Cells[3].Value.ToString();
            txbBac.Text = gvBHSL.Rows[i].Cells[4].Value.ToString();
            txbLuongCB.Text = gvBHSL.Rows[i].Cells[5].Value.ToString();
            txbHSPC.Text = gvBHSL.Rows[i].Cells[6].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbMaNV.Text == "" || txbChucVu.Text == "" || txbNhomNgach.Text == "" || txbHSL.Text == "" || txbBac.Text == "" || txbLuongCB.Text == "" || txbHSPC.Text == "")
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                connect.Open();
                cmd = connect.CreateCommand();
                cmd.CommandText = @"insert into HESOLUONG values('" + txbMaNV.Text + "','" + txbNhomNgach.Text + "'," + txbHSL.Text + "," + txbBac.Text + "," + txbLuongCB.Text + "," + txbHSPC.Text + ",'" + txbChucVu.Text + "')";
                cmd.ExecuteNonQuery();
                connect.Close();
                loadData();
                MessageBox.Show("Thêm thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txbMaNV.Text == "" || txbChucVu.Text == "" || txbNhomNgach.Text == "" || txbHSL.Text == "" || txbBac.Text == "" || txbLuongCB.Text == "" || txbHSPC.Text == "")
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                connect.Open();
                cmd = connect.CreateCommand();
                cmd.CommandText = @"update HESOLUONG
                                set MucluongCB = '" + txbLuongCB.Text + "'" +
                                    ",NhomNgach = '" + txbNhomNgach.Text + "'" +
                                    ",Hesoluong = '" + txbHSL.Text + "'" +
                                    ",Bac = '" + txbBac.Text + "'" +
                                    ",HeSoPhuCap= '" + txbHSPC.Text + "'" +
                                    "where MaNV = '"+txbMaNV.Text+"'";
                cmd.ExecuteNonQuery();
                connect.Close();
                loadData();
                MessageBox.Show("Cập nhật thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
        }
    

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txbMaNV.Text == "")
                MessageBox.Show("Vui lòng nhập mã nhân viên cần xóa!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                connect.Open();
                cmd = connect.CreateCommand();
                cmd.CommandText = @"delete form HESOLUONG where MaNV = '" + txbMaNV.Text + "'";
                cmd.ExecuteNonQuery();
                connect.Close();
                loadData();
                MessageBox.Show("Xóa thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
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

    }
}
