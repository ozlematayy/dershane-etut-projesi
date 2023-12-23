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
    public class VeliDAL : IVeliDAL
    {
        public void VeliAdd(string ad, string soyad, string tel)
        {
            Connection.connection1.Close();
            Connection.connection1.Open();
            SqlCommand sqlCommand2 = new SqlCommand("sp_Veli_Insert @p1,@p2,@p3", Connection.connection1);
            sqlCommand2.Parameters.AddWithValue("@p1", ad);
            sqlCommand2.Parameters.AddWithValue("@p2", soyad);
            sqlCommand2.Parameters.AddWithValue("@p3", tel);

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
        public void Add(Veli veli)
        {
            throw new NotImplementedException();


        }

        public static List<Veli> veli1 = new List<Veli>();

        public List<Veli> GetAll()
        {

            SqlCommand sqlCommand1 = new SqlCommand("Sp_Veli_Get", Connection.connection1);
            //var command = new SqlCommand("sp_DayBooks_Get @Id", connection);

            if (sqlCommand1.Connection.State != ConnectionState.Open)
            {
                sqlCommand1.Connection.Open();
            }
            SqlDataReader dr = sqlCommand1.ExecuteReader();
            while (dr.Read())
            {
                Veli veli = new Veli();
                veli.VeliID1 = dr.GetInt32(0);
                veli.Ad1 = dr.GetString(1);
                veli.Soyad1 = dr.GetString(2);
                veli.Telefon1 = dr.GetString(3);
                veli1.Add(veli);
            }
            dr.Close();
            return veli1;
        }

        public void Update(int id, string Ad, string Soyad, string Telefon)
        {
            SqlCommand sqlCommand3 = new SqlCommand("sp_Veli_Update @p1,@p2,@p3,@p4", Connection.connection1);
            sqlCommand3.Parameters.AddWithValue("@p1", id);
            sqlCommand3.Parameters.AddWithValue("@p2", Ad);
            sqlCommand3.Parameters.AddWithValue("@p3", Soyad);
            sqlCommand3.Parameters.AddWithValue("@p4", Telefon);
            SqlDataReader dr = sqlCommand3.ExecuteReader();
            if (sqlCommand3.Connection.State != ConnectionState.Open)
            {
                sqlCommand3.Connection.Open();
            }
            sqlCommand3.Connection.Close();


        }
        static List<Veli> veli2 = new List<Veli>();

        public List<Veli> Get(int id)
        {
            SqlCommand sqlCommand3 = new SqlCommand("Select * From Veli Where VeliID = @p1", Connection.connection1);
            sqlCommand3.Parameters.AddWithValue("@p1", id);
            if (sqlCommand3.Connection.State != ConnectionState.Open)
            {
                sqlCommand3.Connection.Open();
            }
            SqlDataReader dr = sqlCommand3.ExecuteReader();
            while (dr.Read())
            {
                Veli veli = new Veli();
                veli.VeliID1 = dr.GetInt32(0);
                veli.Ad1 = dr.GetString(1);
                veli.Soyad1 = dr.GetString(2);
                veli.Telefon1 = dr.GetString(3);
                veli1.Add(veli);
            }
            dr.Close();
            return veli1;
        }
        public static List<Veli> veli3 = new List<Veli>();

     

        public bool Update(int prdouctId, bool productStatus)
        {
            throw new NotImplementedException();
        }

        public List<Veli> VeliBul(string ad, string soyad)
        {
            SqlCommand sqlCommand3 = new SqlCommand("Select * from Veli where Ad=@p1 and Soyad=@p2", Connection.connection1);
            sqlCommand3.Parameters.AddWithValue("@p1", ad);
            sqlCommand3.Parameters.AddWithValue("@p2", soyad);

            if (sqlCommand3.Connection.State != ConnectionState.Open)
            {
                sqlCommand3.Connection.Open();
            }
            SqlDataReader dr = sqlCommand3.ExecuteReader();
            while (dr.Read())
            {
                Veli veli = new Veli();
                veli.VeliID1 = int.Parse(dr["VeliID"].ToString());
                veli.Ad1 = dr["Ad"].ToString();
                veli.Soyad1 = dr.GetString(1);
                veli.Telefon1 = dr.GetString(2);
                veli3.Add(veli);
                //return int.Parse(dr["VeliID"].ToString());

            }
            dr.Close();
            return veli3;
        }
        public int AdGet(string isim)
        {
            throw new NotImplementedException();
        }
        //public static List<Ogrenci> ogrenci2 = new List<Ogrenci>();
    }
}

