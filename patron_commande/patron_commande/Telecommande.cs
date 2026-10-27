using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patron_commande
{
    public class Telecommande
    {
        private List<ICommande> historique = new List<ICommande>();

        public void appuyerBoutton(ICommande cmd)
        {
            if (cmd.executer())
            {
                historique.Add(cmd);
            }
        }

        public bool annulerDerniere()
        {
            if(historique.Count == 0)
            {
                return false;
            }

            int dernierePosition = historique.Count - 1;
            ICommande derniereCommande = historique[dernierePosition];

            if (derniereCommande.annuler())
            {
                historique.RemoveAt(dernierePosition);
                return true;
            }

            return false;
        }

        public List<ICommande> getHistorique()
        {
            return historique;
        }
    }
}
