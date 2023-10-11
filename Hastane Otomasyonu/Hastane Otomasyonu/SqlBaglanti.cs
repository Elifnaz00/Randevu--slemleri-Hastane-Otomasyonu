using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hastane_Otomasyonu
{
    internal class SqlBaglanti
    {
        public SqlConnection Baglan() {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-IDVTKKC\\SQLEXPRESS;Initial Catalog=HastaneVeriTabanı;Integrated Security=True");
            baglanti.Open();
            return baglanti;
        
        }
    }
}
