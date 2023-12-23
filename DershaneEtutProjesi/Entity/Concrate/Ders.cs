using Core.Etities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrate
{
    public class Ders : IEntity
    {

        private int DersID;
        private string Ad;

        public int DersID1 { get => DersID; set => DersID = value; }
        public string Ad1 { get => Ad; set => Ad = value; }

    }
}
