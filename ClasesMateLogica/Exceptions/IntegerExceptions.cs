using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesMateLogica.Exceptions
{
    public class IntegerExceptions
    {
        public int ExcepcionDivision(int dividendo)
        {
            try
            {
                int valor = dividendo / 0;
                return valor;
            }
            catch (DivideByZeroException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int ExcepcionDivision(int dividendo, int divisor)
        {
            try
            {
                int cociente = dividendo / divisor;
                return cociente;
            }
            catch (DivideByZeroException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
