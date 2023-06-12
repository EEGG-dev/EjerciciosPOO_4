using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooProject_4
{
    internal class Programador : Empleado, IPagable
    {
        public string LenguajePrincipal { get; set; }
        public Programador(string nombre, int edad, string puesto,decimal salario, string lenguajePrincipal):
            base(nombre, edad, puesto, salario)
        {
            LenguajePrincipal = lenguajePrincipal;
        }
        public override void Saludar()
        {
            Console.WriteLine($"Hola, soy {Nombre}, un programador especializado en {LenguajePrincipal}.");
        }
        public decimal CalcularSalario()
        {
            return Salario;
        }
    }
}
