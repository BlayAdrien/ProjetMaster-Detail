using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Metier
{
    public class Persistance
    {
        public void Sauvegarde(string chemin)
        {
            using (Stream stream = new FileStream(chemin, FileMode.Create))
            {
                var XML = new XmlSerializer(typeof(Restaurant));
                XML.Serialize(stream, this);
            }
        }
        public static Restaurant Charge(string chemin)
        {
            using (Stream stream = new FileStream(chemin, FileMode.Open))
            {
                var XML = new XmlSerializer(typeof(Restaurant));
                return (Restaurant)XML.Deserialize(stream);
            }
        
        }        
    }
}