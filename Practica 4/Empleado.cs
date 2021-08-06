using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    class Empleado
    {
        private string nombre;
        private int numero, dni;

        public string Nombre { set { nombre = value; } get { return nombre; } }
        public int Numero { set { numero = value; } get { return numero; } }

        public int Dni { set { dni = value; } get { return dni; } }

        public Empleado() { }

        public Empleado(string nombre, int numero, int dni)
        {
            this.Nombre = nombre;
            this.Numero = numero;
            this.Dni = dni;
        }
        public override string ToString()
        {
            return "Nombre: " + this.nombre + " Numero: " + this.numero + " DNI: " + this.dni;
        }
    }
}
