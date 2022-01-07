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
    public partial class TinhLuong : Form
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlConnection connect = new SqlConnection(ConnectSQL.connectString);
        SqlCommand cmd;
        DataTable table = new DataTable();
        public TinhLuong()
        {
            InitializeComponent();
        }

        private void TinhLuong_Load(object sender, EventArgs e)
        {
            loadData();
        }
        void loadData()
        {
            connect.Open();
            cmd = connect.CreateCommand();
            cmd.CommandText = @"select LUONG.MaNV,ThueTNCN,MucluongCB,LuongBD,LiDo,Tongluong as ChuaTruCPSH from LUONG
                                join HESOLUONG on HESOLUONG.MaNV = LUONG.MaNV";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            gvBangLuong.DataSource = table;
            connect.Close();
        }

        private void gvBangLuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = gvBangLuong.CurrentRow.Index;
            txbMaNV.Text = gvBangLuong.Rows[i].Cells[0].Value.ToString();            
            txbLuongBD.Text = gvBangLuong.Rows[i].Cells[3].Value.ToString();
            txbLydo.Text = gvBangLuong.Rows[i].Cells[4].Value.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
        }
        
    }
}
