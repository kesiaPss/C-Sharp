namespace Animales
{
    class Mono : Mamiferos 
    {
        public Mono(string nombre , int NumeroDepatas)
        {
            Nombre = nombre;
             NumeroDePatas = 4;

        }
        public void SuHabilidadMono()
        {
            Comer = true;
            Caminar = true;

            if (Nombre == "Mono")
            {
                Maullar = true;
        }
    }
 }
}
