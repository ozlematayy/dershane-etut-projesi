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

    public class DenemeManager : IDenemeService
    {
        IDenemeDAL _denemeDAL;
        public DenemeManager(IDenemeDAL denemeDAL)
        {
            _denemeDAL = denemeDAL;
        }
        public void DenemeSilme(string Adi)
        {
            _denemeDAL.DenemeSilme(Adi);
        }
        public List<Deneme> DenemeleriGetirme()
        {
            return _denemeDAL.DenemeleriGetirme();
        }

        //ders ekleme de ada göre ekleme yapacağından ortak metot olarak kullanılabilir.
        public void Add(string ad)
        {
            _denemeDAL.DenemeAdd(ad);
        }
        public int AdGet(string isim)
        {
            return _denemeDAL.AdGet(isim);
        }
        public List<Deneme> DenemeAdGet(string isim)
        {
            return _denemeDAL.DenemeAdGet(isim);
        }
    }
}
