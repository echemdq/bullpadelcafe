using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Restaurant.Modelo
{
    public class Configuracion
    {
        int idconfiguracion;
        string codigo;
        int cantidad;
        string hora;
        string clave;

        public Configuracion(int i, string c, int ca, string h, string cl)
        {
            idconfiguracion = i;
            codigo = c;
            cantidad = ca;
            hora = h;
            clave = cl;
        }

        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        public string Hora
        {
            get { return hora; }
            set { hora = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public int Idconfiguracion
        {
            get { return idconfiguracion; }
            set { idconfiguracion = value; }
        }
    }
}
