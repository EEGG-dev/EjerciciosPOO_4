using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooProject_4
{
    internal class Gerente : Empleado, IPagable
    {
        public List<Empleado> EmpleadosACargo { get; set; }

        public Gerente(string nombre, int edad, string puesto, decimal salario, List<Empleado> empleadosACargo)
            : base(nombre, edad, puesto, salario)
        {
            EmpleadosACargo = empleadosACargo;
        }
        public override void Saludar()
        {
            Console.WriteLine($"Hola, soy {Nombre}, un gerente a cargo de {EmpleadosACargo.Count} empleados");
        }

        public decimal CalcularSalario()
        {
            decimal salarioTotal = Salario;
            foreach (Empleado empleado in EmpleadosACargo)
            {
                salarioTotal += empleado.CalcularSalario();
            }
            return salarioTotal;
        }
    }
}
