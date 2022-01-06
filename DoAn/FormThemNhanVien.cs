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
        SqlCommand cmdNV, cmdCTNV,cmdCT,cmdQTCT;
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

        void Clear()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
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
                if (ckbNu.Checked) gender = 1;
                else if (ckbNam.Checked) gender = 0;
                else if (ckbNu.Checked || ckbNam.Checked) MessageBox.Show("Chỉ chọn 1 giới tính!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else                                  
                    MessageBox.Show("Vui lòng chọn giới tính!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (tbxID.Text == "" || tbxHoTen.Text == "" || txbMaCV.Text == "" || txbMaPhong.Text == "" || tbxBHXH.Text == "" || txbSQD.Text == "")
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    string s = lbSQD.Text + txbSQD.Text;
                    cmdNV = connect.CreateCommand();
                    cmdNV.CommandText = @"INSERT INTO NHANVIEN VALUES ('" + tbxID.Text + "', N'" + tbxHoTen.Text + "', '" + txbMaCV.Text + "', '" + txbMaPhong.Text + "','" + gender + "', '" + DateTime.Parse(dtpNgaySinh.Text) + "', '" + tbxBHXH.Text + "', '" + 0 + "')";
                    cmdNV.ExecuteNonQuery();
                    cmdCT = connect.CreateCommand();
                    cmdCT.CommandText = @"INSERT INTO CONGTAC VALUES ('" + s + "','" + txbMaPhong.Text + "','" + txbMaCV.Text + "','" + tbxID.Text + "','" + DateTime.Parse(DateTime.Now.ToString()) + "','',N'NVM')";
                    cmdCT.ExecuteNonQuery();
                    cmdQTCT = connect.CreateCommand();
                    cmdQTCT.CommandText = @"INSERT INTO QUATRINHCONGTAC VALUES ('" + tbxID.Text + "','" + DateTime.Parse(DateTime.Now.ToString()) + "','" + "" + "',N'" + tbxChucVu.Text + "',N'" + tbxNoiCT.Text + "')";
                    cmdQTCT.ExecuteNonQuery();
                    cmdCTNV = connect.CreateCommand();
                    if (tbxID.Text == "" || tbxNguyenQuan.Text == "" || tbxHKTT.Text == "" || tbxHKTTru.Text == "" || tbxCCCD.Text == "")
                        MessageBox.Show("Vui long điền đầy đủ thông tin!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        cmdCTNV.CommandText = @"Insert into CTNHANVIEN values('" + tbxID.Text + "',N'" + tbxNguyenQuan.Text + "',N'" + tbxHKTT.Text + "','" + tbxHKTTru.Text + "','" + tbxCCCD.Text + "','" + DateTime.Parse(dtpNgayCap.Text) + "','" + tbxNoiCap.Text + "','" + tbxNoiSinh.Text + "','" + tbxQuocTich.Text + "','" + txbTonGiao.Text + "','" + DateTime.Parse(dtpDoan.Text) + "','" + DateTime.Parse(dtpDang.Text) + "',N'" + txbHocVan.Text + "',N'" + txbChuyenMon.Text + "','" + txbNgoaiNgu.Text + "',N'" + tbxChucVu.Text + "')";
                        cmdCTNV.ExecuteNonQuery();
                    }
                    MessageBox.Show("Add completed!", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                
            }catch (Exception ex)
            {            
                MessageBox.Show("Vui long kiểm tra lại thông tin!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connect.Close();
        }

        
    }
}
