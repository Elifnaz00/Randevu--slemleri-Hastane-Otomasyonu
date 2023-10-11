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
    public partial class FormSekreterGiris : Form
    {
        public FormSekreterGiris()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();
        private void FormSekreterGiris_Load(object sender, EventArgs e)
        {
           

        }

        private void btnSekreterGiris_Click(object sender, EventArgs e)
        {
            FormSekreterEkranı skrt = new FormSekreterEkranı();
            skrt.ShowDialog();  
            this.Hide();
        }
    }
}
