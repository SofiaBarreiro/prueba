using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excepciones
{
    public class DniInvalidoException : Exception
    {

        private string mensajeBase;

        public DniInvalidoException()
        {
        }

        public DniInvalidoException(Exception e)
            :base(e.Message) //sobreescribo el constructor, llamo al construcor de arriba y le paso los parametros
        {

        }

        public DniInvalidoException(string message)
            :base(message)
        {
        }

        public DniInvalidoException(string message, Exception e)
            : base(message)
        {
        }


    }
}
