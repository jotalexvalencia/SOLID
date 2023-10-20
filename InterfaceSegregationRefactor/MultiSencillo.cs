using System;

namespace InterafaceSegregationRefactor
{
    class MultiSencillo : IMultiBasico
    {
        // Solo implementamos los metodos que necesitamos
        public void Escanear()
        {
            Console.WriteLine("Escaneo una fotografia");
        }

        public void Imprimir()
        {
            Console.WriteLine("Imprimo tu documento");
        }
    }
}
