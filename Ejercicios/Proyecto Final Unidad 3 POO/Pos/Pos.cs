using System;
using System.Collections.Generic;

public class ProyectoFinalUnidad3_POO
{
    public List<Vendedor> ListadeVendedor{ get; set; }
    public List<Producto> ListadeProductos { get; set; }
    public List<Cliente> ListadeClientes { get; set; }
    public List<Venta> ListaVenta { get; set; }
    public ProyectoFinalUnidad3_POO()
    {
      ListadeProductos = new List<Producto>();
        cargarProductos();

        ListadeClientes = new List<Cliente>();
        cargarClientes();

        ListadeVendedor = new List<Vendedor>();
        cargarVendedor();

        ListaVenta = new List<Venta>();
    }

    private void cargarVendedor()
    {
        Vendedor v1 = new Vendedor(501, "Gadiel Ramos   ", "501");
        ListadeVendedor.Add(v1);

        Vendedor v2 = new Vendedor(502, "Sergio Peralta ", "502");
        ListadeVendedor.Add(v2);
        
        Vendedor v3 = new Vendedor(503, "Erika Sosa     ", "503");
        ListadeVendedor.Add(v3);

        Vendedor v4 = new Vendedor(504, "Pedro Santos    ", "504");
        ListadeVendedor.Add(v4);
    }

    private void cargarProductos()
    {
        
        Producto p1 = new Producto("1",   "Xioami Redmi note 8    ",190);
        ListadeProductos.Add(p1);

        Producto p2 = new Producto("2",   "Xioami Redmi Note 8 Pro",210);
        ListadeProductos.Add(p2);

        Producto p3 = new Producto("3",   "Xiaomi Redmi 9A        ",230);
        ListadeProductos.Add(p3);

        Producto p4 = new Producto("4",   "Xiaomi Redmi Note 9 Pro",250);
        ListadeProductos.Add(p4);

        Producto p5 = new Producto("5",   "Xiaomi Mi 10           ",400);
        ListadeProductos.Add(p5);

        Producto p6 = new Producto("6",   "Xiaomi Mi 10 Lite      ",450);
        ListadeProductos.Add(p6);

        Producto p7 = new Producto("7",   "Xiaomi Mi MIX 3        ",300);
        ListadeProductos.Add(p7);

        Producto p8 = new Producto("8",   "Xiaomi Mi 10T          ",220);
        ListadeProductos.Add(p8);

        Producto p9 = new Producto("9",   "Xiaomi A4              ",155);
        ListadeProductos.Add(p9);

    }


    private void cargarClientes()
    {
        Cliente c1 = new Cliente(1, "Kesia Peralta    ","96308636");
        ListadeClientes.Add(c1);

        Cliente c2 = new Cliente(2, "Megan Ramos      ","95307657 ");
        ListadeClientes.Add(c2);

        Cliente c3 = new Cliente(3, "Reina Martinez   ","98056401");
        ListadeClientes.Add(c3);

        Cliente c4 = new Cliente(4, "Paola Madrid     ","31456799 ");
        ListadeClientes.Add(c4);

        Cliente c5 = new Cliente(5, "Allison Pavon    ","98970022");
        ListadeClientes.Add(c5);
    }
 public void ListarProductos()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Clear();
        Console.WriteLine("         Listado de Productos         ");
        Console.WriteLine("           Xiaomi Honduras        ");
        Console.WriteLine("*******************************************************************");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Código |          Producto               |   $ Precio    ");
        Console.WriteLine("");
    
        
        foreach (var producto in ListadeProductos)
        {
            Console.WriteLine(producto.Codigo + "      |         "             + producto.Descripcion + " |       " + producto.Precio );
        } 

        Console.ReadLine();
    }


    public void ListarClientes()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Clear();
        Console.WriteLine("         Listado de Clientes        ");
        Console.WriteLine("          Xiaomi Honduras      ");
        Console.WriteLine("************************************");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Código|        Cliente       | Teléfono");
        Console.WriteLine("");
        
        foreach (var cliente in ListadeClientes)
        {
            Console.WriteLine(cliente.Codigo + "     |    " + cliente.Nombre + " | " + cliente.Telefono);
        }

        Console.ReadLine();
    }

    public void ListarVendedores()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Clear();
        Console.WriteLine("   Listado de Vendedores   ");
        Console.WriteLine("  Xiaomi Honduras   ");
        Console.WriteLine("**************************");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Código |    Vendedores  ");
        Console.WriteLine("");
        
        foreach (var vendedor in ListadeVendedor)
        {
            Console.WriteLine(vendedor.Codigo + "    | " + vendedor.Nombre + "" );
        }

        Console.ReadLine();

    }
     public void CrearVenta()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Clear();
        Console.WriteLine("                 Ingreso de Ventas                          ");
        Console.WriteLine("                  Xioami Honduras                          ");
        Console.WriteLine("************************************************************");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("");

         Console.WriteLine("Ingrese el codigo de Vendedor: ");
        string codigoVendedor = Console.ReadLine();

        Vendedor vendedor = ListadeVendedor.Find(v => v.Codigo.ToString() == codigoVendedor);
        if (vendedor == null) 
        {
            Console.WriteLine("Vendedor no encontrado");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Vendedor: " + vendedor.Nombre);
            Console.WriteLine("");
        }

        Console.WriteLine("Ingrese el codigo del cliente: ");
        string codigoCliente = Console.ReadLine();

        Cliente cliente = ListadeClientes.Find(c => c.Codigo.ToString() == codigoCliente);        
        if (cliente == null)
        {
            Console.WriteLine("Cliente no encontrado");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Cliente: " + cliente.Nombre);
            Console.WriteLine("");
        }

       

        int nuevoCodigo = ListaVenta.Count + 1;

        Venta nuevaVenta = new Venta(nuevoCodigo, DateTime.Now, "Puerto Cortes, Cortes" + nuevoCodigo, cliente, vendedor);
        ListaVenta.Add(nuevaVenta);

        while(true)
        {
            Console.WriteLine("Ingrese el codigo del producto: ");
            string codigoProducto = Console.ReadLine();
            Producto producto = ListadeProductos.Find(p => p.Codigo.ToString() == codigoProducto);   

            if (producto == null)
            {
                Console.WriteLine("Producto no encontrado");
                Console.ReadLine();
            } else {
                Console.WriteLine("Producto agregado: " + producto.Descripcion +    "   con precio de: " + producto.Precio);
                nuevaVenta.AgregarProducto(producto);
            }

            Console.WriteLine("Desea agregar otro producto? si/no");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() == "n") {
                break;

            
            }
        }
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("");
        Console.WriteLine("Subtotal de la venta es de: " + nuevaVenta.Subtotal);
        Console.WriteLine("Impuesto de la venta es de: " + nuevaVenta.Impuesto);
        Console.WriteLine("Total de la venta es de:    " + nuevaVenta.Total);
        Console.ReadLine();
    }
    
    public void ListarVentas()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Clear();
        Console.WriteLine("                                                    Reporte de Ventas                                                  ");
        Console.WriteLine("                                                     Xiaomi Honduras "                                                );
        Console.WriteLine("***********************************************************************************************************************************");
        Console.WriteLine("");  
        Console.WriteLine("Codigo |Fecha                   |Producto                     |Cantidad|Precio|Subtotal|Impuesto|Total |Cliente           |Vendedor");
        Console.WriteLine("***********************************************************************************************************************************");
        Console.WriteLine("");  
        Console.ForegroundColor = ConsoleColor.White;

        foreach (var venta in ListaVenta)
        foreach (var detalle in venta.ListaVentaDetalle)
        {
            Console.WriteLine(venta.Codigo + "      | " + venta.Fecha + "   |  " + detalle.Producto.Descripcion + "   |   " + detalle.Cantidad +  "    | "  + detalle.Precio + "  | " + venta.Subtotal + "   |  " + venta.Impuesto + "   |  " + venta.Total + " | "+ venta.Cliente.Nombre +"| " + venta.Vendedor.Nombre); 
            Console.WriteLine();
        } 

        Console.ReadLine();
    }

    

}