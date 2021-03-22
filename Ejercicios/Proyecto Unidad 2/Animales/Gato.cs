namespace Animales
{
    class Gato : Mamiferos 
    {
        public Gato (string nombre, int mumerodepatas )
        {
            Nombre = nombre; 
            NumeroDePatas = 4;
            SuHabilidadGato();
        }
        private void SuHabilidadGato()
        {
            Comer = true;
            Caminar = true;

            if (Nombre == "Gato")
            {
                Maullar = true;
            }
        }
    }
}