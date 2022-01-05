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
   
    public partial class ViTriCongTac : Form
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlConnection connect = new SqlConnection(ConnectSQL.connectString);
        SqlCommand cmd;
        DataTable table = new DataTable();
        public ViTriCongTac()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void gvViTriCongTac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = gvViTriCongTac.CurrentRow.Index;
        }

        
    }
}
