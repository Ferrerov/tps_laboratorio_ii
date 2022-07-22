using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class GestorTxt
    {
        public bool Guardar(string path, string nombre, string texto)
        {
            try
            {
                using(StreamWriter sw = new StreamWriter(path + nombre,false, Encoding.UTF8))
                {
                    sw.WriteLine(texto);
                    return true;
                }
            }
            catch(Exception)
            {

            }
            return false;
        }

        public bool Leer(string path, string nombre, out string texto)
        {
            texto = string.Empty;
            try
            {
                using(StreamReader sr = new StreamReader(path + nombre, Encoding.UTF8))
                {
                    texto = sr.ReadToEnd();
                    return true;
                }
            }
            catch (Exception)
            {

            }
            return false;
        }
    }
}
