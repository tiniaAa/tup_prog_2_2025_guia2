using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    internal class Servicio
    {
        Persona persona;

        List <Persona> personas = new List <Persona> ();
        public bool AgregarPersona(int dni, string nombre)
        {
            persona = new Persona(dni, nombre);
            Persona existe=VerPersonPorDni(persona.Dni);

            if (existe==null)
            {
                personas.Add(persona);
                return true;
            }
            return false;
        }

        public int VerCantidadPersona()
        {
            int Cantidad = personas.Count();
            return Cantidad;
        }
        public Persona VerPersona (int n)
        {


            if (n >= 0 && n < personas.Count())
            {
                return personas[n];
            }
            else
            {
                return null;
            }
        }

        public Persona VerPersonPorDni (int dni)
        {
            int idx = -1;
            int indice = 0;


            while (idx==-1 && indice<personas.Count())
            {
                if (personas[indice].Dni== dni )
                {
                    idx = indice;
                }
                indice++;
            }
            if (idx>-1)
            {
                return personas[idx];
            }
            else
            {
                return null;
            }
        }
        public void EliminarPersona(Persona persona)
        {
            Persona elimina = VerPersonPorDni(persona.Dni);
            if (elimina!=null)
            {
                personas.Remove(persona);
            }
        }






    }
}
