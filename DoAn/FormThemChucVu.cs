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
    public partial class FormThemChucVu : Form
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlConnection connect = new SqlConnection(ConnectSQL.connectString);
        SqlCommand cmd;
        DataTable table = new DataTable();
        
        public FormThemChucVu()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void loadData()
        {
            cmd = connect.CreateCommand();
            cmd.CommandText = "select * from CHUCVU";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            connect.Open();
            cmd = connect.CreateCommand();
            cmd.CommandText = "INSERT INTO CHUCVU VALUES ('"+tbxIDChucVu+"', '"+tbxNameChucVu+"')";
            cmd.ExecuteNonQuery();
            loadData();
            connect.Close();
            this.Close();
        }
    }
}
