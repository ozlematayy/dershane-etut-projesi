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

    public class DenemeDAL : IDenemeDAL
    {
        public void Add(Deneme Entity)
        {
            throw new NotImplementedException();
        }

        public void restore()
        {
            SqlCommand sqlCommand1 = new SqlCommand("Select DenemeID from Deneme where Ad=@p1", Connection.connection1);
        }
        public static List<Deneme> degerler = new List<Deneme>();
        public List<Deneme> DenemeleriGetirme()
        {

            SqlCommand sqlCommand1 = new SqlCommand("Select * from Deneme", Connection.connection1);
            if (sqlCommand1.Connection.State != ConnectionState.Open)
            {
                sqlCommand1.Connection.Open();
            }
            SqlDataReader dr = sqlCommand1.ExecuteReader();
            while (dr.Read())
            {
                Entity.Concrate.Deneme ent = new Entity.Concrate.Deneme();
                ent.Ad1 = dr["Ad"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;

        }
        public void DenemeSilme(string Adi)
        {
            Connection.connection1.Close();
            Connection.connection1.Open();
            SqlCommand dltkmt = new SqlCommand("sp_Deneme_Delete @Adi", Connection.connection1);

            if (dltkmt.Connection.State != ConnectionState.Open)
            {
                dltkmt.Connection.Open();
            }
            dltkmt.Parameters.AddWithValue("Ad", Adi);
            dltkmt.ExecuteNonQuery();
            Connection.connection1.Close();

        }

        public int AdGet(string isim)
        {
            SqlCommand sqlCommand1 = new SqlCommand("Select DenemeID from Deneme where Ad=@p1", Connection.connection1);
            sqlCommand1.Parameters.AddWithValue("@p1", isim);
            if (sqlCommand1.Connection.State != ConnectionState.Open)
            {
                sqlCommand1.Connection.Open();
            }

            SqlDataReader dr = sqlCommand1.ExecuteReader();

            while (dr.Read())
            {

                return int.Parse(dr["DenemeID"].ToString());


            }
            dr.Close();
            return 0;
        }

        public void DenemeAdd(string ad)
        {

            Connection.connection1.Close();
            Connection.connection1.Open();
            SqlCommand sqlCommand2 = new SqlCommand("sp_Deneme_Insert @p1", Connection.connection1);
            sqlCommand2.Parameters.AddWithValue("@p1", ad);


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

        public List<Deneme> Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Deneme> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(int prdouctId, bool productStatus)
        {
            throw new NotImplementedException();
        }
        public static List<Deneme> deneme1 = new List<Deneme>();
        public List<Deneme> DenemeAdGet(string isim)
        {
            SqlCommand sqlCommand3 = new SqlCommand("Select * from Deneme where Ad=@p1", Connection.connection1);
            sqlCommand3.Parameters.AddWithValue("@p1", isim);
            if (sqlCommand3.Connection.State != ConnectionState.Open)
            {
                sqlCommand3.Connection.Open();
            }
            SqlDataReader dr = sqlCommand3.ExecuteReader();
            while (dr.Read())
            {
                Deneme deneme = new Deneme();
                deneme.DenemeID1 = dr.GetInt32(0);
                deneme.Ad1 = dr.GetString(1);

                deneme1.Add(deneme);
            }
            dr.Close();
            return deneme1;
        }
    }
}
