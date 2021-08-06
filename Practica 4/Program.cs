using Practica_4;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabla_de_hash
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado uno = new Empleado("Nicolas", 12, 36630523);
            Empleado dos = new Empleado("Alberto", 23, 26630593);
            Empleado tres = new Empleado("Ricardo", 08,11663059);
            Lista tabla = new Lista(10);
            tabla.agregar(uno);
            tabla.agregar(dos);
            tabla.agregar(tres);
            tabla.mostrar();
  
        }
    }
}
