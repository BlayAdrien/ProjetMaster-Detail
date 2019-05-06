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


            r.AjouterPlat(new Plat("Pizza", "Hawaienne ", 10, new ObservableCollection<Ingredient>
            {
                new Ingredient("Ananas", new Quantite(10, Unite.unité)),
                new Ingredient("Ananas", new Quantite(10, Unite.unité)),

            }));

            return r;

        }
    }
}
//, Jambon, Fromage, Sauce Tomate