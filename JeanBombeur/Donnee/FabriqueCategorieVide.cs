﻿using Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Donnee
{
    public class FabriqueCategorieVide : FabriqueCategorie
    {
        public override Restaurant CreateCategorie()
        {
            return new Restaurant();
        }
    }
}
