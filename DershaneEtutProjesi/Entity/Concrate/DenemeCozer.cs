using Core.Etities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrate
{
    public class DenemeCozer : IEntity
    {

        private int CozerID;
        private int OgrID;
        private int DenemeID;
        private DateTime Tarih;
        private float Sonuc;
        private int BasariDurum;

        public int CozerID1 { get => CozerID; set => CozerID = value; }
        public DateTime Tarih1 { get => Tarih; set => Tarih = value; }
        public float Sonuc1 { get => Sonuc; set => Sonuc = value; }
        public int BasariDurum1 { get => BasariDurum; set => BasariDurum = value; }
        public int OgrID1 { get => OgrID; set => OgrID = value; }
        public int DenemeID1 { get => DenemeID; set => DenemeID = value; }

    }
}
