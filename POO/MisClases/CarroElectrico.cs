namespace Herencia_y_polimorfismo.MisClases
{
    public class CarroElectrico : Vehiculo
    {
        private int cargaBateria;

        public CarroElectrico(int año, string color, string marca)
            : base(año, color, marca)
        {
            cargaBateria = 50;
        }

        public override void Acelerar(int cuanto)
        {
            base.Acelerar(cuanto);
            cargaBateria--;
            Console.WriteLine($"Batería restante: {cargaBateria}%");
        }

        public int NivelBateria()
        {
            return cargaBateria;
        }

        public void CargarBateria()
        {
            cargaBateria++;
            Console.WriteLine($"Batería cargada. Nivel actual: {cargaBateria}%");
        }
    }
}