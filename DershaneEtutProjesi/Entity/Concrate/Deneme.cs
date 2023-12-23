using Core.Etities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrate
{
    public class Deneme : IEntity
    {

        private int DenemeID;
        private string Ad;

        public int DenemeID1 { get => DenemeID; set => DenemeID = value; }
        public string Ad1 { get => Ad; set => Ad = value; }
       
    }
    }

