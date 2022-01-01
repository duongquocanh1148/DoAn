using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class BangTinhTienSH : Form
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlConnection connect = new SqlConnection(ConnectSQL.connectString);
        SqlCommand cmd;
        DataTable table = new DataTable();
        public BangTinhTienSH()
        {
            InitializeComponent();
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
            connect.Open();
            cmd = connect.CreateCommand();
            cmd.CommandText = @"select NHANVIEN.MaNV,NHANVIEN.HotenNV,Dientich*200000 as TienPhong, SoCTD*3500 as TienDien, SoDHN*10000 as TienNuoc,Chiphikhac, TongCPSH
                                from TINHTIENSINHHOAT
                                join NHANVIEN on TINHTIENSINHHOAT.MaNV=NHANVIEN.MaNV";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            gvTTSH.DataSource = table;
            connect.Close();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvTTSH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = gvTTSH.CurrentRow.Index;
        }
    }
}
