using Donnee;
using Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TestMetier
{
    class Console
    {
        static void Main(string[] args)
        {
        }
    }
}
 /*
            WriteLine("Fabrication du STUB : \n");
            Restaurant r = new FabriqueCategorieVide().CreateCategorie();
            WriteLine(r);

            WriteLine(r);
            IEnumerable<Plat> filter = r.ListPlat;
            foreach (Plat p in filter)
            {
                WriteLine(p.NomPlat);
            }
            WriteLine();
        }
    }
}
/*
WriteLine("Ajout de plat. \n");
Restaurant resto = new Restaurant("Restaurant1");
r.AjouterPlat(new Plat());
            WriteLine(r);


WriteLine("Ajout d'un Ingrédient dans un plat");
Plat p = new Plat("Pizza", "Chevre-Miel", "M", 12, new ObservableCollection<Ingredient>());
p.AjouterIngredient(new Ingredient());
            WriteLine(p);


IEnumerable<Plat> filter = r.ListPlat;
foreach (Plat p in filter)
{
    WriteLine(p.NomPlat);
}
WriteLine();*/
