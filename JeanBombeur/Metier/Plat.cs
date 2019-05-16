using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class Plat : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

       // public List<Ingredient> ListIng { get { return listIng; } }
        //private List<Ingredient> listIng = new List<Ingredient>();

        private string nomPlat;
        public string NomPlat
        {
            get { return nomPlat; }
            set
            {
                if (value.Length > 50)
                    nomPlat = value.Substring(0, 50);
                else
                    nomPlat = value;
            }
        }

        private float prixPlat; 
        public float PrixPlat
        {
            get { return prixPlat; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                prixPlat = value;
            }
        }

        private string categorie; 
        public string Categorie
        {
            get { return categorie; }
            set
            {
                if (value.Length > 30)
                    categorie = value.Substring(0, 30);
                else
                    categorie = value;
            }
        }

        private ObservableCollection<Ingredient> listIngredient;
        public ReadOnlyObservableCollection<Ingredient> ListIngredient
        {
            get
            {
                return new ReadOnlyObservableCollection<Ingredient>(listIngredient);
            }
        }

        public Plat()
        {
            Categorie = "default";
            NomPlat = "default";
            PrixPlat = 0;
            listIngredient = new ObservableCollection<Ingredient>(); ;
        }

        public Plat(string categorie, string nomPlat, float prixPlat, ObservableCollection<Ingredient> listIngredient)
        {
            Categorie = categorie;
            NomPlat = nomPlat;
            PrixPlat = prixPlat;
            this.listIngredient = listIngredient;
        }

    }
}
