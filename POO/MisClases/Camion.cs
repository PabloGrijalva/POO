namespace Herencia_y_polimorfismo.MisClases
{
    public class Camión : Vehiculo
    {
        // Propiedades adicionales
        private int cargaActual; // Encapsulación
        private int capacidadCarga; // Encapsulación
        private bool encendido; // Encapsulación

        public Camión(int año, string color, string marca, int capacidad)
            : base(año, color, marca)
        {
            cargaActual = 0;
            capacidadCarga = capacidad;
            encendido = false;
        }

        // Métodos adicionales
        public void Encender()
        {
            encendido = true;
            Console.WriteLine("Camión encendido.");
        }

        public void Apagar()
        {
            encendido = false;
            Console.WriteLine("Camión apagado.");
        }

        public void CargarMercancia(int peso)
        {
            if (cargaActual + peso <= capacidadCarga)
            {
                cargaActual += peso;
                Console.WriteLine($"Mercancía cargada. Carga actual: {cargaActual} kg.");
            }
            else
            {
                Console.WriteLine("No se puede cargar más mercancía. Capacidad máxima alcanzada.");
            }
        }

        // Sobrescribir métodos de la clase base
        public override void Frenar()
        {
            if (encendido)
            {
                Console.WriteLine("Frenando el camión...");
            }
            else
            {
                Console.WriteLine("El camión está apagado. No se puede frenar.");
            }
        }

        public override void Acelerar(int cuanto)
        {
            if (encendido)
            {
                Console.WriteLine($"Acelerando el camión en {cuanto} km/h.");
            }
            else
            {
                Console.WriteLine("El camión está apagado. No se puede acelerar.");
            }
        }
    }
}