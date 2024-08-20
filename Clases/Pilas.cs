using Pila.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila.Clases
{
    public class Pilas : ColeccionAbstracta
    {
        public Pilas(int size) : base(size)
        {
        }

        public override object extraer()
        {
            object e = null;

            if (!estaVacia())
            {

                next--;
                object item = array[next];
                array[next] = null;
                return item;
            }
            else
            {
                return e;
            }
            
        }
    }
}
