using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane_Otomasyonu
{
    public partial class FormDuyurular : Form
    {
        public FormDuyurular()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl= new SqlBaglanti();
        private void FormDuyurular_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sa= new SqlDataAdapter("Select * From Tbl_Duyurular ", bgl.Baglan());
            sa.Fill(dt);
            dataGridViewDuyurular.DataSource = dt;

        }
    }
}
