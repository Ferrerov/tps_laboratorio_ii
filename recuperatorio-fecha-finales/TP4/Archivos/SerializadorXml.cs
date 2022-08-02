using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using Excepciones;

namespace Archivos
{
    public class SerializadorXml<T> : IArchivos<T> //where T : class, new()
    {
        public bool Guardar(string path, string nombre, T obj)
        {
            try
            {
                using(StreamWriter sw = new StreamWriter(path + nombre))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(T));
                    serializador.Serialize(sw, obj);
                    return true;
                }
            }
            catch(Exception)
            {
                throw new ErrorArchivoException("Error al guardar el archivo");
            }
        }

        public bool Leer(string path, string nombre, out T obj)
        {
            obj = default(T);
            try
            {
                using(StreamReader sr = new StreamReader(path + nombre))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(T));
                    obj = (T)serializador.Deserialize(sr);
                    return true;
                }
            }
            catch(Exception)
            {
                throw new ErrorArchivoException("Error al leer el archivo.");
            }
        }
    }
}
