using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeterminarTransporte
{
    public class Avion : Transporte, IVehiculoAereo
    {
        public Avion(int cantidadPasajeros) : base(cantidadPasajeros)
        {

        }
        public override string Avanzar(int kilometros, int posicion)
        {
            return $"El {posicion}º avión avanzó {kilometros} kilómetros.";
        }

        public void CantidadTurbinas()
        {

            var rand = new Random();
            int[] arrayTurbinas = new int[2] { 2, 4 };
            int turbinas = arrayTurbinas[rand.Next(0,2)];
            Console.WriteLine($"El vehículo aereo posee {turbinas} turbinas.");
        }

        public override string Detenerse(int posicion)
        {
            this.CantidadTurbinas();
            return $"El {posicion}º avión se detuvo con {GetCantidadPasajeros()} pasajeros.\n";
        }
    }
}