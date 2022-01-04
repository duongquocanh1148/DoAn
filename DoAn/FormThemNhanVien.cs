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

    public partial class FormThemNhanVien : Form
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlConnection connect = new SqlConnection(ConnectSQL.connectString);
        SqlCommand cmd, cmd1;
        DataTable table = new DataTable();
        public FormThemNhanVien()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int gender = 0;
            connect.Open();
            try
            {
                cmd = connect.CreateCommand();

                if (ckbNu.Checked) gender = 1;
                else if (ckbNam.Checked) gender = 0;
                else MessageBox.Show("Vui long chon gioi tinh!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (tbxID.Text == "" || tbxHoTen.Text == "" || txbMaCV.Text == "" || txbMaPhong.Text == "" || tbxBHXH.Text == "")
                    MessageBox.Show("Vui long dien day du thong tin!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {

                    cmd.CommandText = @"INSERT INTO NHANVIEN VALUES ('" + tbxID.Text + "', N'" + tbxHoTen.Text + "', '" + txbMaCV.Text + "', '" + txbMaPhong.Text + "','" + gender + "', '" + DateTime.Parse(dtpNgaySinh.Text) + "', '" + tbxBHXH.Text + "', '" + 0 + "')";
                    cmd.ExecuteNonQuery();

                }

                cmd1 = connect.CreateCommand();
                if (tbxID.Text == "" || tbxNguyenQuan.Text == "" || tbxHKTT.Text == "" || tbxHKTTru.Text == "" || tbxCCCD.Text == "")
                    MessageBox.Show("Vui long dien day du thong tin!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    cmd1.CommandText = @"Insert into CTNHANVIEN values('" + tbxID.Text + "',N'" + tbxNguyenQuan.Text + "',N'" + tbxHKTT.Text + "','" + tbxHKTTru.Text + "','" + tbxCCCD.Text + "','" + DateTime.Parse(dtpNgayCap.Text) + "','" + tbxNoiCap.Text + "','" + tbxNoiSinh.Text + "','" + tbxQuocTich.Text + "','" + txbTonGiao.Text + "','" + DateTime.Parse(dtpDoan.Text) + "','" + DateTime.Parse(dtpDang.Text) + "',N'" + txbHocVan.Text + "',N'" + txbChuyenMon.Text + "','" + txbNgoaiNgu.Text + "',N'" + tbxChucVu.Text + "')";
                    cmd1.ExecuteNonQuery();
                }
                connect.Close();
                MessageBox.Show("Add completed!", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }catch (Exception ex)
            {
                MessageBox.Show("Vui long kiem tra lại thong tin!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
