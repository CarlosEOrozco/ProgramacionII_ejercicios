using Pila.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila.Clases
{
    public abstract class ColeccionAbstracta : Icolleccion
    {
        protected object[] array;
        protected int next;

        public ColeccionAbstracta(int size)
        {
            array = new object[size];
            next = 0;
        }
        public virtual bool añadir(object item)
        {
            if (next == array.Length)
            {
                return false;
            }
            else
            {
                array[next] = item;
                next++;
                return true;
            }
        }
      
        public virtual bool estaVacia()
        {
            if (next == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public abstract object extraer();
       

        public virtual object primero()
        {
            if (estaVacia())
            {
                global::System.Console.WriteLine("Ta vacia");
                return null;
            }
            else
            {
                return array[0];
            }
        }
       
    }
}
