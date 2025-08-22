using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    internal class Persona
    {
        public int Dni { get; set; }
        public string Nombre { get; set; }

        public Persona(int dni, string nombre)
        {
            Dni=dni;
            Nombre=nombre;
        }

        public string Describir()
        {
            return $"{Dni}-{Nombre}";
        }

    }
}
