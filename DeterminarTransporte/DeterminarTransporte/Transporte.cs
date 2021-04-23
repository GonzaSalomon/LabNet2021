using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeterminarTransporte
{
    interface IVehiculoAereo
    {
        void CantidadTurbinas();
    }
    public abstract class Transporte
    {
        private int cantidadPasajeros;

        public int GetCantidadPasajeros()
        {
            return cantidadPasajeros;
        }

        private void SetCantidadPasajeros(int value)
        {
            cantidadPasajeros = value;
        }

        public Transporte (int pasajeros)
        {
            this.SetCantidadPasajeros(pasajeros);
        }

        public abstract string Avanzar(int kilometros, int posicion);

        public abstract string Detenerse(int posicion);
        
    }
}
