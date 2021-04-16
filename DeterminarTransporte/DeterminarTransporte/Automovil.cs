using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeterminarTransporte
{
    public class Automovil : Transporte
    {
        public Automovil(int cantidadPasajeros) : base(cantidadPasajeros)
        {

        }
        public override string Avanzar(int kilometros, int posicion)
        {
            return $"El {posicion}º automóvil avanzó {kilometros} kilómetros.";
        }

        public override string Detenerse(int posicion)
        {
            return $"El {posicion}º automóvil se detuvo con {GetCantidadPasajeros()} pasajeros.\n";
        }
    }
}
