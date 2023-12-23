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

    public class DersDAL : IDersDAL
    {
        public void Add(Ders Entity)
        {
            throw new NotImplementedException();
        }

        public int AdGet(string isim)
        {

            SqlCommand sqlCommand1 = new SqlCommand("Select DersID from Ders where Ad=@p1", Connection.connection1);
            sqlCommand1.Parameters.AddWithValue("@p1", isim);
            if (sqlCommand1.Connection.State != ConnectionState.Open)
            {
                sqlCommand1.Connection.Open();
            }

            SqlDataReader dr = sqlCommand1.ExecuteReader();

            while (dr.Read())
            {

                return int.Parse(dr["DersID"].ToString());


            }
            dr.Close();
            return 0;
        }

        public void DersAdd(string ad)
        {

            Connection.connection1.Close();
            Connection.connection1.Open();
            SqlCommand sqlCommand2 = new SqlCommand("sp_Ders_Insert @p1", Connection.connection1);
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

        public List<Ders> Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Ders> GetAll()
        {
            throw new NotImplementedException();
        }



        public void Update(int dersId, int dersAD)
        {
            //SqlCommand sqlCommand3 = new SqlCommand("sp_Ders_Update @p1,@p2,@p3,@p4", Connection.connection1);
            //sqlCommand3.Parameters.AddWithValue("@p1", id);
            //sqlCommand3.Parameters.AddWithValue("@p2", Ad);
            //sqlCommand3.Parameters.AddWithValue("@p3", Soyad);
            //sqlCommand3.Parameters.AddWithValue("@p4", Telefon);
            //SqlDataReader dr = sqlCommand3.ExecuteReader();
            //if (sqlCommand3.Connection.State != ConnectionState.Open)
            //{
            //    sqlCommand3.Connection.Open();
            //}
            //sqlCommand3.Connection.Close();
        }
    }
}
