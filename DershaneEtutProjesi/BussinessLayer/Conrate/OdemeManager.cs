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

    public class OdemeManager : IOdemeService
    {
        IOdemeDAL _odemeDAL;
        public OdemeManager(IOdemeDAL odemeDAL)
        {
            _odemeDAL = odemeDAL;
        }
        public List<Odeme> BlGetAll()
        {

            return _odemeDAL.GetAll();
        }

        public void OdemeAdd(int veliid, DateTime odemetrh, int tutar, string odemebilgi)
        {
            _odemeDAL.Add(veliid, odemetrh, tutar, odemebilgi);

        }
    }
}
