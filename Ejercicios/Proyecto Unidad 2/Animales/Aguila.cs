namespace Animales
{
    class Aguila: Aves
    {
        public Aguila (string nombre, string colordeplumaje )
        {
            Nombre = nombre; 
            ColorDePlumaje = colordeplumaje;
        }
        public void SuHabilidadAguila()
        {
            VolarAlto = true;
            Comer = true;

            if (Nombre == "Perro")
            {
                VolarAlto= true;
            }
        }
    }
}