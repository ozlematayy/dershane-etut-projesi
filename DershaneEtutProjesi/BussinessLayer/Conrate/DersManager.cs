using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Conrate
{

    public class DersManager : IDersService
    {
        IDersDAL _dersDAL;
        public DersManager(IDersDAL dersDAL)
        {
            _dersDAL = dersDAL;
        }
        public void Add(string ad)
        {
            _dersDAL.DersAdd(ad);
        }
        public int AdGet(string isim)
        {
            return _dersDAL.AdGet(isim);
        }
    }
}
