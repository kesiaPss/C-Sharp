namespace Animales
{
    class Perro : Mamiferos
    {
        public Perro (string nombre, int numerodepatas )
        {
            Nombre = nombre; 
            NumeroDePatas = 4;
            SuHabilidadPerro();
        }
        private void SuHabilidadPerro()
        {
            Comer = true;
            Caminar = true;

            if (Nombre == "Perro")
            {
                Ladrar = true;
            }
        }
}

} 