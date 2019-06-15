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

namespace JeanBombeur
{
    /// <summary>
    /// Logique d'interaction pour Note.xaml
    /// </summary>
    public partial class Note : UserControl
    {
   //     public delegate void Notation(int NbrCochon);
     //   public event Notation NbrCochon;

    //    private bool vote = false;

        public Note()
        {
            InitializeComponent();
        }
/*
        private void Cochon(object sender, RoutedEventArgs e)
        {
            int note = 0;
            if (vote)
            {
                return;
            }
            switch ((sender as Button).Name)
            {
                case "cochon1":
                    note = 1;
                    break;
                case "cochon2":
                    note = 2;
                    break;
                case "cochon3":
                    note = 3;
                    break;
                case "cochon4":
                    note = 4;
                    break;
                case "cochon5":
                    note = 5;
                    break;
                default:
                    note = 0;
                    break;
            }
            NbrCochon(note);
            vote = true;
        }*/
    }
}
 