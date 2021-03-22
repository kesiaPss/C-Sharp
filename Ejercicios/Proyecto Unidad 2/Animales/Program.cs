using System;

namespace Animales
{
    class Program
    {
        static void Main(string[] args)
        {
        
        Perro p = new Perro("Perro", 4);
        Console.WriteLine("*****Mamiferos*****");   
        Console.WriteLine(p.Nombre);
        Console.WriteLine("Numero de patas:");
        Console.WriteLine(p.NumeroDePatas);
        Console.WriteLine("Maulla:");
        Console.WriteLine(p.Maullar);
        Console.WriteLine("Ladra:");
        Console.WriteLine(p.Ladrar);
        Console.WriteLine("Come:");
        Console.WriteLine(p.Comer);
        Console.WriteLine("");


        Gato g = new Gato("Gato" , 4);
        Console.WriteLine(g.Nombre);
        Console.WriteLine("Numero de patas:");
        Console.WriteLine(g.NumeroDePatas);
        Console.WriteLine("Ladra:");
        Console.WriteLine(g.Ladrar);
        Console.WriteLine("Maulla:");
        Console.WriteLine(g.Maullar);
        Console.WriteLine("Come:");
        Console.WriteLine(g.Comer);
        Console.WriteLine("");

        
        Mono m = new Mono("Mono", 2);
        Console.WriteLine(m.Nombre);
        Console.WriteLine("Numero de patas:");
        Console.WriteLine(m.NumeroDePatas);
        Console.WriteLine("Ladra:");
        Console.WriteLine(m.Ladrar);
        Console.WriteLine("Maulla:");
        Console.WriteLine(m.Maullar);
        Console.WriteLine("Come:");
        Console.WriteLine(m.Comer);
        Console.WriteLine("");
        


        Aguila a = new Aguila("Aguila","Cafe");
        a.SuHabilidadAguila();
        Console.WriteLine("*****Aves*****");
        Console.WriteLine(a.Nombre);
        Console.WriteLine("Color de plumaje:");
        Console.WriteLine(a.ColorDePlumaje);
        Console.WriteLine("Vuela alto:");
        Console.WriteLine(a.VolarAlto);
        Console.WriteLine("Habla:");
        Console.WriteLine(a.Hablar);
        Console.WriteLine("Come:");
        Console.WriteLine(a.Comer);
        Console.WriteLine("");


        Loro l = new Loro("Loro", "Verde");
        l.SuHabilidadLoro();
        Console.WriteLine(l.Nombre);
        Console.WriteLine("Color de plumaje:");
        Console.WriteLine(l.ColorDePlumaje);
        Console.WriteLine("Vuela:");
        Console.WriteLine(l.Volar);
        Console.WriteLine("Volar alto:");
        Console.WriteLine(l.VolarAlto);
        Console.WriteLine("Habla:");
        Console.WriteLine(l.Hablar);
        Console.WriteLine("Come:");
        Console.WriteLine(l.Comer);
        Console.WriteLine("");


        PezGlobo pg = new PezGlobo("Pez Globo", 4);
        Console.WriteLine("*****Peces*****");
        Console.WriteLine(pg.Nombre);
        Console.WriteLine("Numero de aletas:");
        Console.WriteLine(pg.NumeroDeAletas);
        Console.WriteLine("Inflarse:");
        Console.WriteLine(pg.Inflarse);
        Console.WriteLine("Come:");
        Console.WriteLine(pg.Comer);
        Console.WriteLine("");
        

            
            
    

        


            
            
            
        }
    }
}
