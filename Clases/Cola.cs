using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila.Clases
{
    public class Cola : ColeccionAbstracta
    {
        private int frente; // Índice del frente de la cola
        private int final;  // Índice del final de la cola

        public Cola(int size) : base(size)
        {
            frente = 0;
            final = 0;
        }

        public override bool añadir(object item)
        {
            if (final == array.Length)
            {
                // La cola está llena
                return false;
            }
            else
            {
                array[final] = item;
                final++;
                return true;
            }
        }

        public override object extraer()
        {
            if (estaVacia())
            {
                // La cola está vacía
                return null;
            }
            else
            {
                object item = array[frente];
                array[frente] = null; // Limpia el elemento extraído
                frente++;
                if (frente == final) // Si la cola queda vacía
                {
                    frente = 0;
                    final = 0;
                }
                return item;
            }
        }

        public override bool estaVacia()
        {
            return frente == final;
        }
    }
}
