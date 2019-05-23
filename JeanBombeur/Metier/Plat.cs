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
    public class Plat : INotifyPropertyChanged , IEquatable<Plat>
    {

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // public List<Ingredient> ListIng { get { return listIng; } }
        //private List<Ingredient> listIng = new List<Ingredient>();

        public override int GetHashCode()
        {
            return NomPlat.GetHashCode();
        }



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

        private string image; 
        public string Image
        {
            get { return image; }
            set
            {
                image = value; OnPropertyChanged();
            }
        }

        public Plat()
        {
            Categorie = "default";
            NomPlat = "default";
            Image = image;
            PrixPlat = 0;
            listIngredient = new ObservableCollection<Ingredient>(); ;
        }

        public Plat(string categorie, string nomPlat, string image,  float prixPlat, ObservableCollection<Ingredient> listIngredient)
        {
            Categorie = categorie;
            NomPlat = nomPlat;
            Image = image; 
            PrixPlat = prixPlat;
            this.listIngredient = listIngredient;
        }

        public void AjouterIngredient(Ingredient i)
        {
            listIngredient.Add(i);
        }

        public override bool Equals(object obj)
        {
            //check null
            if (object.ReferenceEquals(obj, null))
            {
                return false;
            }

            if (object.ReferenceEquals(this, obj))
            {
                return true;
            }

            if (this.GetType() != obj.GetType())
            {
                return false;
            }

            return this.Equals(obj as Plat);
        }

        public bool Equals(Plat plat)
        {
            return (this.NomPlat.Equals(plat.NomPlat) && this.Categorie == plat.Categorie);
        }
    }
}
