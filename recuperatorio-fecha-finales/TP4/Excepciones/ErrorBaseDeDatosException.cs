﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ErrorBaseDeDatosException : Exception
    {
        public ErrorBaseDeDatosException(string mensaje)
            : base(mensaje)
        {
        }
    }
}
