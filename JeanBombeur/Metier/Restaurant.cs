using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Data;
using System.Runtime.CompilerServices;

namespace Metier
{
    public class Restaurant :INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

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

        public ObservableCollection<Plat> ListPlat
        {
            get
            {
                return new ObservableCollection<Plat>(listPlat);
            }
        }

        private string filter;

        public string Filter
        {
            get
            {
                return filter;
            }
            set
            {
                if (value.Length > 50)
                {
                    filter = value.Substring(0, 50);
                }
                else
                {
                    filter = value;
                }
            }
        }

        private IEnumerable<Plat> list;
        public IEnumerable<Plat> ListPlatFiltre
        {
            get
            {

                if (Plat.Equals(filter, "Pizza"))
                {
                    list = ListPlat.Where(p => p.Categorie.StartsWith("Pizza"));
                }
                if (Plat.Equals(filter, "Hamburger"))
                {
                    list = ListPlat.Where(p => p.Categorie.StartsWith("Hamburger"));
                }
                if (Plat.Equals(filter, "Sandwich"))
                {
                    list = ListPlat.Where(p => p.Categorie.StartsWith("Sandwich"));
                }
                return list;
            }
        }

        public void ValiderPlat(Plat p)
        {
            listPlat.Add(p);
        }

        public void AjouterPlat(Plat p)
        {
            listPlat.Add(p);
        }


        public Restaurant()
        {
            listPlat = new ObservableCollection<Plat>();
        }


        public Restaurant(string nomResto)
        {
            this.nomResto = nomResto;
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
            hashCode = hashCode * -1521134295 + EqualityComparer<ObservableCollection<Plat>>.Default.GetHashCode(ListPlat);
            return hashCode;
        }
    }
}













