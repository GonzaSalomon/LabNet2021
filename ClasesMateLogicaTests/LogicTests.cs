using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClasesMateLogica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesMateLogica.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Logic_ExcepcionEnPresentacion()
        {
            //Arrange

            //Act
            try
            {
                ClasesMateLogica.Logic.Dispara();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Mensaje de la Excepcion:");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tipo de la Excepcion:");
                Console.WriteLine(ex.GetType());
                Console.WriteLine("StackTrace de la Excepcion:");
                Console.WriteLine(ex.StackTrace);
                throw ex;
            }
            finally
            {
                Console.WriteLine("La tercera operacion termino \n");
            }

            //Assert
        }

        [TestMethod()]
        [ExpectedException(typeof(ClasesMateLogica.Exceptions.ExcepcionNoSosChuckMaster))]
        public void Logic_ExcepcionPersonalizada()
        {
            //Arrange

            //Act
            try
            {
                ClasesMateLogica.Logic.LanzaChuck();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Mensaje de la Excepcion:");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Tipo de la Excepcion:");
                Console.WriteLine(ex.GetType());
                Console.WriteLine("StackTrace de la Excepcion:");
                Console.WriteLine(ex.StackTrace);
                throw ex;
            }

            //Assert
        }
    }
}