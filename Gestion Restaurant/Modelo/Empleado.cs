using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Restaurant.Modelo
{
    public class Empleado
    {
        int idempleado;
        string empleado;
        string dni;

        public Empleado(int i, string e, string d)
        {
            idempleado = i;
            empleado = e;
            dni = d;
        }

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Empleado1
        {
            get { return empleado; }
            set { empleado = value; }
        }

        public int Idempleado
        {
            get { return idempleado; }
            set { idempleado = value; }
        }
    }
}
