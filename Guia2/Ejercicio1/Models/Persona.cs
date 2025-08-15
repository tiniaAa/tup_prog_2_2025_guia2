using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Persona
    {
        public int DNI { get; set; }
        public string NOMBRE {get;set;}


        public Persona(int dni, string nombre) 
        {
            NOMBRE = nombre;
            DNI = dni;
        }
        public string Describir ()
        {
            return $"{DNI}-{NOMBRE}";
        }
    }
}
