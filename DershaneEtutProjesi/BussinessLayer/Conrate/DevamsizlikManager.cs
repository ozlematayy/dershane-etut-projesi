using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Conrate
{
    public class DevamsizlikManager : IDevamsizlikService
    {
        IDevamsizlikDAL _devamsizlikDAL;
        public DevamsizlikManager(IDevamsizlikDAL devamsizlikDAL)
        {
            _devamsizlikDAL = devamsizlikDAL;
        }

        public void DevamsizlikAdd(int ogrid, DateTime trh, double sure, double kalan)
        {
            _devamsizlikDAL.Add(ogrid, trh, sure, kalan);
        }
    }
}
