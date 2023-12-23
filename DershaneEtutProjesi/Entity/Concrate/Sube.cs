using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Etities;

namespace Entity.Concrate
{
    public class Sube:IEntity
    {
        private int SubeID;
        private string OgrSube;

        public int SubeID1 { get => SubeID; set => SubeID = value; }
        public string Sube1 { get => OgrSube; set => OgrSube = value; }
    }
}
