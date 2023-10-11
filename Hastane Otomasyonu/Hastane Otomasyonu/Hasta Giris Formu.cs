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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Hastane_Otomasyonu
{
    public partial class Hasta_Giris_Formu : Form
    {
        public Hasta_Giris_Formu()
        {
            InitializeComponent();
        }


        SqlBaglanti bgl = new SqlBaglanti();


        private void btn_HastaGirisi_Click(object sender, EventArgs e)
        {
            
            

            SqlCommand cmd = new SqlCommand("Select * From Tbl_Hastalar WHERE HastaKimlikNo = @p1 AND HastaSifre = @p2", bgl.Baglan() );

            cmd.Parameters.AddWithValue("@p1", maskedtextboxTc.Text);
            cmd.Parameters.AddWithValue("@p2", maskedTextBoxSifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();

            if(dr.Read())
            {
                Hasta_Giris_Ekranı giris = new Hasta_Giris_Ekranı();
                giris.tc = maskedtextboxTc.Text;
                giris.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Hatalı Kimlik ya da Şifre girdiniz.");
            }


            

        }

     
    }
}
