using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooProject_4
{
    public abstract class Persona
    {
        public string Nombre { get;set; }
        public int Edad { get;set; }

        protected Persona(string nombre, int edad)
        { 
            Nombre = nombre;
            Edad = edad;
        }

        public virtual void Saludar()
        {
            Console.WriteLine($"Hola, mi nombre es {Nombre}");
        }
    }
}
