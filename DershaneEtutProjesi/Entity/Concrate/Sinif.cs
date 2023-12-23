using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Etities;

namespace Entity.Concrate
{
    public class Sinif:IEntity
    {
        private int SinifID;
        private string OgrSinif;

        public int SinifID1 { get => SinifID; set => SinifID = value; }
        public string Sinif1 { get => OgrSinif; set => OgrSinif = value; }


    }
}

