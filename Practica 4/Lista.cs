using Practica_4;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
     class Lista
    {
        private ArrayList[] tabla;
        private int tamaño;

        public Lista(int tamaño)
        {
            this.tamaño = tamaño;
            tabla = new ArrayList[tamaño];
            for (int n = 0; n < tamaño; n++)
            {
                tabla[n] = new ArrayList();
            }
        }
        public void agregar(Empleado empleado)
        {
            int indice = 0;
            indice = hashF(empleado.Dni);
            tabla[indice].Add(empleado);
        }
        public int hashF(int llave)
        {
            int indice = 0;
            indice = llave % this.tamaño;
            return indice;
        }
        public void mostrar()
        {
            for (int n = 0; n < tamaño; n++)
            {
                if (tabla[n].Count==0)
                {
                    Console.WriteLine("Indice "+ n +" No hay elementos");
                }
                if (tabla[n].Count > 0)
                {
                    Console.Write("Indice: " + n+ "\n");
                    foreach (Empleado item in tabla[n])
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }
    }
}
