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
    public class SinifManager : ISinifService
    {
        ISinifDAL _sinifDAL;
        public SinifManager(ISinifDAL sinifDAL)
        {
            _sinifDAL = sinifDAL;
        }
        public void Add(string sinif)
        {
            _sinifDAL.SinifEkle(sinif);
        }
        public List<Sinif> SinifGet(string a)
        {
            return _sinifDAL.SinifGet(a);
        }
        public List<Sinif> Get(int a)
        {
            return _sinifDAL.Get(a);
        }
    }
}
