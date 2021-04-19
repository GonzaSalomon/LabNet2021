using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesMateLogica.Exceptions
{
    public class IntegerExceptions
    {
        public static int ExcepcionDivision(int dividendo)
        {
            try
            {
                int valor = dividendo / 0;
                return valor;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Mensaje de la Excepcion:");
                Console.WriteLine(ex.Message);

                Console.WriteLine("StackTrace de la Excepcion:");
                Console.WriteLine(ex.StackTrace);
                throw ex;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Mensaje de la Excepcion:");
                Console.WriteLine(ex.Message);

                Console.WriteLine("StackTrace de la Excepcion:");
                Console.WriteLine(ex.StackTrace);
                throw ex;
            }
            finally
            {
                Console.WriteLine("La primera operacion termino \n");
            }
        }
        public static int ExcepcionDivision(int dividendo, int divisor)
        {
            try
            {
                int cociente = dividendo / divisor;
                return cociente;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Solo Chuck NEORRIS(? puede dividir por 0!");
                Console.WriteLine("Mensaje de la Excepcion:");
                Console.WriteLine(ex.Message);
                Console.WriteLine("StackTrace de la Excepcion:");
                Console.WriteLine(ex.StackTrace);
                throw ex;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Seguro ingreso una letra o no ingreso nada!");
                Console.WriteLine("Mensaje de la Excepcion:");
                Console.WriteLine(ex.Message);
                Console.WriteLine("StackTrace de la Excepcion:");
                Console.WriteLine(ex.StackTrace);
                throw ex;
            }
            finally
            {
                Console.WriteLine("La segunda operacion termino \n");
            }
        }
    }
}
