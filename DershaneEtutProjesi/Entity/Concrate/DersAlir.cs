using Core.Etities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrate
{
    public class DersAlir : IEntity
    {

        private int DersAlirID;
        private int DersID;
        private int SinifID;
        private DateTime Tarih;


        public int DersAlirID1 { get => DersAlirID; set => DersAlirID = value; }
        public DateTime Tarih1 { get => Tarih; set => Tarih = value; }
        public int DersID1 { get => DersID; set => DersID = value; }
        public int SinifID1 { get => SinifID; set => SinifID = value; }
     
    }
}
