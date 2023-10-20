using System;

namespace LiskovRefactor
{
    class Radio : Principal
    {
        public Radio(string pMensaje) : base(pMensaje)
        {

        }

        public override void Muestra()
        {
            Console.WriteLine("Desde el radio: {0}", mensaje);
        }
    }
}
