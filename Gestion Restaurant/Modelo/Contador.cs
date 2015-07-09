using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Restaurant.Modelo
{
    public class Contador
    {
        int idcontador;
        int nro;

        public Contador(int i, int n)
        {
            idcontador = i;
            nro = n;
        }

        public int Nro
        {
            get { return nro; }
            set { nro = value; }
        }

        public int Idcontador
        {
            get { return idcontador; }
            set { idcontador = value; }
        }
    }
}
