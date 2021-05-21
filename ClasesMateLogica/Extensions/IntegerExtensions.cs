using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesMateLogica.Exceptions;

namespace ClasesMateLogica.Extensions
{
    public static class IntegerExtensions
    {
        static IntegerExceptions integerExc = new IntegerExceptions();

        public static void Dividir(this int numero)
        {

            integerExc.ExcepcionDivision(numero);
        }

        public static void Dividir(this int numero, int divisor)
        {
            integerExc.ExcepcionDivision(numero, divisor);
        }


    }
}