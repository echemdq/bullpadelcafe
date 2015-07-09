using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Restaurant.Modelo
{
    public class Articulo
    {
        int idarticulo;
        string descripcion;
        string codbarra;
        decimal precio;
        int stock;
        decimal preciocalle;

        public Articulo(int i, string d, string c, decimal p, int s, decimal pc)
        {
            idarticulo = i;
            descripcion = d;
            codbarra = c;
            precio = p;
            stock = s;
            preciocalle = pc;
        }

        public decimal Preciocalle
        {
            get { return preciocalle; }
            set { preciocalle = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public string Codbarra
        {
            get { return codbarra; }
            set { codbarra = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int Idarticulo
        {
            get { return idarticulo; }
            set { idarticulo = value; }
        }
    }
}
