using System;
using Herencia_y_polimorfismo.MisClases;

class Program
{
    static void Main(string[] args)
    {
        // Crear instancias de cada clase
        Vehiculo vehiculo = new Vehiculo(2026, "Gris", "Porsche");
        AutoDeCombustión miAuto = new AutoDeCombustión(2023, "Negro", "Toyota", 50);
        Motocicleta miMoto = new Motocicleta(2021, "Naranja", "KTM", 2);
        Camión miCamión = new Camión(2020, "Rojo", "Mercedes", 5000);
        CarroElectrico miBYD = new CarroElectrico(2026, "Blanco", "Tesla");

        // Probar métodos de cada clase
        Console.WriteLine("--- Prueba de Vehiculo ---");
        vehiculo.InformacionVehiculo();
        vehiculo.Acelerar(30);
        vehiculo.Frenar();

        Console.WriteLine("\n--- Prueba de AutoDeCombustión ---");
        miAuto.Encender();
        miAuto.Acelerar(20);
        miAuto.Frenar();
        miAuto.CargarCombustible(10);
        miAuto.Apagar();

        Console.WriteLine("\n--- Prueba de Motocicleta ---");
        miMoto.Encender();
        miMoto.Acelerar(30);
        miMoto.Frenar();
        miMoto.CambiarAceite(3);
        miMoto.Apagar();

        Console.WriteLine("\n--- Prueba de Camión ---");
        miCamión.Encender();
        miCamión.CargarMercancia(3000);
        miCamión.Acelerar(10);
        miCamión.Frenar();
        miCamión.Apagar();

        Console.WriteLine("\n--- Prueba de CarroElectrico ---");
        miBYD.InformacionVehiculo();
        miBYD.CargarBateria();
        miBYD.Acelerar(10);
        Console.WriteLine($"El nivel de batería es: {miBYD.NivelBateria()}%");
    }
}