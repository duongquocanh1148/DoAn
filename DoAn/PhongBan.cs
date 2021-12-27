﻿using System;
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
    public partial class PhongBan : Form
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlConnection connect = new SqlConnection(ConnectSQL.connectString);
        SqlCommand cmd;
        DataTable table = new DataTable();
        public PhongBan()
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
            cmd.CommandText = "select * from PHONG";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            gvPhongBan.DataSource = table;
            connect.Close();
        }


        private void gvPhongBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = gvPhongBan.CurrentRow.Index;
            txbIDRoom.Text = gvPhongBan.Rows[i].Cells[0].Value.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txbIDRoom.Text == "") MessageBox.Show("Vui long nhap ma phong!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                connect.Open();
                cmd = connect.CreateCommand();
                cmd.CommandText = "select * from PHONG where MaPhong = '" + txbIDRoom.Text + "'";
                adapter.SelectCommand = cmd;
                table.Clear();
                adapter.Fill(table);
                gvPhongBan.DataSource = table;
                connect.Close();
            }
        }
    }
}
