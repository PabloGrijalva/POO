namespace Herencia_y_polimorfismo.MisClases
{
    public class Motocicleta : Vehiculo
    {
        // Propiedades adicionales
        private bool encendida; // Encapsulación
        private int velocidad; // Encapsulación
        private int nivelAceite; // Encapsulación

        public Motocicleta(int año, string color, string marca, int aceiteInicial)
            : base(año, color, marca)
        {
            encendida = false;
            velocidad = 0;
            nivelAceite = aceiteInicial;
        }

        // Métodos adicionales
        public void Encender()
        {
            if (nivelAceite > 0)
            {
                encendida = true;
                Console.WriteLine("Motocicleta encendida.");
            }
            else
            {
                Console.WriteLine("No hay suficiente aceite para encender la motocicleta.");
            }
        }

        public void Apagar()
        {
            encendida = false;
            velocidad = 0;
            Console.WriteLine("Motocicleta apagada.");
        }

        public void CambiarAceite(int cantidad)
        {
            nivelAceite = cantidad;
            Console.WriteLine($"Aceite cambiado. Nivel actual: {nivelAceite} litros.");
        }

        // Sobrescribir métodos de la clase base
        public override void Frenar()
        {
            if (velocidad > 0)
            {
                velocidad -= 15;
                Console.WriteLine($"Frenando... Velocidad actual: {velocidad} km/h.");
            }
            else
            {
                Console.WriteLine("La motocicleta ya está detenida.");
            }
        }

        public override void Acelerar(int cuanto)
        {
            if (encendida && nivelAceite > 0)
            {
                velocidad += cuanto;
                Console.WriteLine($"Acelerando... Velocidad actual: {velocidad} km/h.");
            }
            else
            {
                Console.WriteLine("No se puede acelerar. Verifique si la motocicleta está encendida o si hay aceite.");
            }
        }
    }
}