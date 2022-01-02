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
    public partial class BangTheoDoi : Form
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlConnection connect = new SqlConnection(ConnectSQL.connectString);
        SqlCommand cmd;
        DataTable table = new DataTable();
        public BangTheoDoi()
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
            loadData();
        }
        
        void loadData()
        {
            connect.Open();
            cmd = connect.CreateCommand();
            cmd.CommandText = "Select * from THEODOISONGAYNGHI ";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            gvTDSNN.DataSource = table;
            connect.Close();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
