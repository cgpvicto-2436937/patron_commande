using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patron_commande
{
    public class Television
    {
        private bool estAllumee;
        private int volume;
        public bool allumer()
        {
            estAllumee = true;

            return true;
        }

        public bool eteindre()
        {
            estAllumee = false;

            return true;
        }

        public bool monterVolume()
        {
            volume+=10;

            return true;
        }

        public bool baisserVolume()
        {
            volume-= 10;

            return true;
        }

        public string getEtat()
        {
            return "Télévision allumée : " + estAllumee + ", Volume : " + volume;
        }
    }
}
