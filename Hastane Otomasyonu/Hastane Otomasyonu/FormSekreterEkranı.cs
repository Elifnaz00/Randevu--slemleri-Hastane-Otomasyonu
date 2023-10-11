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
    public partial class FormSekreterEkranı : Form
    {
        public FormSekreterEkranı()
        {
            InitializeComponent();
        }
        public string TCnumara;
        SqlBaglanti bgl = new SqlBaglanti();





        private void FormSekreterEkranı_Load(object sender, EventArgs e)
        {
            lblTc.Text = TCnumara;

            SqlCommand komut = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreter Where SekreterTC=@p1", bgl.Baglan());
            komut.Parameters.AddWithValue("@p1", lblTc.Text);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                lblAdSoyad.Text = reader[0].ToString();
            }
            bgl.Baglan().Close();


            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter("Select * From Tbl_Branslar", bgl.Baglan());
            ad.Fill(dt);
            dataGridViewBranslar.DataSource = dt;

            DataTable dta = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("Select (DoktorAd + ' ' + DoktorSoyad) as 'Doktorlar' , DoktorBrans From Tbl_Doktor", bgl.Baglan());
            adp.Fill(dta);
            dataGridViewDoktorlar.DataSource = dta;

            bgl.Baglan().Close();

            SqlCommand brans = new SqlCommand("Select BransAD From Tbl_Branslar ", bgl.Baglan());
            SqlDataReader rd = brans.ExecuteReader();

            while (rd.Read())
            {
                cmbboxKlinik.Items.Add(rd[0].ToString());
            }
            bgl.Baglan().Close();







        }

        private void btnRandevuOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Tbl_Randevular (RandevuTarih, RandevuSaat, RandevuBrans, RandevuDoktor) values (@p1, @p2, @p3, @p4)", bgl.Baglan());

            command.Parameters.AddWithValue("@p1", maskedTextBoxTarih.Text);
            command.Parameters.AddWithValue("@p2", maskedTextBoxSaat.Text);
            command.Parameters.AddWithValue("@p3", cmbboxKlinik.Text);
            command.Parameters.AddWithValue("@p4", cmbboxDoktor.Text);

            command.ExecuteNonQuery();
            bgl.Baglan().Close();
            MessageBox.Show("Randevu Oluşturuldu.");
        }

        private void cmbboxDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbboxKlinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbboxDoktor.Items.Clear();
            SqlCommand co = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktor Where DoktorBrans = @p1", bgl.Baglan());
            co.Parameters.AddWithValue("@p1", cmbboxKlinik.Text);
            SqlDataReader reader = co.ExecuteReader();
            while (reader.Read())
            {
                cmbboxDoktor.Items.Add(reader[0] + " " + reader[1]);

                bgl.Baglan().Close();
            }
        }

        private void btnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand command1 = new SqlCommand("insert into Tbl_Duyurular (Duyuru) values (@p1)", bgl.Baglan());

            command1.Parameters.AddWithValue("@p1", richtxtDuyuru.Text);



            command1.ExecuteNonQuery();
            bgl.Baglan().Close();
            MessageBox.Show("Duyuru Oluşturuldu.");
        }

        private void btnOluştur_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("insert into Tbl_Duyurular (Duyuru) values (@p1) ", bgl.Baglan());
            sqlCommand.Parameters.AddWithValue("@p1", richtxtDuyuru1.Text);
            bgl.Baglan().Close();
            MessageBox.Show("Duyuru başarıyla eklendi.");

        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            FormDuyurular frm = new FormDuyurular();
            frm.Show();
        }

        private void btnDoktorPaneli_Click(object sender, EventArgs e)
        {
            FormDoktorTanımla dktr = new FormDoktorTanımla();
            dktr.Show();
        }

        private void btnKlinikPaneli_Click(object sender, EventArgs e)
        {
            FormBranşTanımla brn = new FormBranşTanımla();
            brn.Show();
        }

        private void btnRandevuListe_Click(object sender, EventArgs e)
        {
            FormRandevuListe rnd = new FormRandevuListe();
            rnd.Show();
        }
    }
}
