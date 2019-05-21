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

            r.AjouterPlat(new Plat("Pizza", "Reine", "/Image/reine.jpg" ,10,
                new ObservableCollection<Ingredient>
                {
                    new Ingredient("Coulis de tomates", new Quantite(100, Unite.g)),
                    new Ingredient("Jambon", new Quantite(543, Unite.g))
                }
            ));
            r.AjouterPlat(new Plat("Pizza", "Hawaienne", "/Image/Hawaienne.jpg", 12,
                new ObservableCollection<Ingredient>
                {
                    new Ingredient("Coulis de tomates", new Quantite(100, Unite.g)),
                    new Ingredient("Jambon", new Quantite(543, Unite.g)),
                    new Ingredient("Ananas", new Quantite(543, Unite.g))

                }
            ));
            r.AjouterPlat(new Plat("Pizza", "Hawaienne", "/Image/.jpg", 12,
                new ObservableCollection<Ingredient>
                {
                    new Ingredient("Coulis de tomates", new Quantite(100, Unite.g)),
                    new Ingredient("Jambon", new Quantite(543, Unite.g)),
                    new Ingredient("Ananas", new Quantite(543, Unite.g))

                }
            ));
            r.AjouterPlat(new Plat("Pizza", "Margherita", "/Image/Margherita.jpg", 6,
                 new ObservableCollection<Ingredient>
                 {
                    new Ingredient("Coulis de tomates", new Quantite(100, Unite.g)),
                    new Ingredient("Tomate", new Quantite(543, Unite.g)),
                    new Ingredient("Mozzarella", new Quantite(543, Unite.g)),
                    new Ingredient("Basilic", new Quantite(543, Unite.g))
                 }
             ));
            r.AjouterPlat(new Plat("Pizza", "4 fromages", "/Image/4fromages.jpg", 8,
                 new ObservableCollection<Ingredient>
                 {
                    new Ingredient("Coulis de tomates", new Quantite(100, Unite.g)),
                    new Ingredient("gorgonzola", new Quantite(160, Unite.g)),
                    new Ingredient("Parmesan râpés", new Quantite(80, Unite.g)),
                    new Ingredient("boule de mozzarella", new Quantite(1, Unite.unité)),
                    new Ingredient("fromages de chèvre", new Quantite(160, Unite.g)),
                 }
             ));
            r.AjouterPlat(new Plat("Pizza", "4 saisons", "/Image/4 saisons.jpg", 8,
                 new ObservableCollection<Ingredient>
                 {
                    new Ingredient("Coulis de tomates", new Quantite(100, Unite.g)),
                    new Ingredient("Champignons", new Quantite(150, Unite.g)),
                    new Ingredient("Tranches de jambon blanc", new Quantite(2, Unite.unité)),
                    new Ingredient("cuillère à soupe d'huile d'olive ", new Quantite(4, Unite.unité)),
                    new Ingredient("Tomates", new Quantite(3, Unite.unité)),
                    new Ingredient("Aubergine", new Quantite(1, Unite.unité)),
                    new Ingredient("poignée d'olives", new Quantite(1, Unite.unité)),
                 }
             ));

            r.AjouterPlat(new Plat("Hamburger", "Big Mac", "/Image/BigMac.jpg", 8,
                 new ObservableCollection<Ingredient>
                 {
                    new Ingredient("Pain à burger", new Quantite(2, Unite.unité)),
                    new Ingredient("Steak haché", new Quantite(45, Unite.g)),
                    new Ingredient("Feuilles de laitue", new Quantite(2, Unite.unité)),
                    new Ingredient("Tranche de cheddar", new Quantite(1, Unite.unité)),
                    new Ingredient("Oignons", new Quantite(1, Unite.unité)),
                    new Ingredient("Cornichons", new Quantite(3, Unite.unité)),
                 }
             ));



            return r;

        }
    }
}
