using Core.DataAccess;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ISubeDAL : IEntityRepository<Sube>
    {
        List<Sube> AdGet(char isim);
        void SubeEkle(string sube);
        void Update(int id, char sube);
    }
}
