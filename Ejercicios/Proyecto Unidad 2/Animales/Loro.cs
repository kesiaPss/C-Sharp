namespace Animales
{
    class Loro : Aves
    {
        public Loro (string nombre , string colordeplumaje)
        {
            Nombre = nombre; 
            ColorDePlumaje = colordeplumaje;
        

        }
        public void SuHabilidadLoro()
        {
                Hablar = true;
                Volar = true;
                Comer = true;

            if (Nombre == "Perro")
            {
                Hablar = true;
            }
                
        }
    }
}