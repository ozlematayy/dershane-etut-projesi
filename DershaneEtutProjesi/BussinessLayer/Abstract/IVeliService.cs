using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IVeliService
    {
        List<Veli> VeliBul(string ad, string soyad);
    }
}
