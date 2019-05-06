using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class Restaurant
    {
        public List<Plat> ListPlat { get { return listPlat; } }
        private List<Plat> listPlat = new List<Plat>();

        public Restaurant(List<Plat> listPlat)
        {
            listPlat = new List<Plat>();
        }

        public Restaurant()
        {
            listPlat = new List<Plat>();
        }

        public void AjouterPlat(Plat p)
        {
            listPlat.Add(p);
        }
    }
}
