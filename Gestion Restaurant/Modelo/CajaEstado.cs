using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Restaurant.Modelo
{
    public class CajaEstado
    {
        int idcajaestado;
        string estado;

        public CajaEstado(int i, string e)
        {
            idcajaestado = i;
            estado = e;
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public int Idcajaestado
        {
            get { return idcajaestado; }
            set { idcajaestado = value; }
        }

    }
}
