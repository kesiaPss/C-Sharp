namespace Animales
{
    class PezGlobo : Peces
    {
        public PezGlobo (string nombre, int  numerodealetas )
        {
            Nombre = nombre; 
            NumeroDeAletas = numerodealetas;
        }
        public void SuHabilidadPezGlobo()
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