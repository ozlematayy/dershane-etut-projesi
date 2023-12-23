using Core.Etities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrate
{
    public class Kayit : IEntity
    {
        private int KayitID;
        private int OgrId;
        private DateTime BaslangicTarih;

        public int KayitID1 { get => KayitID; set => KayitID = value; }
        public int OgrId1 { get => OgrId; set => OgrId = value; }
        public DateTime BaslangicTarih1 { get => BaslangicTarih; set => BaslangicTarih = value; }
    }
}
