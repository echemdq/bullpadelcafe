using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Restaurant.Modelo
{
    public class Usuario
    {
        int idusuarios;
        string usuario;
        string contrasena;

        public Usuario(int i, string u, string c)
        {
            idusuarios = i;
            usuario = u;
            contrasena = c;
        }

        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }

        public string Usuario1
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public int Idusuarios
        {
            get { return idusuarios; }
            set { idusuarios = value; }
        }

    }
}
