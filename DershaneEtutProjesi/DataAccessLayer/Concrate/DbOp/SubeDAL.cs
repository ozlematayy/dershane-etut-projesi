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

namespace DataAccessLayer.Concrate.DbOp
{

    public class SubeDAL : ISubeDAL
    {
        public void Add(Sube Entity)
        {
            throw new NotImplementedException();
        }
       static List<Sube> subes = new List<Sube>();
        public List<Sube> AdGet(char isim)
        {
            SqlCommand sqlCommand3 = new SqlCommand("sp_Sube_ADGet @p1", Connection.connection1);
            sqlCommand3.Parameters.AddWithValue("@p1", isim);
            if (sqlCommand3.Connection.State != ConnectionState.Open)
            {
                sqlCommand3.Connection.Open();
            }
            SqlDataReader dr = sqlCommand3.ExecuteReader();
            while (dr.Read())
            {
                Sube sube = new Sube();
                sube.SubeID1 = dr.GetInt32(0);
                sube.Sube1 = dr.GetString(1);
                subes.Add(sube);
                
            }
               
    
            dr.Close();
            return subes;
        }
        static List<Sube> sube1 = new List<Sube>();
        public List<Sube> Get(int id)
        {
            SqlCommand sqlCommand3 = new SqlCommand("Select * From Sube Where SubeID = @p1", Connection.connection1);
            sqlCommand3.Parameters.AddWithValue("@p1", id);
            if (sqlCommand3.Connection.State != ConnectionState.Open)
            {
                sqlCommand3.Connection.Open();
            }
            SqlDataReader dr = sqlCommand3.ExecuteReader();
            while (dr.Read())
            {
                Sube sube = new Sube();
                sube.SubeID1 = dr.GetInt32(0);
                sube.Sube1= dr.GetString(1);
                sube1.Add(sube);
            }
            dr.Close();
            return sube1;
        }

        public List<Sube> GetAll()
        {
            throw new NotImplementedException();
        }

        public void SubeEkle(string sube)
        {

            Connection.connection1.Close();
            Connection.connection1.Open();
            SqlCommand sqlCommand2 = new SqlCommand("sp_Sube_Insert @p1", Connection.connection1);
            sqlCommand2.Parameters.AddWithValue("@p1", sube);

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

        public void Update(int id, char sube)
        {
            SqlCommand sqlCommand3 = new SqlCommand("sp_Sube_Update @p1,@p2", Connection.connection1);
            sqlCommand3.Parameters.AddWithValue("@p1", id);
            sqlCommand3.Parameters.AddWithValue("@p2", sube);
           
           
            SqlDataReader dr = sqlCommand3.ExecuteReader();
            if (sqlCommand3.Connection.State != ConnectionState.Open)
            {
                sqlCommand3.Connection.Open();
            }
            sqlCommand3.Connection.Close();


        }

        public int AdGet(string isim)
        {
            throw new NotImplementedException();
        }
    }
}
