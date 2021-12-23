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

        
        

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            
            cmd = connect.CreateCommand();
            cmd.CommandText = "insert into CHUCVU (Machucvu,Tenchucvu) values ('" + tbxIDChucVu.Text + "', '" + tbxNameChucVu.Text + "')";
            if(tbxIDChucVu.Text != "" || tbxNameChucVu.Text != "") cmd.ExecuteNonQuery();
            //code kiem tra trung ID
            else  MessageBox.Show("Vui long nhap ma chuc vu ");

            loadData();                    
        }

        private void gvChucVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {           
            int i = gvChucVu.CurrentRow.Index;
            tbxIDChucVu.Text = gvChucVu.Rows[i].Cells[0].Value.ToString();
            tbxNameChucVu.Text = gvChucVu.Rows[i].Cells[1].Value.ToString();         
        }

        private void tsbtnUpdate_Click(object sender, EventArgs e)
        {
            loadData();
            MessageBox.Show("Update Completed", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int i = gvChucVu.CurrentRow.Index;

                cmd = connect.CreateCommand();
                cmd.CommandText = "delete from CHUCVU WHERE Machucvu='" + gvChucVu.Rows[i].Cells[0].Value.ToString() + "'";
                cmd.ExecuteNonQuery();
                loadData();
                MessageBox.Show("Delete Completed", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Cannot Delete", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void tsbtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
