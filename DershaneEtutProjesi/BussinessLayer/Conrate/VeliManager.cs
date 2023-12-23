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
    public class VeliManager:IVeliService
    {
        IVeliDAL _veliDAL;
        public VeliManager(IVeliDAL veliDAL)
        {
            _veliDAL = veliDAL;

        }

        public void VeliAdd(string ad, string soyad, string tel)
        {
            _veliDAL.VeliAdd(ad, soyad, tel);

        }

        public List<Veli> Get(int id)
        {
            return _veliDAL.Get(id);
        }

        public List<Veli> BlGetAll()
        {

            return _veliDAL.GetAll();
        }

        public List<Veli> VeliBul(string ad, string soyad)
        {
            return _veliDAL.VeliBul(ad, soyad);
        }

        public void Update(int Id, string Ad, string Soyad, string Telefon)
        {
            _veliDAL.Update(Id, Ad, Soyad, Telefon);
        }

        List<Veli> IVeliService.VeliBul(string ad, string soyad)
        {
            throw new NotImplementedException();
        }
    }
}
