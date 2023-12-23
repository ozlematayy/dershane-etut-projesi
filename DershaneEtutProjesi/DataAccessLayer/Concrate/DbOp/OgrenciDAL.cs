using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using Entity.Concrate;
using System.Data.SqlClient;
using System.Data;
using DataAccessLayer.Concrate.Baglanti;


namespace DataAccessLayer.Concrate
{
    public class OgrenciDAL : IOgrenciDAL
    {
        public static List<Ogrenci> ogrenci1 = new List<Ogrenci>();
        public List<Ogrenci> TCGet(string TC)
        {
            SqlCommand sqlCommand3 = new SqlCommand("sp_Ogrenci_TCGet @p1", Connection.connection1);
            sqlCommand3.Parameters.AddWithValue("@p1", TC);
            if (sqlCommand3.Connection.State != ConnectionState.Open)
            {
                sqlCommand3.Connection.Open();
            }
            SqlDataReader dr = sqlCommand3.ExecuteReader();
            while (dr.Read()) 
            {
                Ogrenci ogrenci = new Ogrenci();
                ogrenci.OgrID1 = dr.GetInt32(0);
                ogrenci.TC1 = dr.GetString(1);
               // ogrenci.SinifID1 = dr.GetInt32(2);
                ogrenci.VeliID1 = dr.GetInt32(3);
                ogrenci.SubeID1 = dr.GetInt32(10);
                ogrenci.Ad1 = dr.GetString(4);
                ogrenci.Soyad1 = dr.GetString(5);
                ogrenci.Cinsiyet1 = Convert.ToChar(dr.GetString(6));
                ogrenci.Telefon1 = dr.GetString(7);
                ogrenci.DogumTarih1 = dr.GetDateTime(8);
                ogrenci.Adres1 = dr.GetString(9);
                ogrenci1.Add(ogrenci);
            }
            dr.Close();
            return ogrenci1;
        }

        public static List<Ogrenci> ogrenci2 = new List<Ogrenci>();

        public List<Ogrenci> GetAll()
        {
            SqlCommand sqlCommand1 = new SqlCommand("Sp_Ogrenci_Get", Connection.connection1);
            //var command = new SqlCommand("sp_DayBooks_Get @Id", connection);

            if (sqlCommand1.Connection.State != ConnectionState.Open)
            {
                sqlCommand1.Connection.Open();
            }
            SqlDataReader dr = sqlCommand1.ExecuteReader();
            while (dr.Read())
            {
                Ogrenci ogrenci = new Ogrenci();
                ogrenci.OgrID1 = dr.GetInt32(0);
                ogrenci.TC1 = dr.GetString(1);
                ogrenci.SinifID1 = dr.GetInt32(2);
                ogrenci.VeliID1 = dr.GetInt32(3);
                ogrenci.SubeID1 = dr.GetInt32(10);
                ogrenci.Ad1 = dr.GetString(4);
                ogrenci.Soyad1 = dr.GetString(5);
                ogrenci.Cinsiyet1 = Convert.ToChar( dr.GetString(6));
                ogrenci.Telefon1 = dr.GetString(7);
                ogrenci.DogumTarih1 = dr.GetDateTime(8);
                ogrenci.Adres1 = dr.GetString(9);
                ogrenci2.Add(ogrenci);
            }
            dr.Close();
            return ogrenci2;

        }

        public int GetSube(string sube)
        {
            SqlCommand sqlCommand1 = new SqlCommand("Select SubeID from Sube where Sube=@p1", Connection.connection1);
            sqlCommand1.Parameters.AddWithValue("@p1", sube);
            if (sqlCommand1.Connection.State != ConnectionState.Open)
            {
                sqlCommand1.Connection.Open();
            }
            SqlDataReader dr = sqlCommand1.ExecuteReader();
            while (dr.Read())
            {
                 return int.Parse(dr["SubeID"].ToString());
 
            }
            dr.Close();
            return 0;
        }
        public void Add(Ogrenci ogrenci)
        {
            throw new NotImplementedException();


        }

        public static List<Ogrenci> ogrenci3 = new List<Ogrenci>();

        public List<Ogrenci> Get(int id)
        {
            SqlCommand sqlCommand3 = new SqlCommand("sp_Ogrenci_IDGet @p1", Connection.connection1);
            sqlCommand3.Parameters.AddWithValue("@p1", id);
            if (sqlCommand3.Connection.State != ConnectionState.Open)
            {
                sqlCommand3.Connection.Open();
            }
            SqlDataReader dr = sqlCommand3.ExecuteReader();
            while (dr.Read())
            {
                Ogrenci ogrenci = new Ogrenci();
                ogrenci.OgrID1 = dr.GetInt32(0);
                ogrenci.TC1 = dr.GetString(1);
                ogrenci.SinifID1 = dr.GetInt32(2);
                ogrenci.VeliID1 = dr.GetInt32(3);
                ogrenci.SubeID1 = dr.GetInt32(10);
                ogrenci.Ad1 = dr.GetString(4);
                ogrenci.Soyad1 = dr.GetString(5);
                ogrenci.Cinsiyet1 = Convert.ToChar(dr.GetString(6));
                ogrenci.Telefon1 = dr.GetString(7);
                ogrenci.DogumTarih1 = dr.GetDateTime(8);
                ogrenci.Adres1 = dr.GetString(9);
                ogrenci3.Add(ogrenci);
            }
            dr.Close();
            return ogrenci3;
        }
        public void OgrAdd(string tc, int sinifid, int veliid, string ad, string soyad, char cinsiyet, string tel, DateTime dgtrh, string adres, int subeid)
        {
            Connection.connection1.Close();
            Connection.connection1.Open();
            SqlCommand sqlCommand2 = new SqlCommand("sp_Ogrenci_Insert @p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10", Connection.connection1);
            sqlCommand2.Parameters.AddWithValue("@p1", tc);
            sqlCommand2.Parameters.AddWithValue("@p2", sinifid);
            sqlCommand2.Parameters.AddWithValue("@p3", veliid);
            sqlCommand2.Parameters.AddWithValue("@p4", ad);
            sqlCommand2.Parameters.AddWithValue("@p5", soyad);
            sqlCommand2.Parameters.AddWithValue("@p6", cinsiyet);
            sqlCommand2.Parameters.AddWithValue("@p7", tel);
            sqlCommand2.Parameters.AddWithValue("@p8", dgtrh);
            sqlCommand2.Parameters.AddWithValue("@p9", adres);
            sqlCommand2.Parameters.AddWithValue("@p10", subeid);


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
        public int AdGet(string isim)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, string tc, int sinifid, int veliid, string ad, string soyad, char cinsiyet, string tel, DateTime dgtrh, string adres, int subeid)
        {
            SqlCommand sqlCommand3 = new SqlCommand("sp_Ogrenci_Update @p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11", Connection.connection1);
            sqlCommand3.Parameters.AddWithValue("@p1", id);
            sqlCommand3.Parameters.AddWithValue("@p2", tc);
            sqlCommand3.Parameters.AddWithValue("@p3", sinifid);
            sqlCommand3.Parameters.AddWithValue("@p4", veliid);
            sqlCommand3.Parameters.AddWithValue("@p5", ad);
            sqlCommand3.Parameters.AddWithValue("@p6",soyad);
            sqlCommand3.Parameters.AddWithValue("@p7",cinsiyet);
            sqlCommand3.Parameters.AddWithValue("@p8",tel);
            sqlCommand3.Parameters.AddWithValue("@p9",dgtrh);
            sqlCommand3.Parameters.AddWithValue("@p10",adres);
            sqlCommand3.Parameters.AddWithValue("@p11",subeid);
            
            if (sqlCommand3.Connection.State != ConnectionState.Open)
            {
                sqlCommand3.Connection.Open();
            }
            SqlDataReader dr = sqlCommand3.ExecuteReader();
            sqlCommand3.Connection.Close();
        }
        public static List<Ogrenci> ogrenci4 = new List<Ogrenci>();

        public List<Ogrenci> BasariSiralamasi(int ad)
        {
            SqlCommand sqlCommand3 = new SqlCommand("Sp_BasariSiralama @p1", Connection.connection1);
            //var command = new SqlCommand("sp_DayBooks_Get @Id", connection);
            sqlCommand3.Parameters.AddWithValue("@p1", ad);
            if (sqlCommand3.Connection.State != ConnectionState.Open)
            {
                sqlCommand3.Connection.Open();
            }

            SqlDataReader dr1 = sqlCommand3.ExecuteReader();

            while (dr1.Read())
            {
                Ogrenci ogrenci = new Ogrenci();
                ogrenci.OgrID1 = dr1.GetInt32(0);
                ogrenci.TC1 = dr1.GetString(1);
                ogrenci.SinifID1 = dr1.GetInt32(2);
                ogrenci.VeliID1 = dr1.GetInt32(3);
                ogrenci.SubeID1 = dr1.GetInt32(10);
                ogrenci.Ad1 = dr1.GetString(4);
                ogrenci.Soyad1 = dr1.GetString(5);
                ogrenci.Cinsiyet1 = Convert.ToChar(dr1.GetString(6));
                ogrenci.Telefon1 = dr1.GetString(7);
                ogrenci.DogumTarih1 = dr1.GetDateTime(8);
                ogrenci.Adres1 = dr1.GetString(9);
                ogrenci4.Add(ogrenci);
            }
            dr1.Close();
            return ogrenci4;
        }

        public static List<Ogrenci> ogrenci5 = new List<Ogrenci>();
        public List<Ogrenci> SinifListesi(string sube)
        {
            SqlCommand sqlCommand3 = new SqlCommand("sp_SinifListesi @p1", Connection.connection1);
            sqlCommand3.Parameters.AddWithValue("@p1", sube);
            if (sqlCommand3.Connection.State != ConnectionState.Open)
            {
                sqlCommand3.Connection.Open();
            }
            SqlDataReader dr = sqlCommand3.ExecuteReader();
            while (dr.Read())
            {
                Ogrenci ogrenci = new Ogrenci();
                ogrenci.OgrID1 = dr.GetInt32(0);
                ogrenci.TC1 = dr.GetString(1);
                ogrenci.SinifID1 = dr.GetInt32(2);
                ogrenci.VeliID1 = dr.GetInt32(3);
                ogrenci.SubeID1 = dr.GetInt32(10);
                ogrenci.Ad1 = dr.GetString(4);
                ogrenci.Soyad1 = dr.GetString(5);
                ogrenci.Cinsiyet1 = Convert.ToChar(dr.GetString(6));
                ogrenci.Telefon1 = dr.GetString(7);
                ogrenci.DogumTarih1 = dr.GetDateTime(8);
                ogrenci.Adres1 = dr.GetString(9);
                ogrenci5.Add(ogrenci);
            }
            dr.Close();
            return ogrenci5;
        }
        public static List<Ogrenci> ogrenci6 = new List<Ogrenci>();
        public List<Ogrenci> DenemeCozerGet(int isim)
        {

            SqlCommand sqlCommand3 = new SqlCommand("sp_DenemeTopTenGet @p1", Connection.connection1);
            //var command = new SqlCommand("sp_DayBooks_Get @Id", connection);
            sqlCommand3.Parameters.AddWithValue("@p1", isim);
            if (sqlCommand3.Connection.State != ConnectionState.Open)
            {
                sqlCommand3.Connection.Open();
            }

            SqlDataReader dr1 = sqlCommand3.ExecuteReader();

            while (dr1.Read())
            {
                Ogrenci ogrenci = new Ogrenci();
                ogrenci.OgrID1 = dr1.GetInt32(0);
                ogrenci.TC1 = dr1.GetString(1);
                ogrenci.SinifID1 = dr1.GetInt32(2);
                ogrenci.VeliID1 = dr1.GetInt32(3);
                ogrenci.SubeID1 = dr1.GetInt32(10);
                ogrenci.Ad1 = dr1.GetString(4);
                ogrenci.Soyad1 = dr1.GetString(5);
                ogrenci.Cinsiyet1 = Convert.ToChar(dr1.GetString(6));
                ogrenci.Telefon1 = dr1.GetString(7);
                ogrenci.DogumTarih1 = dr1.GetDateTime(8);
                ogrenci.Adres1 = dr1.GetString(9);
                ogrenci6.Add(ogrenci);
            }
            dr1.Close();
            return ogrenci6;

        }
        public static List<Ogrenci> ogrenci7 = new List<Ogrenci>();
        public List<Ogrenci> YilKayitlari()
        {
            SqlCommand sqlCommand3 = new SqlCommand("sp_YilKayitlari ", Connection.connection1);
            if (sqlCommand3.Connection.State != ConnectionState.Open)
            {
                sqlCommand3.Connection.Open();
            }

            SqlDataReader dr1 = sqlCommand3.ExecuteReader();

            while (dr1.Read())
            {
                Ogrenci ogrenci = new Ogrenci();
                ogrenci.OgrID1 = dr1.GetInt32(0);
                ogrenci.TC1 = dr1.GetString(1);
                ogrenci.SinifID1 = dr1.GetInt32(2);
                ogrenci.VeliID1 = dr1.GetInt32(3);
                ogrenci.SubeID1 = dr1.GetInt32(10);
                ogrenci.Ad1 = dr1.GetString(4);
                ogrenci.Soyad1 = dr1.GetString(5);
                ogrenci.Cinsiyet1 = Convert.ToChar(dr1.GetString(6));
                ogrenci.Telefon1 = dr1.GetString(7);
                ogrenci.DogumTarih1 = dr1.GetDateTime(8);
                ogrenci.Adres1 = dr1.GetString(9);
                ogrenci7.Add(ogrenci);
            }
            dr1.Close();
            return ogrenci7;
        }
    }
}

