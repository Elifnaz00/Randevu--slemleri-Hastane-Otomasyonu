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
    public partial class FormBilgiDüzenle : Form
    {
        public FormBilgiDüzenle()
        {
            InitializeComponent();
        }
        
        public string TCno;
        SqlBaglanti bgl = new SqlBaglanti();

        private void FormBilgiDüzenle_Load(object sender, EventArgs e)
        {
            maskedTextBoxTc.Text = TCno;
            SqlCommand sqlCommand = new SqlCommand("Select * From Tbl_Hastalar Where HastaKimlikNo=@p1", bgl.Baglan());
            sqlCommand.Parameters.AddWithValue("@p1", maskedTextBoxTc.Text);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read()) {
                txtAd.Text= reader[2].ToString();
                txtSoyad.Text= reader[3].ToString();
                maskedTextBoxTel.Text= reader[4].ToString();    
                //txtSifre.Text= reader[5].ToString();


            }
            bgl.Baglan().Close();


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand sql = new SqlCommand("Update Tbl_Hastalar Set HastaAdi=@p1, HastaSoyadi=@p2, HastaTelefonNo=@p3, HastaSifre=@p4 Where HastaKimlikNo= @p5", bgl.Baglan());
            sql.Parameters.AddWithValue("@p1", txtAd.Text);
            sql.Parameters.AddWithValue("@p2", txtSoyad.Text);
            sql.Parameters.AddWithValue("@p3", maskedTextBoxTel.Text);
            sql.Parameters.AddWithValue("@p4", txtSifre.Text);
            sql.Parameters.AddWithValue("@p5", maskedTextBoxTc.Text);
            sql.ExecuteNonQuery();
            bgl.Baglan().Close();
            MessageBox.Show("Değişiklikler Kaydedildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
