using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Conrate
{
    public class DenemeCozerManager : IDenemeCozerService
    {
        IDenemeCozerDAL _denemeCozerDAL;
        public DenemeCozerManager(IDenemeCozerDAL denemeCozerDAL)
        {
            _denemeCozerDAL = denemeCozerDAL;
        }
        public void DenemeBilgiAdd(int ogrid, int denenemeid, int basari, DateTime trh)
        {
            _denemeCozerDAL.DenemeBilgiAdd(ogrid, denenemeid, basari, trh);
        }
    }
}
