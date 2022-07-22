using System;

namespace Archivos
{
    public interface IArchivos<T>
    {
         bool Guardar(string path, string nombre, T obj);

        bool Leer(string path, string nombre, out T obj);
    }
}
