using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;

namespace Biblioteca
{
    public class ListadoGenerico<T> where T : class
    {
        private List<T> listado;

        public ListadoGenerico()
        {
            this.listado = new List<T>();
        }

        public bool GuardarListado(string path, string nombre)
        {
            if (this.listado.Count > 0)
            {
                SerializadorXml<List<T>> serializador = new SerializadorXml<List<T>>();
                if (serializador.Guardar(AppDomain.CurrentDomain.BaseDirectory, "listaClientes.xml", this.listado))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
