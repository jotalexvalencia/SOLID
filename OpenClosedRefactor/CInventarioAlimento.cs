namespace OpenClosedRefactor
{
    class CInventarioAlimento : CBaseInventario
    {
        public CInventarioAlimento(CProducto pProducto) : base(pProducto)
        {

        }
        public override double CalcularProducto()
        {
            producto.Precio *= 1.2;
            return producto.Precio;
        }
    }
}
