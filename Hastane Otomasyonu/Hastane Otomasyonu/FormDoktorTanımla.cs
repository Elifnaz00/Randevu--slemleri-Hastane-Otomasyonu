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
    public partial class FormDoktorTanımla : Form
    {
        public FormDoktorTanımla()
        {
            InitializeComponent();
        }
        
        SqlBaglanti bgl= new SqlBaglanti();

        void CmbDoldur()
        {
            SqlCommand brans = new SqlCommand("Select BransAD From Tbl_Branslar ", bgl.Baglan());
            SqlDataReader rd = brans.ExecuteReader();

            while (rd.Read())
            {
                cmbBrans.Items.Add(rd[0].ToString());
            }
            bgl.Baglan().Close();

        }

        private void FormDoktorTanımla_Load(object sender, EventArgs e)
        {
            CmbDoldur();
            DataTable dt = new DataTable();
            SqlDataAdapter sa = new SqlDataAdapter("Select * From Tbl_Doktor ", bgl.Baglan());
            sa.Fill(dt);
            dataGridViewDoktorlar.DataSource = dt;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Doktor (DoktorAd, DoktorSoyad, DoktorBrans, DoktorTc, DoktorSifre) values (@p1, @p2, @p3, @p4, @p5)", bgl.Baglan());
            komut.Parameters.AddWithValue("@p1", txtAd.Text );
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text );
            komut.Parameters.AddWithValue("@p3", cmbBrans.Text);
            komut.Parameters.AddWithValue("@p4", maskedTextBoxTc.Text);
            komut.Parameters.AddWithValue("@p5", maskedTextBoxSifre.Text);
            komut.ExecuteNonQuery();
            bgl.Baglan().Close();
            MessageBox.Show("Doktor Eklendi."); 

        }

        private void dataGridViewDoktorlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen= dataGridViewDoktorlar.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridViewDoktorlar.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridViewDoktorlar.Rows[secilen].Cells[2].Value.ToString();
            cmbBrans.Text = dataGridViewDoktorlar.Rows[secilen].Cells[3].Value.ToString();
            maskedTextBoxTc.Text = dataGridViewDoktorlar.Rows[secilen].Cells[4].Value.ToString();
            maskedTextBoxSifre.Text = dataGridViewDoktorlar.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand sql= new SqlCommand("Delete From Tbl_Doktor where DoktorTC=@p1 ", bgl.Baglan());
            sql.Parameters.AddWithValue("@p1", maskedTextBoxTc.Text);
            sql.ExecuteNonQuery();
            bgl.Baglan().Close();
            MessageBox.Show("Kayıt Silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand sql1 = new SqlCommand("Update Tbl_Doktor Set DoktorAd=@p1, DoktorSoyad=@p2, DoktorBrans=@p3, DoktorSifre=@p5 Where  DoktorTc=@p4 ", bgl.Baglan());
            sql1.Parameters.AddWithValue("@p1", txtAd.Text);
            sql1.Parameters.AddWithValue("@p2", txtSoyad.Text);
            sql1.Parameters.AddWithValue("@p3", cmbBrans.Text);
            sql1.Parameters.AddWithValue("@p4", maskedTextBoxTc.Text);
            sql1.Parameters.AddWithValue("@p5", maskedTextBoxSifre.Text);
            sql1.ExecuteNonQuery(); 
            bgl.Baglan().Close();
            MessageBox.Show("Kayıt Güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);



        }
    }
}
