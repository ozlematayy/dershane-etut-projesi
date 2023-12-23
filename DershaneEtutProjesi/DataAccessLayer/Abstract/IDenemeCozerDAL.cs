using Core.DataAccess;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IDenemeCozerDAL:IEntityRepository<DenemeCozer>
    {
        void DenemeBilgiAdd(int ogrid, int denemeid, int basaridurum, DateTime trh);

    }
}
