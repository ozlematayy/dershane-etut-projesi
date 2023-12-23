using Core.Etities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrate
{
    public class BasariDurumu : IEntity
    {
        private int BasDurumID;
        private int OgrId;
        private int BasariOrt;

        public int BasDurumID1 { get => BasDurumID; set => BasDurumID = value; }
        public int OgrId1 { get => OgrId; set => OgrId = value; }
        public int BasariOrt1 { get => BasariOrt; set => BasariOrt = value; }
    }
}
