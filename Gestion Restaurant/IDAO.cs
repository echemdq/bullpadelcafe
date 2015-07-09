using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Restaurant
{
        public interface IDAO<T>
        {
            void Agregar(T dato);
            List<T> TraerTodos();
            void Borrar(T dato);
            T Buscar(string dato);
            List<T> BuscarEspecial(string dato);
            void Modificar(T dato);
            int traerSigID();
        }   

}
