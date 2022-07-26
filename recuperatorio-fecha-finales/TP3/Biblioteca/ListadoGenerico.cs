using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;

namespace Biblioteca
{
    public class ListadoGenerico<T> //where T : class
    {
        public List<T> listado;
        public int ultimoId;

        public ListadoGenerico(int ultimoId)
        {
            this.listado = new List<T>();
            this.ultimoId = ultimoId;
        }

        public int Count
        {
            get { return this.listado.Count; }
        }

        public bool AgregarElemento(T elemento)
        {
            if(elemento is not null)
            {
                this.listado.Add(elemento);
                return true;
            }
            return false;
        }

        public bool EliminarElemento(T elemento)
        {
            if(elemento is not null && this == elemento)
            {
                this.listado.Remove(elemento);
                return true;
            }
            return false;
        }

        public bool GuardarListado(string path, string nombre)
        {
            if (this.listado.Count > 0)
            {
                SerializadorXml<List<T>> serializador = new SerializadorXml<List<T>>();
                if (serializador.Guardar(path, nombre, this.listado))
                {
                    return true;
                }
            }
            return false;
        }

        public bool LeerListado(string path, string nombre)
        {
            List<T> listadoAuxiliar;
            SerializadorXml<List<T>> deserializador = new SerializadorXml<List<T>>();
            if (deserializador.Leer(path, nombre, out listadoAuxiliar))
            {
                this.listado = listadoAuxiliar;
                return true;
            }
            return false;
        }

        public static bool operator ==(ListadoGenerico<T> listado, T elemento)
        {
            foreach (T elementoAux in listado.listado)
            {
                if(elementoAux.Equals(elemento))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(ListadoGenerico<T> listado, T elemento)
        {
            return !(listado == elemento);
        }
    }
}
