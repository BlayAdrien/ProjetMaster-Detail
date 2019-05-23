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
            Restaurant r = new FabriqueCategorieStub().CreateCategorie();
 
            IEnumerable<Plat> filter = r.ListPlat;
            foreach (Plat p in filter)
            {
                WriteLine(p.NomPlat);
            }
            WriteLine();
        }
    }
}
