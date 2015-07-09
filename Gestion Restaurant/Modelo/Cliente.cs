using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Restaurant.Modelo
{
    public class Cliente
    {
        int idcliente;
        string descripcion;
        string dni;
        string telefono;
        decimal saldo;
        string celular;

        public Cliente(int i, string d, string dn, string t, decimal s, string c)
        {
            idcliente = i;
            descripcion = d;
            dni = dn;
            telefono = t;
            saldo = s;
            celular = c;
        }

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        public decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int Idcliente
        {
            get { return idcliente; }
            set { idcliente = value; }
        }
    }
}
