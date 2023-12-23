using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate.Baglanti;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrate
{
    public class OdemeDAL : IOdemeDAL
    {
        public void Add(Odeme odeme)
        {
            throw new NotImplementedException();

        }

        public void Add(int veliid, DateTime odemetrh, int tutar, string odemebilgi)
        {
            Connection.connection1.Close();
            Connection.connection1.Open();
            SqlCommand sqlCommand2 = new SqlCommand("sp_Odeme_Insert @p1,@p2,@p3,@p4", Connection.connection1);
            sqlCommand2.Parameters.AddWithValue("@p1", veliid);
            sqlCommand2.Parameters.AddWithValue("@p2", odemetrh);
            sqlCommand2.Parameters.AddWithValue("@p3", tutar);
            sqlCommand2.Parameters.AddWithValue("@p4", odemebilgi);


            SqlDataReader dr = sqlCommand2.ExecuteReader();
            if (dr.Read())
            {
                Connection.connection1.Close();
            }

            else
            {
                Connection.connection1.Close();
            }
        }

        public List<Odeme> Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Odeme> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(int prdouctId, bool productStatus)
        {
            throw new NotImplementedException();
        }
        public int AdGet(string isim)
        {
            throw new NotImplementedException();
        }
        
    }
}
