namespace Animales
{
    class Mono : Mamiferos 
    {
        public Mono(string nombre , int NumeroDepatas)
        {
            Nombre = nombre;
             NumeroDePatas = 4;
             SuHabilidadMono();

        }
        private void SuHabilidadMono()
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
