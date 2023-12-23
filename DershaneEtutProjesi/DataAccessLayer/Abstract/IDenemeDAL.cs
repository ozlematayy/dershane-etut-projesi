using Core.DataAccess;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IDenemeDAL : IEntityRepository<Deneme>
    {
        void DenemeAdd(string ad);
        List<Deneme> DenemeAdGet(string isim);
        List<Deneme> DenemeleriGetirme();
        void DenemeSilme(string Adi);


    }
}
