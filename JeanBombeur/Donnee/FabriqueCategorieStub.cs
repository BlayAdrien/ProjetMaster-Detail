using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metier;

namespace Donnee
{
    public class FabriqueCategorieStub : FabriqueCategorie
    {
        public override Restaurant CreateCategorie()
        {
            Restaurant r = new Restaurant();
            List<Ingredient> listReine = new List<Ingredient>
            {
                new Ingredient("Jambon", new Quantite(10, Unite.cl)),
                new Ingredient("Oeuf", new Quantite(10, Unite.cl))
            };

            List<Ingredient> listHawaienne = new List<Ingredient>
            {
                new Ingredient("Jambon", new Quantite(10, Unite.cl)),
                new Ingredient("Oeuf", new Quantite(10, Unite.cl)),
                new Ingredient("Ananas", new Quantite(10, Unite.cl)),

            };



            r.AjouterPlat(
                new Plat("Pizza", "Reine", 10, listReine ));
                new Plat("Pizza", "Hawaienne", 10, listHawaienne);
            return r;

        }
    }
}
