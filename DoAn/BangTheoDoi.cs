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
            txbMaNV.ReadOnly = true;
            loadData();
        }
        
        void loadData()
        {
            connect.Open();
            cmd = connect.CreateCommand();
            cmd.CommandText = "Select MaNV,NghiKP,NghiBHXH,NghiCP,Lydo from THEODOISONGAYNGHI ";
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

        private void btnFix_Click(object sender, EventArgs e)
        {
            connect.Open();
            if (txbMaNV.Text == "") MessageBox.Show("Vui lòng nhập mã nhân viên!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                cmd = connect.CreateCommand();
                cmd.CommandText = @"update THEODOISONGAYNGHI set NghiKP = "+int.Parse(txbNghiKP.Text)+"" +
                    ",NghiBHXH = "+ int.Parse(txbNghiBHXH.Text)+"" +
                    ",NghiCP = "+ int.Parse(txbNghiCP.Text)+"" +
                    ",Lydo = N'"+txbLydo.Text+"'" +
                    "where MaNV = '"+txbMaNV.Text+"'";
                cmd.ExecuteNonQuery();
                
                MessageBox.Show("Chỉnh sửa thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connect.Close();
                loadData();
            }
        }

        private void gvTDSNN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = gvTDSNN.CurrentRow.Index;
            txbMaNV.Text = gvTDSNN.Rows[i].Cells[0].Value.ToString();
            txbNghiKP.Text = gvTDSNN.Rows[i].Cells[1].Value.ToString();
            txbNghiBHXH.Text = gvTDSNN.Rows[i].Cells[2].Value.ToString();
            txbNghiCP.Text = gvTDSNN.Rows[i].Cells[3].Value.ToString();
            txbLydo.Text = gvTDSNN.Rows[i].Cells[4].Value.ToString();
        }
        
        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
