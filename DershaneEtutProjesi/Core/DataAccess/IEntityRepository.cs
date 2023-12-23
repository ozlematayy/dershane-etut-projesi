using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Etities;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
            List<T> GetAll();
            List<T> Get(int id);
    
            void Add(T Entity);
            
            int AdGet(string isim);
    }
}
