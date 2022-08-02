using System;

namespace Excepciones
{
    public class DniInvalidoException : Exception
    {
        public DniInvalidoException(string mensaje)
            :base(mensaje)
        {
        }
    }
}
