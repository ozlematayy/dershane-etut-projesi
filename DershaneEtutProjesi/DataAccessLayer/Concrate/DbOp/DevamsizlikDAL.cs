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

    public class DevamsizlikDAL : IDevamsizlikDAL
    {
        public void Add(Devamsizlik Entity)
        {
            throw new NotImplementedException();
        }

        public void Add(int ogrid, DateTime trh, double sure, double kalan)
        {

            Connection.connection1.Close();
            Connection.connection1.Open();
            SqlCommand sqlCommand2 = new SqlCommand("sp_Devamsizlik_Insert @p1,@p2,@p3,@p4", Connection.connection1);
            sqlCommand2.Parameters.AddWithValue("@p1", ogrid);
            sqlCommand2.Parameters.AddWithValue("@p2", trh);
            sqlCommand2.Parameters.AddWithValue("@p3", sure);
            sqlCommand2.Parameters.AddWithValue("@p4", kalan);


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

        public List<Devamsizlik> Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Devamsizlik> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(int prdouctId, bool productStatus)
        {
            throw new NotImplementedException();
        }
    }
}
