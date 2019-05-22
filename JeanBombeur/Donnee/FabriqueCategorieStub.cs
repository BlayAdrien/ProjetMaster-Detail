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

            r.AjouterPlat(new Plat("Pizza", "Reine", "/Image/Pizza/reine.jpg", 10,
                new ObservableCollection<Ingredient>
                {
                    new Ingredient("Coulis de tomates", new Quantite(100, Unite.g)),
                    new Ingredient("Tranches de jambon", new Quantite(4, Unite.unité)),
                    new Ingredient("Gruyère rapé", new Quantite(30, Unite.g)),
                    new Ingredient("Champignon", new Quantite(250, Unite.g)),
                }
            ));

            r.AjouterPlat(new Plat("Pizza", "Hawaienne", "/Image/Pizza/Hawaienne.jpg", 12,
                new ObservableCollection<Ingredient>
                {
                    new Ingredient("Coulis de tomates", new Quantite(150, Unite.g)),
                    new Ingredient("Mozzarella", new Quantite(100, Unite.g)),
                    new Ingredient("Tranches de jambon", new Quantite(3, Unite.unité)),
                    new Ingredient("Ananas", new Quantite(1, Unite.unité)),

                }
            ));

             r.AjouterPlat(new Plat("Pizza", "Margherita", "/Image/Pizza/Margherita.jpg", 6,
                 new ObservableCollection<Ingredient>
                 {
                    new Ingredient("Coulis de tomates", new Quantite(700, Unite.g)),
                    new Ingredient("Mozzarella", new Quantite(400, Unite.g)),
                    new Ingredient("Feuilles de basilic", new Quantite(30, Unite.unité)),
                 }
             ));

            r.AjouterPlat(new Plat("Pizza", "4 fromages", "/Image/Pizza/4fromages.jpg", 8,
                 new ObservableCollection<Ingredient>
                 {
                    new Ingredient("Coulis de tomates", new Quantite(100, Unite.g)),
                    new Ingredient("Gorgonzola", new Quantite(160, Unite.g)),
                    new Ingredient("Parmesan râpés", new Quantite(80, Unite.g)),
                    new Ingredient("Boule de mozzarella", new Quantite(1, Unite.unité)),
                    new Ingredient("Fromages de chèvre", new Quantite(160, Unite.g)),
                 }
             ));

            r.AjouterPlat(new Plat("Pizza", "4 saisons", "/Image/Pizza/4 saisons.jpg", 8,
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

            r.AjouterPlat(new Plat("Hamburger", "Big Mac", "/Image/Hamburger/BigMac.jpg", 8,
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

            r.AjouterPlat(new Plat("Hamburger", "Fish", "/Image/Hamburger/Fish.jpg", 8,
                 new ObservableCollection<Ingredient>
                 {
                    new Ingredient("Pain à burger", new Quantite(2, Unite.unité)),
                    new Ingredient("Filet de colin pané", new Quantite(400, Unite.g)),
                    new Ingredient("Feuilles de laitue", new Quantite(2, Unite.unité)),
                    new Ingredient("Sauce maison", new Quantite(1, Unite.unité)),
                    new Ingredient("Cornichons", new Quantite(3, Unite.unité)),
                 }
             ));

            r.AjouterPlat(new Plat("Hamburger", "Chicken", "/Image/Hamburger/Chicken.jpg", 8,
                new ObservableCollection<Ingredient>
                {
                    new Ingredient("Pain à burger", new Quantite(2, Unite.unité)),
                    new Ingredient("Filet de d'escalope pané", new Quantite(400, Unite.g)),
                    new Ingredient("Feuilles de laitue", new Quantite(2, Unite.unité)),
                    new Ingredient("Sauce maison", new Quantite(1, Unite.unité)),
                }
             ));

            r.AjouterPlat(new Plat("Hamburger", "Bacon", "/Image/Hamburger/Fish.jpg", 8,
                new ObservableCollection<Ingredient>
                {
                    new Ingredient("Pain à burger", new Quantite(2, Unite.unité)),
                    new Ingredient("Steaks hachés", new Quantite(3, Unite.unité)),
                    new Ingredient("Tranches de cheddar", new Quantite(3, Unite.unité)),
                    new Ingredient("Sauce burger", new Quantite(1, Unite.unité)),
                    new Ingredient("Tranches de lard fumé", new Quantite(6, Unite.unité)),
                    new Ingredient("Oignons", new Quantite(1, Unite.unité)),
                }
            ));


            return r;

        }
    }
}
