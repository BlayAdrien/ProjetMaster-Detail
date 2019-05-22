using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace Metier
{
    public class Restaurant 
    {
        

        public ObservableCollection<Plat> ListPlat { get { return listPlat; } }
        private ObservableCollection<Plat> listPlat = new ObservableCollection<Plat>();

        ICollectionView view = CollectionViewSource.GetDefaultView(Plat);

        view.Filter = o => ((Plat) o).Categorie == "Pizza";
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
