﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excepciones
{
    public class NacionalidadInvalidaException : Exception
    {

        public NacionalidadInvalidaException()
        {
        }

        public NacionalidadInvalidaException(string message)
            : base(message)
        {
        }

    }
}
