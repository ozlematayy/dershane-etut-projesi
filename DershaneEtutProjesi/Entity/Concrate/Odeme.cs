using Core.Etities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrate
{
    public class Odeme:IEntity
    {
        private int OdemeID;
        private int VeliID;
        private DateTime OdemeTarih;
        private int Tutar;
        private string OdemeBilgisi;

        public int OdemeID1 { get => OdemeID; set => OdemeID = value; }
        public DateTime OdemeTarih1 { get => OdemeTarih; set => OdemeTarih = value; }
        public int Tutar1 { get => Tutar; set => Tutar = value; }
        public string OdemeBilgisi1 { get => OdemeBilgisi; set => OdemeBilgisi = value; }
        public int VeliID1 { get => VeliID; set => VeliID = value; }
        public Ogrenci ogrenci { get; set; }
    }
}
