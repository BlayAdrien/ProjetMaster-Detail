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
                OnPropertyChanged("PrixPlat");
            }
        }

        private string taille; 
        public string Taille
        {
            get { return taille; }
            set
            {
                if (value.Length > 50)
                {
                    taille = value.Substring(0,50);
                }
                taille = value;               
                OnPropertyChanged("Taille");
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
        public ObservableCollection<Ingredient> ListIngredient
        {
            get
            {
                return new ObservableCollection<Ingredient>(listIngredient);
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

        /// <summary>
        /// Constructeur par défaut de Plat.
        /// </summary>

        public Plat()
        {
            Categorie = "default";
            NomPlat = "default";
            Image = image;
            PrixPlat = 0;
            Taille = "default"; 
            listIngredient = new ObservableCollection<Ingredient>(); ;
        }

        /// <summary>
        /// Constructeur de Plat avec 5 paramètres : une catégorie, un nomPlat, une taille, un prixPlat et une listIngrédient.
        /// </summary>


        public Plat(string categorie, string nomPlat, string taille, float prixPlat, ObservableCollection<Ingredient> listIngredient)
        {
            Categorie = categorie;
            NomPlat = nomPlat;
            Image = image;
            Taille = taille;
            PrixPlat = prixPlat;
            this.listIngredient = listIngredient;
        }

        /// <summary>
        /// Constructeur de Plat avec 6 paramètres : Une catégorie, un nom de plat, une taille, un prix, une image et une listIngredient.
        /// </summary>
 
        public Plat(string categorie, string nomPlat, string image, string taille, float prixPlat, ObservableCollection<Ingredient> listIngredient)
        {
            Categorie = categorie;
            NomPlat = nomPlat;
            Image = image;
            Taille = taille;
            PrixPlat = prixPlat;
            this.listIngredient = listIngredient;
        }

        /// <summary>
        /// Méthode d'ajout d'un ingrédient. 
        /// </summary>
        /// <param name="i">Ingrédient à ajouter.</param>

        public void AjouterIngredient(Ingredient i)
        {
            listIngredient.Add(i);
        }

        /// <summary>
        /// Méthode de suppression d'un ingrédient.
        /// </summary>
        /// <param name="i">Ingrédient à supprimer.</param>

        public bool SupprimerIngredient(Ingredient i)
        {
            return (listIngredient.Remove(i));
        }

        /// <summary>
        /// Méthode de equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>return un booléen.</returns>

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

        /// <summary>
        /// Méthode de GetHashCode
        /// </summary>
        /// <returns>return un int</returns>

        public override int GetHashCode()
        {
            return NomPlat.GetHashCode();
        }

        /// <summary>
        /// Retourne une Une catégorie, un nom de plat, une taille, un prix, une image et une listIngredient.
        /// </summary>
        public override string ToString()
        {
            return categorie.ToString() + nomPlat.ToString() + taille.ToString() + image.ToString() + prixPlat.ToString() + listIngredient.ToString();
        }
    }
}
