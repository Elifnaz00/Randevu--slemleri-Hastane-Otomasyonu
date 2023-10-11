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
using System.Data.SqlClient;

namespace Hastane_Otomasyonu
{
    public partial class DoktorGiris : Form
    {
        public DoktorGiris()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl= new SqlBaglanti();
        public string TC;

        private void DoktorGiris_Load(object sender, EventArgs e)
        {
            LblTc.Text = TC;

            SqlCommand cmd = new SqlCommand("Select DoktorAd, DoktorSoyad From Tbl_Doktor Where DoktorTc=@p1", bgl.Baglan());
            cmd.Parameters.AddWithValue("@p1", LblTc.Text);
            SqlDataReader dr = cmd.ExecuteReader(); 
            while (dr.Read()) {
                LblAdSoyad.Text = dr[0] + " " + dr[1];


            }
            bgl.Baglan().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular Where RandevuDoktor='"+LblAdSoyad.Text+ "'",bgl.Baglan());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
