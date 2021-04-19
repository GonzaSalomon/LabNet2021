using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesMateLogica.Extensions
{
    public static class IntegerExtensions
    {
        public static void Dividir(this int numero)
        {
            Exceptions.IntegerExceptions.ExcepcionDivision(numero);
        }

        public static void Dividir(this int numero, int divisor)
        {
            Exceptions.IntegerExceptions.ExcepcionDivision(numero, divisor);
        }


    }
}