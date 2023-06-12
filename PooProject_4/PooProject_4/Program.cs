using PooProject_4;

public class Program
{
    private static void Main(string[] args)
    {
        Empleado empleado1 = new Empleado("Juan", 30, "Analista", 5000);

        Empleado empleado2 = new Empleado("Maria", 28, "Desarrollador", 4500);

        List<Empleado> empleadosACargo = new List<Empleado> { empleado1, empleado2 };

        Gerente gerente = new Gerente("Pedro", 40, "Gerente de Proyectos", 8000, empleadosACargo);

        Programador programador = new Programador("Luis", 25, "Programador Junior", 6000, "C#");

        List<Persona> personas = new List<Persona> { empleado1, empleado2, gerente, programador };

        foreach(Persona persona in personas)
        {
            persona.Saludar();

            if(persona is Empleado empleado)
            {
                empleado.Trabajar();
            }
            if (persona is IPagable pagable)
            {
                decimal salario = pagable.CalcularSalario();
                Console.WriteLine($"El salario de {persona.Nombre} es: {salario}");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}