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
        SqlConnection connect = new SqlConnection(ConnectSQL.connectString);
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
            connect.Close();
        }                        
        private void gvChucVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {           
            int i = gvChucVu.CurrentRow.Index;
            tbxIDChucVu.Text = gvChucVu.Rows[i].Cells[0].Value.ToString();
            tbxNameChucVu.Text = gvChucVu.Rows[i].Cells[1].Value.ToString();         
        }               
        private void tsbtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxIDChucVu.Text == "" || tbxNameChucVu.Text == "") 
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    cmd = connect.CreateCommand();
                    cmd.CommandText = "insert into CHUCVU (Machucvu,Tenchucvu) values ('" + tbxIDChucVu.Text + "', '" + tbxNameChucVu.Text + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Không được thêm trùng mã chức vụ!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                       
            loadData();
        }             
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int i = gvChucVu.CurrentRow.Index;

                cmd = connect.CreateCommand();
                cmd.CommandText = "delete from CHUCVU WHERE Machucvu='" + gvChucVu.Rows[i].Cells[0].Value.ToString() + "'";
                cmd.ExecuteNonQuery();
                loadData();
                MessageBox.Show("Xóa thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không xóa được", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpLoad_Click(object sender, EventArgs e)
        {
            loadData();           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
