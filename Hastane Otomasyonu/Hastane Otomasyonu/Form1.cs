using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyonu
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSekreterGiris formSekreterGiris = new FormSekreterGiris();
            formSekreterGiris.Show();
            this.Hide();
                
        }

        private void btn_HastaKaydi_Click(object sender, EventArgs e)
        {
            Hasta_Kaydı hst = new Hasta_Kaydı();
            hst.Show();
            
        }

        private void btn_HastaGirisi_Click(object sender, EventArgs e)
        {
            Hasta_Giris_Formu frmgiris = new Hasta_Giris_Formu();
            frmgiris.Show();
            this.Hide();
        }

        private void btn_DoktorGirisi_Click(object sender, EventArgs e)
        {
            FormDoktorGiris grs= new FormDoktorGiris();
            grs.Show();
            this.Hide();
        }

		private void FormGiris_Load(object sender, EventArgs e)
		{

		}
	}
}
