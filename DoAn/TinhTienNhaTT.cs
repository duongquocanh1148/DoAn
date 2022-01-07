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
    public partial class TinhTienNhaTT : Form
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlConnection connect = new SqlConnection(ConnectSQL.connectString);
        SqlCommand cmd;
        DataTable table = new DataTable();
        public TinhTienNhaTT()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TinhTienNhaTT_Load(object sender, EventArgs e)
        {
            txbMaNV.ReadOnly = true;
            loadData();
        }
        void loadData()
        {
            connect.Open();
            cmd = connect.CreateCommand();
            cmd.CommandText = @"select MaNV,Dientich,SoCTD,SoDHN,Chiphikhac,TongCPSH from TINHTIENSINHHOAT";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            gvDSNhaTT.DataSource = table;
            connect.Close();
        }

        private void gvDSNhaTT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = gvDSNhaTT.CurrentRow.Index;
            txbMaNV.Text = gvDSNhaTT.Rows[i].Cells[0].Value.ToString();
            txbSoDien.Text = gvDSNhaTT.Rows[i].Cells[2].Value.ToString();
            txbSoNuoc.Text = gvDSNhaTT.Rows[i].Cells[3].Value.ToString();
            txbChiphikhac.Text = gvDSNhaTT.Rows[i].Cells[4].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txbMaNV.Text == "")
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                connect.Open();
                int i = gvDSNhaTT.CurrentRow.Index;
                float S = float.Parse(gvDSNhaTT.Rows[i].Cells[1].Value.ToString());
                cmd = connect.CreateCommand();
                cmd.CommandText = @"update TINHTIENSINHHOAT set SoCTD = " + float.Parse(txbSoDien.Text) + "" +
                    ",SoDHN = " + float.Parse(txbSoNuoc.Text) + "" +
                    ",Chiphikhac = " + float.Parse(txbChiphikhac.Text) + "" +
                    ",TongCPSH = " + S + "*100000+" + float.Parse(txbSoDien.Text) + "*3500+" + float.Parse(txbSoNuoc.Text) + "*100000+" + float.Parse(txbChiphikhac.Text) + "" +
                    "where MaNV = '" + txbMaNV.Text + "'";
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Cập nhật thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
                Clear();
            }

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
    }
}
