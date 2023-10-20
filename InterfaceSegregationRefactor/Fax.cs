using System;

namespace InterafaceSegregationRefactor
{
    class Fax : IFax
    {
        // Ahora solo implementamos los métodos que son necesarios
        public void Faxear()
        {
            Console.WriteLine("Envio un fax");
        }

        public void Telefono()
        {
            Console.WriteLine("Te marco a un telefono");
        }
    }
}
