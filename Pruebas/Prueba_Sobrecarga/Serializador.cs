using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Pruebas
{
    public class Serializador
    {
        public StreamWriter streamWriter;
        public StreamReader streamReader;
        public XmlSerializer xmlSerializer;

        //Recibe <T> para poder usarlo en los parametros
        public bool SerializarXML<T>(T elemento)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
            + "\\prueba.xml";
            streamWriter = new StreamWriter(path);
            xmlSerializer = new XmlSerializer(typeof(T));
            xmlSerializer.Serialize(streamWriter, elemento);
            streamWriter.Close();
            return true;

        }

        public T DeserializarXML<T>()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
            + "\\prueba.xml";
            streamReader = new StreamReader(path);
            xmlSerializer = new XmlSerializer(typeof(T));
            T elemento = (T)xmlSerializer.Deserialize(streamReader);
            streamReader.Close();
            return elemento;
        }
    }
}
