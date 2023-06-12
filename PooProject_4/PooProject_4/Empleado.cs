using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooProject_4
{
    public class Empleado :Persona
    {
        public string Puesto { get; set; }
        public decimal Salario { get;set; }

        public Empleado(string nombre, int edad, string puesto, decimal salario) : base(nombre, edad)
        {
            Puesto = puesto;
            Salario = salario;
        }

        public override void Saludar()
        {
            Console.WriteLine($"Hola, soy {Nombre}, un empleado en el puesto de {Puesto}.");
        }

        public void Trabajar()
        {
            Console.WriteLine($"El empleado {Nombre} esta trabajando en el puesto de {Puesto}");
        }

        internal decimal CalcularSalario()
        {
            return Salario;
        }
    }
}
