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
    public partial class ChucVu : Form
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlConnection connect;
        SqlCommand cmd;
        DataTable table = new DataTable();
        public ChucVu()
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

        private void Form1_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(ConnectSQL.connectString);
            connect.Open();
            loadData();
        }
       
        void loadData()
        {
            cmd = connect.CreateCommand();
            cmd.CommandText = "Select * from CHUCVU ";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            gvChucVu.DataSource = table;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            FormThemChucVu f = new FormThemChucVu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
