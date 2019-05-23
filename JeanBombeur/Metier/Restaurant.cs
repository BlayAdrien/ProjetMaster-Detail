using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Data;
using static System.Console;

namespace Metier
{
    public class Restaurant
    {/*
        public ObservableCollection<Plat> ListPlat
        {
            get
            {
                IEnumerable<Plat> filtrer = listPlat.Where(p => p.Categorie.StartsWith("Pizza"));
                foreach (Plat p in filtrer)
                {
                    WriteLine($"{p} ");
                }
                return listPlat;
            }
        }
        private ObservableCollection<Plat> listPlat;
        public Restaurant()
        {
            listPlat = new ObservableCollection<Plat>();
        }

        public void AjouterPlat(Plat p)
        {
            listPlat.Add(p);

        }*/
        public ObservableCollection<Plat> ListPlat { get { return listPlat; } }
        private ObservableCollection<Plat> listPlat = new ObservableCollection<Plat>();


        public Restaurant(ObservableCollection<Plat> listPlat)
        {
            listPlat = new ObservableCollection<Plat>();
        }

        public Restaurant()
        {
            listPlat = new ObservableCollection<Plat>();
        }


        public void AjouterPlat(Plat p)
        {
            listPlat.Add(p);

        }
    }

}













