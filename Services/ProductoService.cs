public class ProductoService
{
    public bool PrecioValido(decimal precio)
    {
        return precio > 0;
    }
}