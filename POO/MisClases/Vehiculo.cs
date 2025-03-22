using System;

namespace Herencia_y_polimorfismo.MisClases
{
    public class Vehiculo
    {
        // Propiedades
        public int Año { get; set; }
        public string Color { get; set; }
        public string Marca { get; set; }

        // Constructor
        public Vehiculo(int año, string color, string marca)
        {
            Año = año;
            Color = color;
            Marca = marca;
        }

        // Métodos que pueden ser sobrescritos
        public virtual void Acelerar(int cuanto)
        {
            Console.WriteLine($"Acelerando el vehículo {Marca} en {cuanto} km/h.");
        }

        public virtual void Frenar()
        {
            Console.WriteLine($"Frenando el vehículo {Marca}.");
        }

        public void InformacionVehiculo()
        {
            Console.WriteLine($"Marca: {Marca}, Color: {Color}, Año: {Año}");
        }
    }
}