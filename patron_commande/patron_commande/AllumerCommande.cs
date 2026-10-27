using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace patron_commande
{
    public class AllumerCommande : ICommande
    {
        private Television television;

        public AllumerCommande(Television television)
        {
            this.television = television;
        }

        public bool executer()
        {
            return television.allumer();
        }

        public bool annuler()
        {
            return television.eteindre();
        }

        public string getDescription()
        {
            return "Allumer la télévision";
        }
    }
}
