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
    public partial class FormBranşTanımla : Form
    {
        public FormBranşTanımla()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();

       

        private void FormBranşTanımla_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sa = new SqlDataAdapter("Select * From Tbl_Branslar ", bgl.Baglan());
            sa.Fill(dt);
            dataGridViewBranslar.DataSource = dt;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Branslar (BransAD) values (@p1)", bgl.Baglan());
            komut.Parameters.AddWithValue("@p1", txtBrans.Text);
           
            
            komut.ExecuteNonQuery();
            bgl.Baglan().Close();
            MessageBox.Show("Branş Eklendi.");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand sql1 = new SqlCommand("Update Tbl_Branslar Set BransAD=@p1 Where  Bransİd=@p2 ", bgl.Baglan());
            sql1.Parameters.AddWithValue("@p1", txtBrans.Text);
            sql1.Parameters.AddWithValue("@p2", txtİd.Text);

            sql1.ExecuteNonQuery();
            bgl.Baglan().Close();
            MessageBox.Show("Branş Güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void dataGridViewBranslar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen= dataGridViewBranslar.SelectedCells[0].RowIndex;
            txtİd.Text = dataGridViewBranslar.Rows[secilen].Cells[0].Value.ToString();
            txtBrans.Text = dataGridViewBranslar.Rows[secilen].Cells[1].Value.ToString();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand sql = new SqlCommand("Delete From Tbl_Branslar where Bransid=@p1 ", bgl.Baglan());
            sql.Parameters.AddWithValue("@p1", txtİd.Text);
            sql.ExecuteNonQuery();
            bgl.Baglan().Close();
            MessageBox.Show("Branş Silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
