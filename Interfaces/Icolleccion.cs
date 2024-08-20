using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila.Interfaces
{
    public interface Icolleccion
    {
        bool estaVacia();
        object extraer();
        object primero();
        bool añadir(object obj);
    }
}
