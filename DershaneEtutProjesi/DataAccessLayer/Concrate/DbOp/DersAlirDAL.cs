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

    public class DersAlirDAL : IDersAlirDAL
    {
        public void Add(DersAlir Entity)
        {
            throw new NotImplementedException();
        }

        public void Add(int dersId, int sinifId, DateTime trh)
        {
            Connection.connection1.Close();
            Connection.connection1.Open();
            SqlCommand sqlCommand = new SqlCommand("sp_DersAlir_Insert @p1,@p2,@p3", Connection.connection1);
            sqlCommand.Parameters.AddWithValue("@p1", dersId);
            sqlCommand.Parameters.AddWithValue("@p2", sinifId);
            sqlCommand.Parameters.AddWithValue("@p3", trh);


            SqlDataReader dr = sqlCommand.ExecuteReader();
            if (dr.Read())
            {
                Connection.connection1.Close();
            }

            else
            {
                Connection.connection1.Close();
            }
        }

        public int AdGet(string isim)
        {
            throw new NotImplementedException();
        }

        public void DenemeAdd(string ad)
        {
            throw new NotImplementedException();
        }

        public List<Deneme> DenemeAdGet(string isim)
        {
            throw new NotImplementedException();
        }

        public List<Deneme> DenemeleriGetirme()
        {
            throw new NotImplementedException();
        }

        public void DenemeSilme(string Adi)
        {
            throw new NotImplementedException();
        }

        public List<DersAlir> Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<DersAlir> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(int prdouctId, bool productStatus)
        {
            throw new NotImplementedException();
        }
    }
}
