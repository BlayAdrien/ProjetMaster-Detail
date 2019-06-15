using Donnee;
using Metier;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace JeanBombeur
{

    public partial class App : Application
    {
        public static Restaurant Restaurant { get; private set; } = new FabriqueCategorieStub().CreateCategorie();
        public static Restaurant Sauvegarde;

    }
}
