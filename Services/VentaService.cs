// Services/VentaService.cs   (RF-04)
public class VentaService
{
    public decimal CalcularTotal(decimal precio, int cantidad)
    {
        return precio * cantidad;
    }
}
