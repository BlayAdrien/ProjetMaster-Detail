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
        private string nomResto;
        public string NomResto
        {
            get
            {
                return nomResto;
            }
            set
            {
                if (value.Length > 50)
                {
                    nomResto = value.Substring(0, 50);
                }
                else
                {
                    nomResto = value;
                }
            }
        }

        private ObservableCollection<Plat> listPlat;
        public ReadOnlyObservableCollection<Plat> ListPlat
        {
            get
            {
                return new ReadOnlyObservableCollection<Plat>(listPlat);
            }
        }

        public IEnumerable<Plat> filtrerPizza => ListPlat.Where(p => p.Categorie.StartsWith("Pizza"));
        public IEnumerable<Plat> filtrerSandwich => ListPlat.Where(p => p.Categorie.StartsWith("Sandwich"));
        public IEnumerable<Plat> filtrerHamburger => ListPlat.Where(p => p.Categorie.StartsWith("Hamburger"));


        public IEnumerable<Plat> ListPlatFiltre(string filter, string Ordered)
        {

            IEnumerable<Plat> list;

            if (filter == "Pizza")
            {
                list = filtrerPizza;
            }
            else if (filter == "Hamburger")
            {
                list = filtrerHamburger;
            }
            else
            {
                list = filtrerSandwich;
            }
            return list;
        }

        public Restaurant()
        {
            listPlat = new ObservableCollection<Plat>();
        }

        public Restaurant(string nomResto)
        {
            this.nomResto = nomResto;
        }

        public void AjouterPlat(Plat p)
        {
            listPlat.Add(p);
        }

        public override bool Equals(object other)
        {
            if (object.ReferenceEquals(other, null))
            {
                return false;
            }

            if (object.ReferenceEquals(this, other))
            {
                return true;
            }

            if (this.GetType() != other.GetType())
            {
                return false;
            }

            return this.Equals(other as Restaurant);
        }

        public override int GetHashCode()
        {
            var hashCode = -1063372659;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nomResto);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NomResto);
            hashCode = hashCode * -1521134295 + EqualityComparer<ObservableCollection<Plat>>.Default.GetHashCode(listPlat);
            hashCode = hashCode * -1521134295 + EqualityComparer<ReadOnlyObservableCollection<Plat>>.Default.GetHashCode(ListPlat);
            hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<Plat>>.Default.GetHashCode(filtrerPizza);
            hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<Plat>>.Default.GetHashCode(filtrerSandwich);
            hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<Plat>>.Default.GetHashCode(filtrerHamburger);
            return hashCode;
        }
    }
}













