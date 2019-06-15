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

            r.AjouterPlat(new Plat("Pizza", "Reine", "/Image/Pizza/Reine.png","M", 8,
                new ObservableCollection<Ingredient>
                {
                    new Ingredient("de coulis de tomates", new Quantite(100, Unite.g)),
                    new Ingredient("de tranches de jambon", new Quantite(4, Unite.unité)),
                    new Ingredient("de gruyère rapé", new Quantite(30, Unite.g)),
                    new Ingredient("de champignon", new Quantite(250, Unite.g))
                }
            ));

            r.AjouterPlat(new Plat("Pizza", "Hawaienne", "/Image/Pizza/Hawaienne.png", "L", 10,
                new ObservableCollection<Ingredient>
                {
                    new Ingredient("de coulis de tomates", new Quantite(150, Unite.g)),
                    new Ingredient("de mozzarella", new Quantite(100, Unite.g)),
                    new Ingredient("de tranches de jambon", new Quantite(3, Unite.unité)),
                    new Ingredient("d'ananas", new Quantite(1, Unite.unité))
                }
            ));

             r.AjouterPlat(new Plat("Pizza", "Margherita", "/Image/Pizza/Margherita.png", "M", 6,
                 new ObservableCollection<Ingredient>
                 {
                    new Ingredient("de coulis de tomates", new Quantite(700, Unite.g)),
                    new Ingredient("de mozzarella", new Quantite(400, Unite.g)),
                    new Ingredient("de feuilles de basilic", new Quantite(30, Unite.unité))
                 }
             ));

            r.AjouterPlat(new Plat("Pizza", "4 fromages", "/Image/Pizza/4fromages.png", "XL", 11,
                 new ObservableCollection<Ingredient>
                 {
                    new Ingredient("de coulis de tomates", new Quantite(100, Unite.g)),
                    new Ingredient("de gorgonzola", new Quantite(160, Unite.g)),
                    new Ingredient("de parmesan râpés", new Quantite(80, Unite.g)),
                    new Ingredient("de mozzarella", new Quantite(100, Unite.g)),
                    new Ingredient("de fromages de chèvre", new Quantite(160, Unite.g))
                 }
             ));

            r.AjouterPlat(new Plat("Pizza", "4 saisons", "/Image/Pizza/4 saisons.png", "M", 8,
                 new ObservableCollection<Ingredient>
                 {
                    new Ingredient("de coulis de tomates", new Quantite(100, Unite.g)),
                    new Ingredient("de champignons", new Quantite(150, Unite.g)),
                    new Ingredient("de tranches de jambon blanc", new Quantite(2, Unite.unité)),
                    new Ingredient("d'huile d'olive ", new Quantite(4, Unite.càs)),
                    new Ingredient("de tomates", new Quantite(3, Unite.unité)),
                    new Ingredient("d'aubergine", new Quantite(1, Unite.unité)),
                    new Ingredient("de poignée d'olives", new Quantite(1, Unite.unité))
                 }
             ));

            r.AjouterPlat(new Plat("Hamburger", "Big Mac", "/Image/Hamburger/BigMac.png", "M", 6,
                 new ObservableCollection<Ingredient>
                 {
                    new Ingredient("de pain à burger", new Quantite(2, Unite.unité)),
                    new Ingredient("de steak haché", new Quantite(45, Unite.g)),
                    new Ingredient("de feuilles de laitue", new Quantite(2, Unite.unité)),
                    new Ingredient("de tranche de cheddar", new Quantite(1, Unite.unité)),
                    new Ingredient("d'oignons", new Quantite(1, Unite.unité)),
                    new Ingredient("de cornichons", new Quantite(3, Unite.unité))
                 }
             ));

            r.AjouterPlat(new Plat("Hamburger", "Fish", "/Image/Hamburger/Fish.PNG", "M", 7,
                 new ObservableCollection<Ingredient>
                 {
                    new Ingredient("de pain à burger", new Quantite(2, Unite.unité)),
                    new Ingredient("de filet de colin pané", new Quantite(400, Unite.g)),
                    new Ingredient("de feuilles de laitue", new Quantite(2, Unite.unité)),
                    new Ingredient("de sauce maison", new Quantite(1, Unite.unité)),
                    new Ingredient("de cornichons", new Quantite(3, Unite.unité))
                 }
             ));

            r.AjouterPlat(new Plat("Hamburger", "Chicken", "/Image/Hamburger/Chicken.PNG", "M", 7,
                new ObservableCollection<Ingredient>
                {
                    new Ingredient("de pain à burger", new Quantite(2 , Unite.unité)),
                    new Ingredient("de filet de d'escalope pané", new Quantite(400, Unite.g)),
                    new Ingredient("de feuilles de laitue", new Quantite(2, Unite.unité)),
                    new Ingredient("de sauce maison", new Quantite(1, Unite.unité))
                }
             ));

            r.AjouterPlat(new Plat("Hamburger", "Bacon", "/Image/Hamburger/Bacon.PNG", "M", 8,
                new ObservableCollection<Ingredient>
                {
                    new Ingredient("de pain à burger", new Quantite(2, Unite.unité)),
                    new Ingredient("de steaks hachés", new Quantite(3, Unite.unité)),
                    new Ingredient("de tranches de cheddar", new Quantite(3, Unite.unité)),
                    new Ingredient("de sauce burger", new Quantite(1, Unite.unité)),
                    new Ingredient("de tranches de lard fumé", new Quantite(6, Unite.unité)),
                    new Ingredient("d'oignons", new Quantite(1, Unite.unité))
                }
            ));

            r.AjouterPlat(new Plat("Sandwich", "Thon", "/Image/Sandwichs/Thon.PNG", "M", 7,
                new ObservableCollection<Ingredient>
                {
                    new Ingredient("d'une demi Baguette", new Quantite(1, Unite.unité)),
                    new Ingredient("d'une petite boîte de thon au naturel", new Quantite(1, Unite.unité)),
                    new Ingredient("d'oignons", new Quantite(1, Unite.unité)),
                    new Ingredient("de comcombre", new Quantite(1, Unite.unité)),
                    new Ingredient("de tomate", new Quantite(1, Unite.unité)),
                    new Ingredient("de feuilles de laitue", new Quantite(3, Unite.unité))
                }
            ));

            r.AjouterPlat(new Plat("Sandwich", "Jambon Beurre", "/Image/Sandwichs/Jambon.PNG", "M", 6,
              new ObservableCollection<Ingredient>
              {
                    new Ingredient("d'une demi Baguette", new Quantite(1, Unite.unité)),
                    new Ingredient("de tranche de jambon blanc", new Quantite(1, Unite.unité)),
                    new Ingredient("d'oignons", new Quantite(1, Unite.unité)),
                    new Ingredient("de comcombre", new Quantite(1, Unite.unité)),
                    new Ingredient("de tomate", new Quantite(1, Unite.unité)),
                    new Ingredient("de feuilles de laitue", new Quantite(3, Unite.unité))
              }
            ));

            r.AjouterPlat(new Plat("Sandwich", "Poulet", "/Image/Sandwichs/Poulet.PNG", "M", 8,
              new ObservableCollection<Ingredient>
              {
                    new Ingredient("d'une demi Baguette", new Quantite(1, Unite.unité)),
                    new Ingredient("d'escalopes grillées de poulet", new Quantite(2, Unite.unité)),
                    new Ingredient("d'oignons", new Quantite(1, Unite.unité)),
                    new Ingredient("de comcombre", new Quantite(1, Unite.unité)),
                    new Ingredient("de tomate", new Quantite(1, Unite.unité)),
                    new Ingredient("de feuilles de laitue", new Quantite(3, Unite.unité))
              }
          ));

            r.AjouterPlat(new Plat("Sandwich", "Vegan", "/Image/Sandwichs/Vegan.PNG", "XL", 13,
              new ObservableCollection<Ingredient>
              {
                    new Ingredient("d'une demi Baguette", new Quantite(1, Unite.unité)),
                    new Ingredient("d'oignons", new Quantite(1, Unite.unité)),
                    new Ingredient("de comcombre", new Quantite(1, Unite.unité)),
                    new Ingredient("de tomate", new Quantite(1, Unite.unité)),
                    new Ingredient("de feuilles de laitue", new Quantite(3, Unite.unité))
              }
          ));

            r.AjouterPlat(new Plat("Sandwich", "Américain", "/Image/Sandwichs/Américain.PNG", "M", 9,
              new ObservableCollection<Ingredient>
              {
                    new Ingredient("d'une demi Baguette", new Quantite(1, Unite.unité)),
                    new Ingredient("de tranches de cheddar", new Quantite(4, Unite.unité)),
                    new Ingredient("de steaks hachés", new Quantite(2, Unite.unité)),
                    new Ingredient("d'oignons", new Quantite(1, Unite.unité)),
                    new Ingredient("de comcombre", new Quantite(1, Unite.unité)),
                    new Ingredient("de tomate", new Quantite(1, Unite.unité)),
                    new Ingredient("de feuilles de laitue", new Quantite(3, Unite.unité))
              }
          ));

            return r;
        }
    }
}
