namespace OpenClosedRefactor
{
    class CInventarioMedicamento : CBaseInventario
    {
        public CInventarioMedicamento(CProducto pProducto) : base(pProducto)
        {
        }

        public override double CalcularProducto()
        {
            producto.Precio *= 0.8;
            return producto.Precio;
        }
    }
}
