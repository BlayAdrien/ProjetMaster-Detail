using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Data;

namespace Metier
{
    public class Restaurant
    {
        public ObservableCollection<Plat> ListPlat { get; private set; }

        public CollectionView PlatView { get; private set; }
        public Restaurant(IList<Plat> listPlat)
        {
            ListPlat = new ObservableCollection<Plat>(listPlat);


            InitialiseViews();
        }

        private void InitialiseViews()
        {

            InitialiseProductOptionsView();
        }

        private void InitialiseProductOptionsView()
        {
            ProductOptionsView = CollectionViewSource.GetDefaultView(ProductOptions);
            ProductOptionsView.SortDescriptions.Add(
                new SortDescription("Option", ListSortDirection.Ascending));
        }
        public Plat SelectedPlat
        {
            set
            {
                if (value != null)
                {
                    ProductOptionsView.Filter = o => ((ProductOption)o).ProductCode == value.Code;
                }
            }

        }

    }
}









/*
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
    }*/

