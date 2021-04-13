using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Öğrenci_Not_Kayıt
{
    class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-33L0BFJ\SQLEXPRESS;Initial Catalog=OgrenciNotKayıtDb;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
