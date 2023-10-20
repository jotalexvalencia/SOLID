using System;

namespace LiskovRefactor
{
    class Noticiero : Principal
    {
        public Noticiero(string pMensaje) : base(pMensaje)
        {

        }

        public override void Muestra()
        {
            Console.WriteLine("Desde el noticiero: {0}", mensaje);
        }
    }
}
