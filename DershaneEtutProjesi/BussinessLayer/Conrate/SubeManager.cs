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

    public class SubeManager : ISubeService
    {
        ISubeDAL _subeDAL;
        public SubeManager(ISubeDAL subeDAL)
        {
            _subeDAL = subeDAL;
        }
        public void Add(string sube)
        {
            _subeDAL.SubeEkle(sube);
        }
        public void Update(int id, char sube)
        {
            _subeDAL.Update(id, sube);
        }
        public List<Sube> Get(int id)
        {
            return _subeDAL.Get(id);
        }
        public List<Sube> AdGet(char isim)
        {
            return _subeDAL.AdGet(isim);
        }
    }
}
