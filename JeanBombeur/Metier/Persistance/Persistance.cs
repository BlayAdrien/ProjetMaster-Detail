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
        /// <summary>
        /// Méthode de sauvegarde d'un restaurant. 
        /// </summary>
        /// <param name="chemin"> Chemin vers lequel sera effetué la sauvegarde.</param>

        public static void Sauvegarde(string chemin, Restaurant r)
        {
            using (Stream stream = new FileStream(chemin, FileMode.Create))
            {
                var XML = new XmlSerializer(typeof(Restaurant));
                XML.Serialize(stream, r);
            }
        }

        /// <summary>
        /// Méthode de chargement.
        /// </summary>
        /// <param name="chemin">Chemin vers lequel se fera le chargement.</param>
        /// <returns>return le restaurant qui sera déserialisé.</returns>
 
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