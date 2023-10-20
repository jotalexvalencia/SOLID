using System;

namespace SingleResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            CEmpleado empleado = new CEmpleado("Alex", "Ingeniero Desarrollo de Software", 48, 2500000);
            Console.WriteLine(empleado);
            empleado.PagarImpuesto();
        }
    }
}
