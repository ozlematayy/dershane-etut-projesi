using Core.DataAccess;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IKayitDAL : IEntityRepository<Ogrenci>
    {
        void KayitAdd(int ogrid, DateTime kayitTarih);
        void Kayit_Al(int id, DateTime dateTime);
        List<Ogrenci> YeniKayit_Listele();
        void OgrIdDelete(int OgrId);

        void OgrTcDelete(string Tc);



    }
}
