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
        SqlConnection connect;
        SqlCommand cmd;
        DataTable table = new DataTable();
        public DanhSach()
        {
            InitializeComponent();
        }
        public DanhSach(TextBox t)
        {
            int i = gvDSNV.CurrentRow.Index;
            txbMaNV.Text = gvDSNV.Rows[i].Cells[0].Value.ToString();
            t.Text = txbMaNV.Text;
        }
        

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(ConnectSQL.connectString);
            connect.Open();
            loadData();
        }
        void loadData()
        {
            cmd = connect.CreateCommand();
            cmd.CommandText = "Select * from NHANVIEN ";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            gvDSNV.DataSource = table;
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

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            ChiTietNhanVien f = new ChiTietNhanVien();
            /*cmd = connect.CreateCommand();
            cmd.CommandText = "Select * from CTNHANVIEN WHERE MaNV = '" + txbMaNV.Text + "'";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            ChiTietNhanVien.gvCTNV.DataSource = table;*/
            this.Close();
            f.ShowDialog();
            this.Show();
        }
    }
}
