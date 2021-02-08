using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GiyimMagazaOtomasyon
{
    class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-HJOGOT9F;Initial Catalog=GiyimMagazaOtomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
       
        }
    }
}
