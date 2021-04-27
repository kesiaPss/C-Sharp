public class Producto
{
    public string Codigo { get; set; }
    public string Descripcion { get; set; }
    public double Precio { get; set; }

    

    public Producto(string codigo, string descripcion, double precio)
    {
        Codigo = codigo;
        Descripcion = descripcion;
        Precio = precio;
    


    }
}