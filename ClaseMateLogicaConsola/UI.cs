using ClasesMateLogica.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseMateLogicaConsola
{
    public class UI
    {

        public void Dividir_RompeIngresarUnNumero()
        {
            int dividendo = 100;
            try
            {
                dividendo.Dividir();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("\nMensaje de la Excepcion:\n");
                Console.WriteLine(ex.Message);

                Console.WriteLine("\nStackTrace de la Excepcion:\n");
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nMensaje de la Excepcion:\n");
                Console.WriteLine(ex.Message);

                Console.WriteLine("\nStackTrace de la Excepcion:\n");
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("\nLa primera operacion termino \n");
            }
        }
        
        public void Dividir_RompeIngresarDosNumeros()
        {
            int dividendo = 100;
            int divisor = 0;
            try
            {
                dividendo.Dividir(divisor);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("\nSolo Chuck Norris puede dividir por 0!\n");
                Console.WriteLine("\nMensaje de la Excepcion:\n");
                Console.WriteLine(ex.Message);
                Console.WriteLine("\nTipo de la Excepcion:\n");
                Console.WriteLine(ex.GetType());
                Console.WriteLine("\nStackTrace de la Excepcion:\n");
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Seguro ingreso una letra o no ingreso nada!");
                Console.WriteLine("\nMensaje de la Excepcion:\n");
                Console.WriteLine(ex.Message);
                Console.WriteLine("\nTipo de la Excepcion:\n");
                Console.WriteLine(ex.GetType());
                Console.WriteLine("\nStackTrace de la Excepcion:\n");
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("\nLa segunda operacion termino \n");
            }
        }

        public void Logic_ExcepcionEnPresentacion()
        {
            try
            {
                ClasesMateLogica.Logic.Dispara();
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nMensaje de la Excepcion:\n");
                Console.WriteLine(ex.Message);
                Console.WriteLine("\nTipo de la Excepcion:\n");
                Console.WriteLine(ex.GetType());
                Console.WriteLine("\nStackTrace de la Excepcion:\n");
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("\nLa tercera operacion termino \n");
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
                Console.WriteLine("\nMensaje de la Excepcion:\n");
                Console.WriteLine(ex.Message);
                Console.WriteLine("\nTipo de la Excepcion:\n");
                Console.WriteLine(ex.GetType());
                Console.WriteLine("\nStackTrace de la Excepcion:\n");
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("\nLa cuarta operacion termino \n");
            }

        }
    }
}
