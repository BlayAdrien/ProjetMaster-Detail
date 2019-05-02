using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class Plat
    {
        public List<Ingredient> ListIng { get { return listIng; } }
        private List<Ingredient> listIng = new List<Ingredient>();

        private string nomPlat;
        public string NomPlat
        {
            get { return nomPlat; }
            set
            {
                if (value.Length > 50)
                    nomPlat = value.Substring(0, 50);
                else
                    nomPlat = value;
            }
        }

        private float prixPlat; 
        public float PrixPlat
        {
            get { return prixPlat; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                prixPlat = value;
            }
        }

        public Plat()
        {
            NomPlat = "default";
            PrixPlat = 0;
            listIng = new List<Ingredient>();
        }

        public Plat(string nomPlat, float prixPlat, List<Ingredient> listIng)
        {
            NomPlat = nomPlat;
            PrixPlat = prixPlat;
            listIng = new List<Ingredient>();
        }

    }
}
