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
    public partial class FormDoktorGiris : Form
    {
        public FormDoktorGiris()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl= new SqlBaglanti();

        private void btn_HastaGirisi_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktor Where DoktorTc=@p1 and DoktorSifre=@p2", bgl.Baglan());
            komut.Parameters.AddWithValue("@p1", maskedtextboxTc.Text);
            komut.Parameters.AddWithValue("@p2", maskedTextBoxSifre.Text);
            SqlDataReader reader = komut.ExecuteReader();

            if (reader.Read())
            {
                DoktorGiris dktr = new DoktorGiris();
                dktr.TC=maskedtextboxTc.Text;
                
                dktr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }

        }

      
    }
}
