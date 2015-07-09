using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Restaurant.Modelo
{
    public class Caja
    {
        int idcaja;
        string caja;
        DateTime fecha;
        int id_ini;
        int id_fin;
        public Caja(int i, string c, DateTime f, int ii, int fi)
        {
            idcaja = i;
            caja = c;
            fecha = f;
            id_ini = ii;
            id_fin = fi;
        }

        public int Id_fin
        {
            get { return id_fin; }
            set { id_fin = value; }
        }

        public int Id_ini
        {
            get { return id_ini; }
            set { id_ini = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public string Caja1
        {
            get { return caja; }
            set { caja = value; }
        }

        public int Idcaja
        {
            get { return idcaja; }
            set { idcaja = value; }
        }
    }
}
