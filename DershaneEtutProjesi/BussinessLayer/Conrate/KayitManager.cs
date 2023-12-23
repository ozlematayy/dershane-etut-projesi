using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Conrate
{
    public class KayitManager: IKayitService
    {
        IKayitDAL _KayitDAL;
        public KayitManager(IKayitDAL kayitDAL)
        {
            _KayitDAL = kayitDAL;
        }

        public void KayitAdd(int ogrid, DateTime kayitTarih)
        {
            _KayitDAL.KayitAdd(ogrid, kayitTarih);
        }
        public void Kayit_Al(int id, DateTime dateTime)
        {
           _KayitDAL.Kayit_Al(id, dateTime);
        }
        public List<Ogrenci> YeniKayit_Listele()
        {
            return _KayitDAL.YeniKayit_Listele();
        }
        public void OgrIdDelete(int OgrId)
        {
            _KayitDAL.OgrIdDelete(OgrId);

        }
        public void OgrTcDelete(string Tc)
        {
            _KayitDAL.OgrTcDelete(Tc);

        }
    }
}
