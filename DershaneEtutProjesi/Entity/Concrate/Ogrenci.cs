using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Etities;

namespace Entity.Concrate
{
    public class Ogrenci: IEntity
    {
        private int OgrID;
        private int SinifID;
        private int SubeID;
        private int VeliID;
        private string Ad;
        private string Soyad;
        private string TC;
        private char Cinsiyet;
        private string Telefon;
        private DateTime DogumTarih;
        private string Adres;

        public int OgrID1 { get => OgrID; set => OgrID = value; }
        public string Ad1 { get => Ad; set => Ad = value; }
        public string Soyad1 { get => Soyad; set => Soyad = value; }
        public char Cinsiyet1 { get => Cinsiyet; set => Cinsiyet = value; }
        public string Telefon1 { get => Telefon; set => Telefon = value; }
        public DateTime DogumTarih1 { get => DogumTarih; set => DogumTarih = value; }
        public string Adres1 { get => Adres; set => Adres = value; }
        public string TC1 { get => TC; set => TC = value; }
        public int SinifID1 { get => SinifID; set => SinifID = value; }
        public int SubeID1 { get => SubeID; set => SubeID = value; }
        public int VeliID1 { get => VeliID; set => VeliID = value; }
  
    }
}
