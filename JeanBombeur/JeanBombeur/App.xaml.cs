using Donnee;
using Metier;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace JeanBombeur
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Restaurant Restaurant { get; private set; } = new FabriqueCategorieStub().CreateCategorie();
    }
}
