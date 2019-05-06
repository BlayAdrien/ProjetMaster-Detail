using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class Quantite : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private int valeurQuantite;
        public int ValeurQuantite
        {
            get
            {
                return valeurQuantite;
            }
            set
            {
                valeurQuantite = value;
                OnPropertyChanged();
            }
        }

        private Unite unite;
        public Unite Unite
        {
            get
            {
                return unite;
            }
            set
            {
                unite = value;
                OnPropertyChanged();
            }
        }

        public Quantite()
        {
            valeurQuantite = 0;
            unite = Unite.unité;
        }

        public Quantite(int valeurQuantite, Unite unite)
        {
            this.valeurQuantite = valeurQuantite;
            this.unite = unite;
        }

        public override string ToString()
        {
            return valeurQuantite.ToString() + unite.ToString();
        }
    }
}
