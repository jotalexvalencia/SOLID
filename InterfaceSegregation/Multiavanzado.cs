﻿using System;

namespace InterfaceSegregation
{
    class Multiavanzado : IMultifuncional
    {
        public void Imprimir()
        {
            Console.WriteLine("Imprimo tu reporte");
        }
        public void Escanear()
        {
            Console.WriteLine("Estoy escaneando un documento");
        }
        public void Telefono()
        {
            Console.WriteLine("Te marco a un telefono");
        }
        public void Faxear()
        {
            Console.WriteLine("Envio un fax");
        }

    }
}
