using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class Restaurant 
    {

        

        public List<Plat> ListPlat { get { return listPlat; } }
        private List<Plat> listPlat = new List<Plat>();

        private string categorie; 
        public string Categorie
        {
            get
            {
                if(categorie == "Pizza")
                {
                    return categorie;
                }
                return categorie;
            }
            set
            {
                if (value.Length > 50)
                    categorie = value.Substring(0, 50);
                else
                    categorie = value;
            }
        }

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
