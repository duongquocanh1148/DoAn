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
    public partial class DKNTT : Form
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlConnection connect = new SqlConnection(ConnectSQL.connectString);
        SqlCommand cmd;
        DataTable table = new DataTable();

        DataTable table2 = new DataTable();            
        

        public DKNTT()
        {
            InitializeComponent();
            
        }
        

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            gvTemp.Hide();
        }        
        

        void loadData()
        {
            
            if (txbID.Text == "") MessageBox.Show("Vui long nhap ma nhan vien", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                connect.Open();
                cmd = connect.CreateCommand();
                cmd.CommandText = @"select distinct HotenNV, Tenphong,Tenchucvu
                                from NHANVIEN
                                join PHONG on  PHONG.Maphong= NHANVIEN.Maphong 
                                join CHUCVU on CHUCVU.Machucvu = NHANVIEN.Machucvu
                                where NHANVIEN.MaNV = '" + txbID.Text + "'";
                adapter.SelectCommand = cmd;
                table.Clear();
                adapter.Fill(table);
                gvTemp.DataSource = table;
                int i = gvTemp.CurrentRow.Index;
                txbFullName.Text = gvTemp.Rows[i].Cells[0].Value.ToString();
                txbNoiCongTac.Text = gvTemp.Rows[i].Cells[1].Value.ToString();
                txbChucVu.Text = gvTemp.Rows[i].Cells[2].Value.ToString();               
                loadDataTN();
            }
        }
        void DangKyNTT()
        {

            
            try
            {
                connect.Open();
                int i = gvTN.RowCount;
                cmd = connect.CreateCommand();

                cmd.CommandText = @"insert into DANGKYNHATT values ('" + s + "' , '" + txbID.Text + "' , '" + txbPhongNhaTT.Text + "' , " + int.Parse(txbDienTich.Text) + " , " + i + ")";
                if (txbDienTich.Text != null || txbPhongNhaTT.Text != null)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Register Completed", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sdk++;
                }
                connect.Close();
            } catch (Exception ex)
            {
                MessageBox.Show("Vui long dien day du thong tin", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void ThanNhan()
        {
            connect.Open();
            if (txbID.Text == "") MessageBox.Show("Vui long nhap ma nhan vien", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                cmd = connect.CreateCommand();
                cmd.CommandText = @"INSERT INTO THANNHAN VALUES (N'" + txbHoTenTN.Text + "', N'" + txbQuanHe.Text + "', '" + txbNamSinh.Text + "', N'" + txbNgheNghiep.Text + "',N'" + txbNCTTN.Text + "', '" + txbID.Text + "')";
                cmd.ExecuteNonQuery();
                loadDataTN();
                MessageBox.Show("Add Completed", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connect.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadData();
        }
        void loadDataTN()
        {
            
            cmd = connect.CreateCommand();
            cmd.CommandText = @"select TenTN,QuanHe,NamSinh,NgheNghiep,NoiCongTacTN from THANNHAN
                                where MaNV ='"+txbID.Text+"'";
            adapter.SelectCommand = cmd;
            table2.Clear();
            adapter.Fill(table2);
            gvTN.DataSource = table2;  
        }       
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string s = lbSDK.Text + txbSDK.Text;
            //try
            //{
            connect.Open();
            int i = gvTN.RowCount;
            cmd = connect.CreateCommand();
            if (txbDienTich.Text == "" || txbPhongNhaTT.Text == "") 
                MessageBox.Show("Vui long dien day du thong tin", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Error);                          
            else
            {
                cmd.CommandText = @"insert into DANGKYNHATT values ('" + s + "' , '" + txbID.Text + "' , '" + txbPhongNhaTT.Text + "' , " + int.Parse(txbDienTich.Text) + " , " + i + ")";
                if (i > 3) MessageBox.Show("Chi dang ky toi da 3 nguoi!", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Register Completed", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);                                             
                }
            }
            connect.Close();                       
            //} catch (Exception ex)
            //{
            //    MessageBox.Show("Vui long dien day du thong tin", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }               

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ThanNhan();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txbHoTenTN.Text == "") MessageBox.Show("Vui long chon than nhan can xoa!", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                connect.Open();
                cmd = connect.CreateCommand();
                cmd.CommandText = @"delete from THANNHAN
                                where TenTN like N'" + txbHoTenTN.Text + "'";
                cmd.ExecuteNonQuery();
                loadDataTN();
                MessageBox.Show("Delete Completed", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connect.Close();
            } 
                        
        }

        private void gvTN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int j = gvTN.CurrentRow.Index;
            txbHoTenTN.Text = gvTN.Rows[j].Cells[0].Value.ToString();
            txbQuanHe.Text = gvTN.Rows[j].Cells[1].Value.ToString();
            txbNamSinh.Text = gvTN.Rows[j].Cells[2].Value.ToString();
            txbNgheNghiep.Text = gvTN.Rows[j].Cells[3].Value.ToString();
            txbNCTTN.Text = gvTN.Rows[j].Cells[4].Value.ToString();
        }
    }
}
