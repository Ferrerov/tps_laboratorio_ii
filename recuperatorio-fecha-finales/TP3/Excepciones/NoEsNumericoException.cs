using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NoEsNumericoException : Exception
    {
        public NoEsNumericoException(string mensaje)
            : base(mensaje)
        {
        }
    }
}
