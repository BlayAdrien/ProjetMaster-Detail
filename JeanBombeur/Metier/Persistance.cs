using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class Persistance
    {

        BinaryFormatter ecriture = new BinaryFormatter();

        public void sauvegarde(ObservableCollection<Plat> listeplat, string chemin)
        {
            int i;
            if (File.Exists(chemin))
            {
                File.Delete(chemin);
                File.Create(chemin).Close();
            }
            Stream sauvegarde = new FileStream(chemin, FileMode.Open, FileAccess.Write);
            for (i = 0; i < listeplat.Count; i++)
            {
                ecriture.Serialize(sauvegarde, listeplat[i]);
            }
            sauvegarde.Close();
        }
        
        public ObservableCollection<Plat> Chargement(string cheminAbsolu)
        {
            ObservableCollection<Plat> charge = new ObservableCollection<Plat>();
            Stream charge
        }

    }
}