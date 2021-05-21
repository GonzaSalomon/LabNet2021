using ClasesMateLogica.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesMateLogica
{
    public class Logic
    {
        public static void Dispara()
        {
            throw new DivideByZeroException();
        }

        public static void LanzaChuck()
        {
            Exceptions.ExcepcionNoSosChuckMaster.ThrowChuckException();
        }

        public void Dividir_RompeIngresarUnNumero()
        {
            int dividendo = 100;
            dividendo.Dividir();

        }

        public void Dividir_RompeIngresarDosNumeros()
        {
            int dividendo = 100;
            int divisor = 0;

            dividendo.Dividir(divisor);
        }


        public void Logic_ExcepcionEnPresentacion()
        {
            try
            {
                ClasesMateLogica.Logic.Dispara();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Logic_ExcepcionPersonalizada()
        {
            try
            {
                ClasesMateLogica.Logic.LanzaChuck();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}