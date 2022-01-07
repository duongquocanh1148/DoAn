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
    public partial class TinhTienSH : Form
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlConnection connect = new SqlConnection(ConnectSQL.connectString);
        SqlCommand cmd;
        DataTable table = new DataTable();
        public TinhTienSH()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void loadData()
        {
            connect.Open();
            cmd = connect.CreateCommand();
            cmd.CommandText = @"select MaNV,Dientich,SoCTD,SoDHN,Chiphikhac,TongCPSH from TINHTIENSINHHOAT";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            gvTTSH.DataSource = table;
            connect.Close();
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

        private void TinhTienSH_Load(object sender, EventArgs e)
        {
            txbMaNV.ReadOnly = true;
            loadData();
        }

        private void gvTTSH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = gvTTSH.CurrentRow.Index;
            txbMaNV.Text = gvTTSH.Rows[i].Cells[0].Value.ToString();
            txbSoDien.Text = gvTTSH.Rows[i].Cells[2].Value.ToString();
            txbSoNuoc.Text = gvTTSH.Rows[i].Cells[3].Value.ToString();
            txbChiphikhac.Text = gvTTSH.Rows[i].Cells[4].Value.ToString();           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txbMaNV.Text == "")
                MessageBox.Show("Vui lòng nhập mã nhân viên!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            connect.Open();
            cmd = connect.CreateCommand();
            cmd.CommandText = @"update TINHTIENSINHHOAT set soCTD = "+int.Parse(txbSoDien.Text)+"" +
                ",SoDHN = "+ int.Parse(txbSoNuoc.Text)+"" +
                ",Chiphikhac="+ int.Parse(txbChiphikhac.Text)+"" +
                ",TongCPSH = Dientich*200000+"+ int.Parse(txbSoDien.Text) + "*3500+"+ int.Parse(txbSoNuoc.Text) + "*10000+"+ int.Parse(txbChiphikhac.Text)+"" +
                "where MaNV = '" + txbMaNV.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cập nhật thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connect.Close();
            Clear();
            loadData();
        }
    }
}
