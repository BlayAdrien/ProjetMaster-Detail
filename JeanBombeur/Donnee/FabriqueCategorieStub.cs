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

            r.AjouterPlat(new Plat("Pizza", "Reine", 10,
                new ObservableCollection<Ingredient>
                {
                    new Ingredient("Sauce Tomate", new Quantite(600, Unite.g)),
                    new Ingredient("Jambon", new Quantite(543, Unite.g))
                }
            ));
            r.AjouterPlat(new Plat("Pizza", "Hawaienne", 12,
                new ObservableCollection<Ingredient>
                {
                    new Ingredient("Jambon", new Quantite(543, Unite.g)),
                    new Ingredient("Ananas", new Quantite(543, Unite.g))

                }
            ));
            r.AjouterPlat(new Plat("Pizza", "Margarita", 6,
                 new ObservableCollection<Ingredient>
                 {
                    new Ingredient("Tomate", new Quantite(543, Unite.g)),
                    new Ingredient("Mozzarella", new Quantite(543, Unite.g)),
                    new Ingredient("Basilic", new Quantite(543, Unite.g))
                 }
             ));
            r.AjouterPlat(new Plat("Pizza", "4 fromages", 8,
                 new ObservableCollection<Ingredient>
                 {
                    new Ingredient("Fromage", new Quantite(543, Unite.g)),
                 }
             ));
            r.AjouterPlat(new Plat("Pizza", "4 saisons", 8,
                 new ObservableCollection<Ingredient>
                 {
                    new Ingredient("Mozzarella", new Quantite(543, Unite.g)),
                    new Ingredient("Champignons", new Quantite(543, Unite.g)),
                    new Ingredient("Jambon", new Quantite(543, Unite.g)),
                    new Ingredient("Huile d'olive ", new Quantite(543, Unite.g)),
                    new Ingredient("Olive", new Quantite(543, Unite.g)),
                 }
             ));

            r.AjouterPlat(new Plat("Hamburger", "4 saisons", 8,
                 new ObservableCollection<Ingredient>
                 {
                    new Ingredient("Mozzarella", new Quantite(543, Unite.g)),
                    new Ingredient("Champignons", new Quantite(543, Unite.g)),
                    new Ingredient("Jambon", new Quantite(543, Unite.g)),
                    new Ingredient("Huile d'olive ", new Quantite(543, Unite.g)),
                    new Ingredient("Olive", new Quantite(543, Unite.g)),
                 }
             ));



            return r;

        }
    }
}
