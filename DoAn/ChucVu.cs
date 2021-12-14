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
            gvChucVu.DataSource = GetAllChucVu().Tables[0];
        }
        DataSet GetAllChucVu()
        {
            DataSet data = new DataSet();
            string query = "select * from CHUCVU";
            using (SqlConnection connect = new SqlConnection(ConnectSQL.connectString))
            {
                connect.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                adapter.Fill(data);
                connect.Close();
            }
            return data;
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
