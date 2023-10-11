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
    public partial class Hasta_Kaydı : Form
    {
        public Hasta_Kaydı()
        {
            InitializeComponent();
        }
        
        SqlBaglanti bgl=new SqlBaglanti();
        
        private void button1_Click(object sender, EventArgs e)
        {
            

            SqlCommand hst = new SqlCommand("insert into Tbl_Hastalar (HastaKimlikNo, HastaAdi, HastaSoyadi, HastaTelefonNo, HastaSifre) values (@p1, @p2, @p3, @p4, @p5)", bgl.Baglan());
            hst.Parameters.AddWithValue("@p1", maskedTextBoxTc.Text);
            hst.Parameters.AddWithValue("@p2", txtAd.Text);
            hst.Parameters.AddWithValue("@p3", txtSoyad.Text);
            hst.Parameters.AddWithValue("@p4", txtTel.Text);
            hst.Parameters.AddWithValue("@p5", maskedTextBoxSifre.Text);

            hst.ExecuteNonQuery();



            bgl.Baglan().Close();
            MessageBox.Show("Personel Eklendi.");
            
        }

        private void Hasta_Kaydı_Load(object sender, EventArgs e)
        {

        }
    }
}
