using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patron_commande
{
    public interface ICommande
    {
        bool executer();
        bool annuler();
        string getDescription();
    }
}
