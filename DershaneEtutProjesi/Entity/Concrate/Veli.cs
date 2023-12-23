using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Etities;

namespace Entity.Concrate
{
    public class Veli:IEntity
    {
        private int VeliID;
        private string Ad;
        private string Soyad;
        private string Telefon;

        public int VeliID1 { get => VeliID; set => VeliID = value; }
        public string Ad1 { get => Ad; set => Ad = value; }
        public string Soyad1 { get => Soyad; set => Soyad = value; }
        public string Telefon1 { get => Telefon; set => Telefon = value; }
    }
}
