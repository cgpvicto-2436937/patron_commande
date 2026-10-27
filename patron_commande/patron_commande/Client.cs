using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patron_commande
{
    public class Client
    {
        private Television television = new Television();
        private Telecommande telecommande = new Telecommande();

        public void allumer()
        {
            telecommande.appuyerBoutton(new AllumerCommande(television));
        }

        public void monterVolume()
        {
            telecommande.appuyerBoutton(new MonterVolumeCommande(television));
        }

        public void baisserVolume()
        {
            telecommande.appuyerBoutton(new BaisserVolumeCommande(television));
        }

        public void annuler()
        {
            telecommande.annulerDerniere();
        }

        public void lancer()
        {
            allumer();
            monterVolume();
            baisserVolume();
            monterVolume();

            Console.WriteLine(television.getEtat());
        }
    }
}
