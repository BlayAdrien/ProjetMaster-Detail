using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Metier;

namespace JeanBombeur
{
    /// <summary>
    /// Logique d'interaction pour UCPrixTaille.xaml
    /// </summary>
    public partial class UCPrixTaille : UserControl
    {
        
        public UCPrixTaille()
        {
            InitializeComponent();
            DataContext = this;
        }

        public static readonly DependencyProperty Taille = DependencyProperty.Register("Taille", typeof(string), typeof(UCPrixTaille), new PropertyMetadata());
        public static readonly DependencyProperty Prix = DependencyProperty.Register("PrixPlat",typeof(float), typeof(UCPrixTaille), new PropertyMetadata());

        

        public string TaillePlat
        {
            get
            {
                return GetValue(Taille) as string;
            }
            set
            {
                SetValue(Taille, value);
            }
        }

        public float PrixPlat
        {
            get
            {
                return (float)GetValue(Prix);
            }
            set
            {
                SetValue(Prix, value);
            }
        }
    }
}
