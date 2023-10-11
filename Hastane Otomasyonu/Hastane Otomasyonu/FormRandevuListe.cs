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
    public partial class FormRandevuListe : Form
    {
        public FormRandevuListe()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();

        private void FormRandevuListe_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter ad= new SqlDataAdapter("Select * from Tbl_Randevular", bgl.Baglan());
            ad.Fill(dt);
            dataGridViewListe.DataSource = dt;  

        }
    }
}
