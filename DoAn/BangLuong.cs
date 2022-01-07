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
    public partial class BangLuong : Form
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlConnection connect = new SqlConnection(ConnectSQL.connectString);
        SqlCommand cmd;
        DataTable table = new DataTable();
        public BangLuong()
        {
            InitializeComponent();
        }       
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void loadData()
        {
            connect.Open();
            cmd = connect.CreateCommand();
            cmd.CommandText = @"select distinct NHANVIEN.MaNV , HotenNV, Tenchucvu, HeSoPhuCap As PhuCapChucVu, NghiCP, NghiKP, NghiBHXH,MucluongCB, LuongBD, ThueTNCN, TongCPSH, Tongluong as TổngSố 
                                from LUONG 
                                join NHANVIEN on NHANVIEN.MaNV = LUONG.MaNV 
                                join CHUCVU on CHUCVU.Machucvu = NHANVIEN.Machucvu 
                                join HESOLUONG on HESOLUONG.MaNV = NHANVIEN.MaNV 
                                join THEODOISONGAYNGHI on THEODOISONGAYNGHI.MaNV = NHANVIEN.MaNV 
                                join TINHTIENSINHHOAT on TINHTIENSINHHOAT.MaNV = NHANVIEN.MaNV";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            gvBangLuong.DataSource = table;
            connect.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();                       
        }      
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
        private void gvBangLuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = gvBangLuong.CurrentRow.Index;
            txbMaNV.Text = gvBangLuong.Rows[i].Cells[0].Value.ToString();
            txbLuongBD.Text = gvBangLuong.Rows[i].Cells[8].Value.ToString();            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            connect.Open();
            cmd = connect.CreateCommand();
            cmd.CommandText = @"select distinct NHANVIEN.MaNV , HotenNV, Tenchucvu, HeSoPhuCap As PhuCapChucVu, NghiCP, NghiKP, NghiBHXH,MucluongCB, LuongBD, ThueTNCN, TongCPSH, Tongluong as TổngSố 
                                from LUONG 
                                join NHANVIEN on NHANVIEN.MaNV = LUONG.MaNV 
                                join CHUCVU on CHUCVU.Machucvu = NHANVIEN.Machucvu 
                                join HESOLUONG on HESOLUONG.MaNV = NHANVIEN.MaNV 
                                join THEODOISONGAYNGHI on THEODOISONGAYNGHI.MaNV = NHANVIEN.MaNV 
                                join TINHTIENSINHHOAT on TINHTIENSINHHOAT.MaNV = NHANVIEN.MaNV
                                where NHANVIEN.MaNV='"+txbMaNV.Text+"'";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            gvBangLuong.DataSource = table;
            connect.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txbMaNV.Text == ""|| txbLuongBD.Text == "")
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {                
                connect.Open();
                int i = gvBangLuong.CurrentRow.Index;
                cmd = connect.CreateCommand();
                cmd.CommandText = @"update LUONG set LuongBD = '" + int.Parse(txbLuongBD.Text) + "'" +                            
                            ",Tongluong = '" + int.Parse(gvBangLuong.Rows[i].Cells[11].Value.ToString()) + "'+" + int.Parse(txbLuongBD.Text) + "" +
                            "where MaNV = '" + txbMaNV.Text + "'";
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Cập nhật thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
        }
    }
}
