using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Restaurant.Modelo
{
    public class Gasto
    {
        int idgasto;
        string caja;
        string detalle;
        decimal importe;
        DateTime fecha;

        public Gasto(int i, string c, string d, decimal imp, DateTime f)
        {
            idgasto = i;
            caja = c;
            detalle = d;
            importe = imp;
            fecha = f;
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public decimal Importe
        {
            get { return importe; }
            set { importe = value; }
        }

        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }

        public string Caja
        {
            get { return caja; }
            set { caja = value; }
        }

        public int Idgasto
        {
            get { return idgasto; }
            set { idgasto = value; }
        }
    }
}
