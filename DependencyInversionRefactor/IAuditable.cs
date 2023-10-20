using System.Collections.Generic;

namespace DependencyInversionRefactor
{
    interface IAuditable
    {
        IEnumerable<Producto> ObtenProductos(int pTipo);
    }
}
