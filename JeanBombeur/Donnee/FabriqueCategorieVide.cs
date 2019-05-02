using Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Donnee
{
    public class FabriqueCategorieVide : FabriqueCategorie
    {
        public override Plat CreateCategorie()
        {
            return new Plat();
        }
    }
}
