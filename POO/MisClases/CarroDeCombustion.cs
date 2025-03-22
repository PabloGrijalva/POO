namespace Herencia_y_polimorfismo.MisClases
{
    public class AutoDeCombustión : Vehiculo
    {
        // Propiedades adicionales
        private int nivelCombustible; // Encapsulación
        private bool encendido; // Encapsulación
        private int velocidad; // Encapsulación

        public AutoDeCombustión(int año, string color, string marca, int combustibleInicial)
            : base(año, color, marca)
        {
            nivelCombustible = combustibleInicial;
            encendido = false;
            velocidad = 0;
        }

        // Métodos adicionales
        public void Encender()
        {
            if (nivelCombustible > 0)
            {
                encendido = true;
                Console.WriteLine("Auto encendido.");
            }
            else
            {
                Console.WriteLine("No hay suficiente combustible para encender el auto.");
            }
        }

        public void Apagar()
        {
            encendido = false;
            velocidad = 0;
            Console.WriteLine("Auto apagado.");
        }

        public void CargarCombustible(int cantidad)
        {
            nivelCombustible += cantidad;
            Console.WriteLine($"Combustible cargado. Nivel actual: {nivelCombustible} litros.");
        }

        // Sobrescribir métodos de la clase base
        public override void Frenar()
        {
            if (velocidad > 0)
            {
                velocidad -= 10;
                nivelCombustible -= 1; // Gastar combustible al frenar
                Console.WriteLine($"Frenando... Velocidad actual: {velocidad} km/h. Combustible restante: {nivelCombustible} litros.");
            }
            else
            {
                Console.WriteLine("El auto ya está detenido.");
            }
        }

        public override void Acelerar(int cuanto)
        {
            if (encendido && nivelCombustible > 0)
            {
                velocidad += cuanto;
                nivelCombustible -= 2; // Gastar combustible al acelerar
                Console.WriteLine($"Acelerando... Velocidad actual: {velocidad} km/h. Combustible restante: {nivelCombustible} litros.");
            }
            else
            {
                Console.WriteLine("No se puede acelerar. Verifique si el auto está encendido o si hay combustible.");
            }
        }
    }
}