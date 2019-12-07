using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesAbstractas
{
    abstract class Persona
    {

        string apellido;
        int dni;
        ENacionalidad nacionalidad;
        string nombre;

        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public int DNI
        {
            get { return this.dni; }
            set { this.dni = value; }
        }

        public ENacionalidad Nacionalidad
        {
            get { return this.nacionalidad; }
            set { this.nacionalidad = value; }
        }


        public string Nombre
        {
            get { return this.nombre; }
            set { nombre = value; }
        }


        public string StringToDNI
        {
            set { this.dni = value; }
        }

        public enum ENacionalidad
        {

            Argentino,
            Extranjero,
            
        }

        Persona() { }

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;

        }

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
            :this(nombre, apellido, nacionalidad)
        {
            this.DNI = dni;

        }


        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            :this(nombre,apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }

        public override string ToString() {


            StringBuilder cadena = new StringBuilder();

            cadena.AppendFormat("Nombre: {0} ", this.Nombre);
            cadena.AppendFormat("Apellido: {0} ", this.Apellido);
            cadena.AppendFormat("Nacionalidad: {0} ", this.nacionalidad.ToString());
            cadena.AppendFormat("Dni: {0} ", this.DNI);

            return cadena.ToString();
        
        }


        private  int ValidarDni(ENacionalidad nacionalidad, int dato) { 
        
        
        }

        private  int ValidarDni(ENacionalidad nacionalidad, string dato)
        {


        }


        private string ValidarNombreApellido(string dato) { 
        

        
        }


    }
}
