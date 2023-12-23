using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using Entity.Concrate;

namespace DataAccessLayer.Abstract
{
    public interface IOgrenciDAL : IEntityRepository<Ogrenci>
    {
        int GetSube(string a);
        List<Ogrenci> TCGet(string TC);

        void OgrAdd(string tc, int sinifid, int veliid, string ad, string soyad, char cinsiyet, string tel, DateTime dgtrh, string adres, int subeid);
        void Update(int id, string tc, int sinifid, int veliid, string ad, string soyad, char cinsiyet, string tel, DateTime dgtrh, string adres, int subeid);
        List<Ogrenci> BasariSiralamasi(int ad);
        List<Ogrenci> SinifListesi(string sube);
        List<Ogrenci> DenemeCozerGet(int isim);
        List<Ogrenci> YilKayitlari();
    }
}
