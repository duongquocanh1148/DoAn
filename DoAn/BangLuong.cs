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
    public partial class BangLuong : Form
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlConnection connect;
        SqlCommand cmd;
        DataTable table = new DataTable();
        public BangLuong()
        {
            InitializeComponent();
        }
        private void tiềnLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void loadData()
        {
            cmd = connect.CreateCommand();
            cmd.CommandText = "select distinct NHANVIEN.MaNV , HotenNV, Tenchucvu, HeSoPhuCap As PhuCapChucVu, NghiCP, NghiKP, NghiBHXH, LuongBD, ThueTNCN, TongCPSH, Tongluong as TổngSố from LUONG join NHANVIEN on NHANVIEN.MaNV = LUONG.MaNV join CHUCVU on CHUCVU.Machucvu = NHANVIEN.Machucvu join HESOLUONG on HESOLUONG.MaNV = NHANVIEN.MaNV join THEODOISONGAYNGHI on THEODOISONGAYNGHI.MaNV = NHANVIEN.MaNV join TINHTIENSINHHOAT on TINHTIENSINHHOAT.MaNV = NHANVIEN.MaNV  ";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            gvBangLuong.DataSource = table;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(ConnectSQL.connectString);
            connect.Open();
            loadData();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvBangLuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
