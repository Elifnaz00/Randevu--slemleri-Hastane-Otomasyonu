using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hastane_Otomasyonu
{
    public partial class Hasta_Giris_Ekranı : Form
    {
        public Hasta_Giris_Ekranı()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        public string tc;

         void CmbDoldur()
        {
            SqlCommand brans = new SqlCommand("Select BransAD From Tbl_Branslar ", bgl.Baglan());
            SqlDataReader rd = brans.ExecuteReader();

            while (rd.Read())
            {
                comboBoxKlinik.Items.Add(rd[0].ToString());
            }
            bgl.Baglan().Close();

        }


        private void Hasta_Giris_Ekranı_Load(object sender, EventArgs e)
        {
           
            lblTc.Text = tc;
            CmbDoldur();

            SqlCommand lbl = new SqlCommand("Select HastaAdi, HastaSoyadi From Tbl_Hastalar Where HastaKimlikNo=@p1", bgl.Baglan());
            lbl.Parameters.AddWithValue("@p1" , lblTc.Text);
            SqlDataReader read = lbl.ExecuteReader();

            while (read.Read())
            {
                lblAdSoyad.Text = read[0] + " " + read[1];
            }

            bgl.Baglan().Close();
            
            DataTable dt = new DataTable();
            SqlDataAdapter da= new SqlDataAdapter("Select * From Tbl_Randevular Where HastaTc= " + tc, bgl.Baglan());
            da.Fill(dt);
            dataGridViewGecmisRandevular.DataSource = dt;
        }

       
        private void comboBoxKlinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDoktor.Items.Clear();
            SqlCommand co = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktor Where DoktorBrans = @p1", bgl.Baglan());
            co.Parameters.AddWithValue("@p1", comboBoxKlinik.Text);
            SqlDataReader reader = co.ExecuteReader();
            while (reader.Read())
            {
                comboBoxDoktor.Items.Add(reader[0] + " "+ reader[1]);

                bgl.Baglan().Close();
            }

        }

        private void comboBoxDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp= new SqlDataAdapter("Select * From Tbl_Randevular Where RandevuBrans='"+ comboBoxKlinik.Text + "'"+ " and RandevuDoktor='" + comboBoxDoktor.Text + "' and RandevuDurum=0", bgl.Baglan());
            adp.Fill(dt);
            dataGridViewAktifRandevular.DataSource = dt;

        }

        private void linkLabelBilgiDüzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormBilgiDüzenle dzn= new FormBilgiDüzenle();
            dzn.TCno = lblTc.Text;

            dzn.Show();
        }

        private void dataGridViewAktifRandevular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen= dataGridViewAktifRandevular.SelectedCells[0].RowIndex;
            textİd.Text = dataGridViewAktifRandevular.Rows[secilen].Cells[0].Value.ToString();
            
        }

        private void btnRandevuOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update Tbl_Randevular Set RandevuDurum=1, HastaTC=@p1, HastaSikayet=@p2 where Randevuid=@p3 ", bgl.Baglan());

            command.Parameters.AddWithValue("@p1", lblTc.Text);
            command.Parameters.AddWithValue("@p2", richTextBoxSikayet.Text);
            command.Parameters.AddWithValue("@p3", textİd.Text);
            

            command.ExecuteNonQuery();
            bgl.Baglan().Close();
            MessageBox.Show("Randevu Oluşturuldu.");
        }
    }
}
