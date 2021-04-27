using System;

namespace Pos
{
    class Program
    {
        static void Main(string[] args)
        {
             string opcion = "";
            ProyectoFinalUnidad3_POO pos = new ProyectoFinalUnidad3_POO();

            while (true)
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("          SISTEMA DE POS            ");
                Console.WriteLine("          XIOAMI HONDURAS           ");
                Console.WriteLine("========================================");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1 - Listado de Clientes");
                Console.WriteLine("2 - Listado de Productos");
                Console.WriteLine("3 - Listado de Vendedores");
                Console.WriteLine("4 - Ingreso de venta");
                Console.WriteLine("5 - Reporte de ventas");
                Console.WriteLine("");
                Console.WriteLine("0 - Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": 
                        pos.ListarClientes();
                        break;
                    
                    case "2": 
                        pos.ListarProductos();
                        break;
                    
                    case "3": 
                        pos.ListarVendedores();
                        break;
                    
                    case "4": 
                        pos.CrearVenta();
                        break;

                    case "5": 
                        pos.ListarVentas();
                        break;
                                
                    default:
                    break;
                }

                if (opcion == "0") {
                    break;
                }
            }            
        }
    }
}