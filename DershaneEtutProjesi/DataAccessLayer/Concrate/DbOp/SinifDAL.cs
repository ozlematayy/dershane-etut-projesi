using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate.Baglanti;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrate
{

    public class SinifDAL : ISinifDAL
    {
        public void Add(Sinif Entity)
        {
            throw new NotImplementedException();
        }

        public int AdGet(string isim)
        {
            throw new NotImplementedException();
        }

        public static List<Sinif> sinif3 = new List<Sinif>();
        public List<Sinif> Get(int id)
        {
            SqlCommand sqlCommand3 = new SqlCommand("sp_Sinif_IDGet @p1", Connection.connection1);
            sqlCommand3.Parameters.AddWithValue("@p1", id);
            if (sqlCommand3.Connection.State != ConnectionState.Open)
            {
                sqlCommand3.Connection.Open();
            }
            SqlDataReader dr = sqlCommand3.ExecuteReader();
            while (dr.Read())
            {
                Sinif sinif1 = new Sinif();
                sinif1.SinifID1 = dr.GetInt32(0);
                sinif1.Sinif1 = dr.GetString(1);
                sinif3.Add(sinif1);
            }
            dr.Close();
            return sinif3;
        }

        public List<Sinif> GetAll()
        {
            throw new NotImplementedException();
        }

        public void SinifEkle(string sinif)
        {
            Connection.connection1.Close();
            Connection.connection1.Open();
            SqlCommand sqlCommand = new SqlCommand("sp_Sinif_Insert @p1", Connection.connection1);
            sqlCommand.Parameters.AddWithValue("@p1", sinif);

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
        public static List<Sinif> sinif2 = new List<Sinif>();
        public List<Sinif> SinifGet(string sinif)
        {

            SqlCommand sqlCommand3 = new SqlCommand("sp_Sinif_Get @p1", Connection.connection1);
            sqlCommand3.Parameters.AddWithValue("@p1", sinif);
            if (sqlCommand3.Connection.State != ConnectionState.Open)
            {
                sqlCommand3.Connection.Open();
            }
            SqlDataReader dr = sqlCommand3.ExecuteReader();
            while (dr.Read())
            {
                Sinif sinif1 = new Sinif();
                sinif1.SinifID1 = dr.GetInt32(0);
                sinif1.Sinif1 = dr.GetString(1);
                sinif2.Add(sinif1);
            }
            dr.Close();
            return sinif2;
        }

        public bool Update(int prdouctId, bool productStatus)
        {
            throw new NotImplementedException();
        }
    }
}
