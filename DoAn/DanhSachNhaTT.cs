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
    public partial class DanhSachNhaTT : Form
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlConnection connect = new SqlConnection(ConnectSQL.connectString);
        SqlCommand cmd;
        DataTable table = new DataTable();
        public DanhSachNhaTT()
        {
            InitializeComponent();
        }

        private void DanhSachNhaTT_Load(object sender, EventArgs e)
        {
            loadData();
        }

        void loadData()
        {
            connect.Open();
            cmd = connect.CreateCommand();
            cmd.CommandText = @"select SoDK,DANGKYNHATT.MaNV,HotenNV,TenPhongNTT,DienTichThue,SLNguoiDK from DANGKYNHATT
                                join NHANVIEN on NHANVIEN.MaNV = DANGKYNHATT.MaNV";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            gvDSNhaTT.DataSource = table;
            connect.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            DKNTT f = new DKNTT();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = gvDSNhaTT.CurrentRow.Index;
            string soDK = gvDSNhaTT.Rows[i].Cells[0].Value.ToString();
            connect.Open();
            cmd = connect.CreateCommand();
            cmd.CommandText = @"delete from DANGKYNHATT where SoDK = '" + soDK + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connect.Close();
            loadData();
        }

        private void gvDSNhaTT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = gvDSNhaTT.CurrentRow.Index;
            string soDK = gvDSNhaTT.Rows[i].Cells[0].Value.ToString();
        }
    }
}
