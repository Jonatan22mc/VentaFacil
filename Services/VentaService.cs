public class VentaService
{
    /// <summary>
    /// Calcula el total de una venta (RF-04): precio * cantidad.
    /// </summary>
    public decimal CalcularTotal(decimal precio, int cantidad)
    {
        return precio * cantidad;
    }
}