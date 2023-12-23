using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Core.Utilities.Var;

namespace DataAccessLayer.Concrate.Baglanti
{
    public class Connection
    {


        public static SqlConnection connection1
          = new SqlConnection(@"Data Source=.;Initial Catalog=Dershane_Etut_Projesi;User ID = " + Var.UserId + "; Password = " + Var.Password + "");
    }
}
