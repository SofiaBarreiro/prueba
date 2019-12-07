using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excepciones
{
    public class ArchivosException : Exception
    {

        public ArchivosException(Exception innerException)
            : base(innerException.Message) //le paso el mensaje de la excepcion que recibe, es de la clase base o padre
        {
        }
    }
}
