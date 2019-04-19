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
using System.Windows.Threading;

namespace JeanBombeur
{
    
    public partial class Accueil : Page
    {
        MainWindow window;
        DispatcherTimer dt = new DispatcherTimer();

        public Accueil()
        {
            InitializeComponent();
        }

        public Accueil(MainWindow w) : this()
        {
            window = w;
        }
        
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            dt.Tick += dt_Tick;
            dt.Interval = TimeSpan.FromMilliseconds(10);
            dt.Start();
            if (mProgressBar.Value == mProgressBar.Maximum)
            {
                window.PageFrame.Navigate(new Categorie());
            }
        }

        void dt_Tick(object sender, EventArgs e)
        {
            mProgressBar.Value++;
        }
    }
}
