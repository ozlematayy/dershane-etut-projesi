using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Conrate
{

    public class DersAlirManager : IDersAlirService
    {
        IDersAlirDAL _dersAlirDAL;
        public DersAlirManager(IDersAlirDAL dersAlirDAL)
        {
            _dersAlirDAL = dersAlirDAL;
        }

        public void Add(int dersId, int sinifId, DateTime trh)
        {
            _dersAlirDAL.Add(dersId, sinifId, trh);
        }
    }
}
