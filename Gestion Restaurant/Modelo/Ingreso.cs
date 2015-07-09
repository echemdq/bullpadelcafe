using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Restaurant.Modelo
{
    public class Ingreso
    {
        int idingreso;
        string proveedor;
        DateTime fecha;
        int nrocomp;
        string caja;
        decimal importe;

        public Ingreso(int i, string p, DateTime f, int n, string c, decimal imp)
        {
            idingreso = i;
            proveedor = p;
            fecha = f;
            nrocomp = n;
            caja = c;
            importe = imp;
        }

        public decimal Importe
        {
            get { return importe; }
            set { importe = value; }
        }

        public string Caja
        {
            get { return caja; }
            set { caja = value; }
        }

        public int Nrocomp
        {
            get { return nrocomp; }
            set { nrocomp = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public string Proveedor
        {
            get { return proveedor; }
            set { proveedor = value; }
        }

        public int Idingreso
        {
            get { return idingreso; }
            set { idingreso = value; }
        }
    }
}
