namespace Animales
{
    class PezGlobo : Peces
    {
        public PezGlobo (string nombre, int  numerodealetas )
        {
            Nombre = nombre; 
            NumeroDeAletas = numerodealetas;
            SuHabilidadPezGlobo();
        }
        private void SuHabilidadPezGlobo()
        {
            Inflarse = true;
            Comer = true;

            if (Nombre == "Pez Globo")
            {
                Inflarse = true;
                
            }
        }
    }
}