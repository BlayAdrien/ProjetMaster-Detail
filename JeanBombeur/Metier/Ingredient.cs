using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class Ingredient : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged; 
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string nomIngredient;
        public string NomIngredient
        {
            get
            {
                return nomIngredient;
            }
            set
            {
                if (value.Length > 50)
                {
                    nomIngredient = value.Substring(0, 50);
                }
                else
                {
                    nomIngredient = value;
                }
                OnPropertyChanged();
            }
        }

        private Quantite quantite;
        public Quantite Quantite
        {
            get
            {
                return quantite;
            }
            set
            {
                quantite = value;
            }
        }

        public Ingredient(string nomIngredient, Quantite quantite)
        {
            this.nomIngredient = nomIngredient;
            this.quantite = quantite;
        }

        public Ingredient()
        {
            nomIngredient = "default";
            quantite = new Quantite();

        }


        public override string ToString()
        {
            return quantite.ToString() + " " + nomIngredient + "\n";
        }
    }
}
