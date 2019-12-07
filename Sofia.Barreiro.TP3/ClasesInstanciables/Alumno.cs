using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasesAbstractas;

namespace ClasesInstanciables
{
    sealed public class Alumno : Universitario

    {

        private Universidad.EClases claseQueToma;
        private Alumno.EEstadoCuenta estadoCuenta;

        Alumno() { }


        Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, EClases EclaseQueToma)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }

        Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, EClases EclaseQueToma, EEstadoCuenta estadoCuenta)
            : this(id, nombre, apellido, dni, nacionalidad, clasesQueToma)
        {
            this.estadoCuenta = estadoCuenta;

        }

        protected override string MostrarDatos() { }




    
    }
}
