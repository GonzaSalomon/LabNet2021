using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeterminarTransporte
{
    public class Avion : Transporte
    {
        public Avion(int cantidadPasajeros) : base(cantidadPasajeros)
        {

        }
        public override string Avanzar(int kilometros, int posicion)
        {
            return $"El {posicion}º avión avanzó {kilometros} kilómetros.";
        }

        public override string Detenerse(int posicion)
        {
            return $"El {posicion}º avión se detuvo con {GetCantidadPasajeros()} pasajeros.\n";
        }
    }
}