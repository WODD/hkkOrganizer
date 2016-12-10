using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muziek_organisatie
{
    class Nummer
    {
        public string name { get; set; }
        public string genre { get; set; }
        public string composer { get; set; }
        public bool inMap { get; set; }
        public string eersteRegel { get; set; }
        public List<Plaats> gespeeld { get; set; }

    }

    class Plaats
    {

        public string stadNaam { get; set; }
        public string kerknaam { get; set; }
        public string datum { get; set; }
    
    }
}
