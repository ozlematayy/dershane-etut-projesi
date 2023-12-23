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
    public class DenemeCozerDAL : IDenemeCozerDAL
    {
        public void Add(DenemeCozer Entity)
        {
            throw new NotImplementedException();
        }

        public int AdGet(string isim)
        {
            throw new NotImplementedException();
        }

        public void DenemeBilgiAdd(int ogrid, int denemeid, int basaridurum, DateTime trh)
        {

            Connection.connection1.Close();
            Connection.connection1.Open();
            SqlCommand sqlCommand2 = new SqlCommand("sp_DenemeCozer_Insert @p1,@p2,@p3,@p4", Connection.connection1);
            sqlCommand2.Parameters.AddWithValue("@p1", ogrid);
            sqlCommand2.Parameters.AddWithValue("@p2", denemeid);
            sqlCommand2.Parameters.AddWithValue("@p3", basaridurum);
            sqlCommand2.Parameters.AddWithValue("@p4", trh);


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

        public List<DenemeCozer> Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<DenemeCozer> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(int prdouctId, bool productStatus)
        {
            throw new NotImplementedException();
        }
    }
}
