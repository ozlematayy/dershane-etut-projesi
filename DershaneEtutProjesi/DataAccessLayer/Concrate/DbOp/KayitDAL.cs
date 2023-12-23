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
    public class KayitDAL: IKayitDAL
    {
        public void KayitAdd(int ogrid, DateTime kayitTarih)
        {
            Connection.connection1.Close();
            Connection.connection1.Open();

            SqlCommand sqlCommand3 = new SqlCommand("sp_Kayit_Insert @p1,@p2", Connection.connection1);

            sqlCommand3.Parameters.AddWithValue("@p1", ogrid);
            sqlCommand3.Parameters.AddWithValue("@p2", kayitTarih);



            SqlDataReader dr = sqlCommand3.ExecuteReader();
            if (dr.Read())
            {
                Connection.connection1.Close();
            }

            else
            {
                Connection.connection1.Close();
            }

        }
        
        public void Kayit_Al(int id, DateTime dateTime)
        {
            Connection.connection1.Close();
            Connection.connection1.Open();
            SqlCommand sqlCommand2 = new SqlCommand("Kayit_den @p1,@p2", Connection.connection1);

            sqlCommand2.Parameters.AddWithValue("@p1", id);
            sqlCommand2.Parameters.AddWithValue("@p2", dateTime);

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
        List<Ogrenci> ogrencis = new List<Ogrenci>();
        public List<Ogrenci> YeniKayit_Listele()
        {
            Connection.connection1.Open();
            SqlCommand sqlCommand2 = new SqlCommand("sp_YeniKayit_Listele", Connection.connection1);
            SqlDataReader dr = sqlCommand2.ExecuteReader();
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
          
                ogrencis.Add(ogrenci);
            }
            dr.Close();
            return ogrencis;
        }
        public void OgrIdDelete(int OgrId)
        {
            Connection.connection1.Close();
            Connection.connection1.Open();
            SqlCommand dltkmt = new SqlCommand("sp_KayitSilmeOgrId_Delete @OgrId", Connection.connection1);

            if (dltkmt.Connection.State != ConnectionState.Open)
            {
                dltkmt.Connection.Open();
            }
            dltkmt.Parameters.AddWithValue("@OgrId", OgrId);
            dltkmt.ExecuteNonQuery();
            Connection.connection1.Close();


        }
        public void OgrTcDelete(string @Tc)
        {
            Connection.connection1.Close();
            Connection.connection1.Open();
            SqlCommand dltkmt = new SqlCommand("sp_KayitSilmeTc_Delete @Tc", Connection.connection1);

            if (dltkmt.Connection.State != ConnectionState.Open)
            {
                dltkmt.Connection.Open();
            }
            dltkmt.Parameters.AddWithValue("@Tc", Tc);
            dltkmt.ExecuteNonQuery();
            Connection.connection1.Close();


        }
        public void Add(Ogrenci Entity)
        {
            throw new NotImplementedException();
        }

        public int AdGet(string isim)
        {
            throw new NotImplementedException();
        }

        public List<Ogrenci> Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Ogrenci> GetAll()
        {
            throw new NotImplementedException();
        }

        
        }
    }

