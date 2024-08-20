// See https://aka.ms/new-console-template for more information
using Pila.Clases;
using Pila.Interfaces;

Console.WriteLine("Hello, World!");

var cola = new Cola(5);
var pila = new Pilas(6);

ColeccionAbstracta[] array = {cola, pila};

pila.añadir("Elemento 1");
pila.añadir("Elemento 2");
pila.añadir("Elemento 3");
pila.añadir("Elemento 4");
pila.añadir("Elemento 5");
pila.añadir("Elemento 6");



Console.WriteLine("Primer elemento: " + pila.primero());

Console.WriteLine("Elemento extraído: " + pila.extraer());

Console.WriteLine("¿Está vacía la pila? " + pila.estaVacia());

while (!pila.estaVacia())
{
    Console.WriteLine("Elemento extraído: " + pila.extraer());
}

Console.WriteLine("¿Está vacía la pila? " + pila.estaVacia());



cola.añadir("Elemento 1");
cola.añadir("Elemento 2");
cola.añadir("Elemento 3");
cola.añadir("Elemento 4");
cola.añadir("Elemento 5");



Console.WriteLine("Primer elemento: " + cola.primero());

Console.WriteLine("Elemento extraído: " + cola.extraer());

Console.WriteLine("¿Está vacía la pila? " + cola.estaVacia());

Console.WriteLine("Elementos en la pila:");
for (int i = 0; i < 3; i++) 
{
    Console.WriteLine(cola.extraer());
}

Console.WriteLine("¿Está vacía la pila? " + cola.estaVacia());

Console.WriteLine();
