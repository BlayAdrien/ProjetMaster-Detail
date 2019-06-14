using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class Persistance
    {

        public static void SauvegarderCategorie(string chemin, Plat p)
        {
            DataContractSerializer d = new DataContractSerializer(typeof(Plat));
            using (Stream s = File.Create(chemin))
            {
                d.WriteObject(s, p);
            }
        }


        public static Plat ChargerCategorie(string chemin)
        {
            DataContractSerializer d = new DataContractSerializer(typeof(Plat));
            using (Stream s = File.Open(chemin, FileMode.Open))
            {
                return d.ReadObject(s) as Plat;
            }
        }

    }
}