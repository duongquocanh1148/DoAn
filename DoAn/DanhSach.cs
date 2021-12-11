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
        public DanhSach()
        {
            InitializeComponent();
        }
        

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAllNhanVien().Tables[0];
          
        }
        DataSet GetAllNhanVien()
        {
            DataSet data = new DataSet();
            string query = "select * from NHANVIEN";
            using (SqlConnection connect = new SqlConnection(ConnectSQL.connectString))
            {
                connect.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                adapter.Fill(data);
                connect.Close();
            }
            return data;
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
    }
}
