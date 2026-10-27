using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patron_commande
{
    public class MonterVolumeCommande : ICommande
    {
        private Television television;

        public MonterVolumeCommande(Television television)
        {
            this.television = television;
        }

        public bool executer()
        {
            return television.monterVolume();
        }

        public bool annuler()
        {
            return false;
        }

        public string getDescription()
        {
            return "Monter le volume";
        }
    }
}
