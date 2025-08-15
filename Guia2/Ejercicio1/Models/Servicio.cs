using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Servicio
    {
        
        List<Persona> personas = new List<Persona>();

        public bool AgregarPerson(Persona nueva)
        {
            Persona existe = VerPersonaPorDni(nueva.DNI);

            if (existe == null)
            {
                personas.Add(nueva);
                return true;
            }
            return false;
        }
        public int VerCantidadPersonas()
        { 
            return personas.Count;
        }
        public Persona VerPersoa(int n)
        {
            if (n>=0 && n<personas.Count)
            {
                return personas[n];
            }
            else
            {
                return null;
            }
            
            

        }

        public Persona VerPersonaPorDni(int dni )
        {
            int indice = -1;
            int cont = 0;

            while (indice == -1 && cont<personas.Count)
            {
                if (personas[cont].DNI == dni)
                {
                    indice = cont;
                 
                }
                cont++;

            }
            if (indice > -1)
            {
                return personas[indice];
            }
            else 
            {
                return null;
            }
            
        }
        public void EliminarPersona(Persona persona)
        {

            Persona per = VerPersonaPorDni(persona.DNI);

            if (per != null)
            {
                personas.Remove(persona);
            }
        }




        



    }
}
