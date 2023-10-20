using System;
using System.Collections.Generic;

namespace DependencyInversionRefactor
{
    class Almacen : IAuditable
    {
        // Ya no hay necesidad de dar acceso a la lista
        private List<Producto> inventario;

        public Almacen()
        {
            inventario = new List<Producto>();
        }
        public void AdicionarProducto(Producto pProducto)
        {
            inventario.Add(pProducto);
            Console.WriteLine("Adicionamos {0}", pProducto.Nombre);
        }
        // implementación de la interfaz, hacemos la busqueda flexible
        public IEnumerable<Producto> ObtenProductos(int pTipo)
        {
            List<Producto> encontrados = new List<Producto>();

            foreach (Producto p in inventario)
            {
                if (p.Tipo == pTipo)
                    encontrados.Add(p);
            }

            return encontrados;
        }
    }
}
