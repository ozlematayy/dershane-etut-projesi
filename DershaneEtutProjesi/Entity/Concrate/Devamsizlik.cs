using Core.Etities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrate
{
    public class Devamsizlik : IEntity
    {

        private int DevamsizlikID;
        private int OgrID;
        private DateTime Tarih;
        private double Sure;
        private double KalanHak;

        public int DevamsizlikID1 { get => DevamsizlikID; set => DevamsizlikID = value; }
        public DateTime Tarih1 { get => Tarih; set => Tarih = value; }
        public double Sure1 { get => Sure; set => Sure = value; }
        public double KalanHak1 { get => KalanHak; set => KalanHak = value; }
        public int OgrID1 { get => OgrID; set => OgrID = value; }
    }
}
