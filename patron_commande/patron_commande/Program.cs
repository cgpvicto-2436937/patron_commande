using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patron_commande
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Client client = new Client();

            client.lancer();
        }
    }
}
