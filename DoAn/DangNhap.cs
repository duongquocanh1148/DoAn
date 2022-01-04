using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace DoAn
{
    public partial class DangNhap : Form
    {
        
        public DangNhap()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-ICRUG9KG\SQLEXPRESS;Initial Catalog=CNPM;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = txtTaiKhoan.Text;
                string mk = txtMatKhau.Text;
                string sql = "select*from NguoiDung where TaiKhoan='"+tk+"'and MatKhau='"+mk+"'"; 
                SqlCommand cmd= new SqlCommand(sql, conn);
                SqlDataReader rdr = cmd.ExecuteReader();    
                if (rdr.Read()==true)
                {
                 
                    Main f = new Main();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu ? ","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối ");
            }
            
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
