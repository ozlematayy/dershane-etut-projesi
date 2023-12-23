using Core.DataAccess;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IVeliDAL:IEntityRepository<Veli>
    {
        List<Veli> VeliBul(string ad, string soyad);
        void VeliAdd(string ad, string soyad, string tel);

        void Update(int id, string Ad, string Soyad, string Telefon);
    }
}
