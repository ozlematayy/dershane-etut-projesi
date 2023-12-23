using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Constants;
using BussinessLayer.Abstract;
using Core.Utilities.Results;
using DataAccessLayer.Abstract;
using Entity.Concrate;

namespace BussinessLayer.Conrate
{
    public class OgrenciManager: IOgrenciService
    {
        IOgrenciDAL _ogrenciDAL;
        public OgrenciManager(IOgrenciDAL ogrenciDAL)
        {
            _ogrenciDAL = ogrenciDAL;
        }
        public List<Ogrenci> BlGetAll()
        {
           
            return _ogrenciDAL.GetAll();
        }

        public void OgrenciAdd(string tc, int sinifid, int veliid, string ad, string soyad, char cinsiyet, string tel, DateTime dgtrh, string adres, int subeid)
        {
            _ogrenciDAL.OgrAdd(tc, sinifid, veliid, ad, soyad, cinsiyet, tel, dgtrh, adres, subeid);

        }
        public int GetSube(string a)
        {
            return _ogrenciDAL.GetSube(a);
        }
        public List<Ogrenci> TCGet(string TC)
        {
            return _ogrenciDAL.TCGet(TC);
        }

        public void Update(int id, string tc, int sinifid, int veliid, string ad, string soyad, char cinsiyet, string tel, DateTime dgtrh, string adres, int subeid)
        {
            if (id == 0 && tc=="" && sinifid==0 && veliid==0 && subeid == 0)
            {
                new ErrorResult(Messages.ProductInvalid);
            }
            else
            {
                _ogrenciDAL.Update(id, tc, sinifid, veliid, ad, soyad, cinsiyet, tel, dgtrh, adres, subeid);
            }
            
        }
        public List<Ogrenci> Get(int id)
        {
            return _ogrenciDAL.Get(id);
        }
        public List<Ogrenci> BasariSiralama(int ad)
        {
            return _ogrenciDAL.BasariSiralamasi(ad);
        }

        public List<Ogrenci> SinifListesi(string sube)
        {
            return _ogrenciDAL.SinifListesi(sube);
        }
        public List<Ogrenci> DenemeCozerGet(int isim)
        {
            return _ogrenciDAL.DenemeCozerGet(isim);
        }
        public List<Ogrenci> YilKayitlari()

        {
            return _ogrenciDAL.YilKayitlari();
        }
    }
   
}
