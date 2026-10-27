using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patron_commande
{
    public class BaisserVolumeCommande : ICommande
    {
        private Television television;

        public BaisserVolumeCommande(Television television)
        {
            this.television = television;
        }

        public bool executer()
        {
            return television.baisserVolume();
        }

        public bool annuler()
        {
            return false;
        }

        public string getDescription()
        {
            return "Baisser le volume";
        }
    }
}
