using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Generico
{
    public class SerializadorXML_Text
    {
        public bool Serializar<T>(string path, T elemento, bool flag)
        {
            if(File.Exists(path))
            {
                StreamWriter streamWriter = new StreamWriter(path, flag);
                try
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(streamWriter, elemento);
                    return true;
                }
                catch(Exception e)
                {
                    return false;
                }
                finally
                {
                    streamWriter.Close();
                }
            }
            return false;
        }

        public T Deserializar<T>(string path)
        {
            T retorno = default(T);
            if (File.Exists(path))
            {
                StreamReader streamReader = new StreamReader(path);
                try
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    retorno = (T)xmlSerializer.Deserialize(streamReader);
                }
                catch
                {
                    return retorno;
                }
                finally
                {
                    streamReader.Close();
                }
            }
            return retorno;
        }

        public bool GuardarTexto(string path, string datos, bool flag)
        {
            bool retorno = false;
            if (File.Exists(path))
            {
                StreamWriter streamWriter = new StreamWriter(path, flag);
                try
                {
                    string[] arrayDatos = datos.Split("\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    foreach (string dato in arrayDatos)
                    {
                        streamWriter.WriteLine(dato);
                    }
                    retorno = true;
                }
                catch (Exception e)
                {
                    retorno = false;
                }
                finally
                {
                    streamWriter.Close();
                }
            }
            return retorno;
        }

        public string LeerTexto(string path)
        {
            string retorno = "";
            if (File.Exists(path))
            {
                StreamReader streamReader = new StreamReader(path);
                try
                {
                    while (!streamReader.EndOfStream)
                    {
                        retorno += streamReader.ReadLine() + "\n";
                    }
                }
                catch(Exception e)
                {
                    retorno = null;
                }
                finally
                {
                    streamReader.Close();
                }
            }
            return retorno;
        }
    }
}
