using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DeterminarTransporte
{
    class Program
    {
        static void Main(string[] args)
        {
            int posicion = 1;
            int posicionVehiculo = 0;
            var rand = new Random();
            List<Transporte> transportes = new List<Transporte>
            {
                new Avion(100),
                new Avion(30),
                new Avion(10),
                new Avion(301),
                new Avion(345),
                new Automovil(4),
                new Automovil(2),
                new Automovil(1),
                new Automovil(6),
                new Automovil(2)
            };
            foreach (var item in transportes)
            {
                if (posicion <= 5)
                {
                    posicionVehiculo = posicion;
                }
                else
                {
                    posicionVehiculo = posicion - 5;
                }
                int distanciaRecorrida = rand.Next(15, 90);
                Console.WriteLine(item.Avanzar(distanciaRecorrida, posicionVehiculo));
                Console.WriteLine(item.Detenerse(posicionVehiculo));
                posicion += 1;
            }

            Console.ReadLine();
        }
    }
}
