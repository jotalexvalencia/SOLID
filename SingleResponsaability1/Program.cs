using SingleResponsibility1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsaability1
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
