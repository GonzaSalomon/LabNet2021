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
                throw ex;
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
                throw ex;
            }

            //Assert
        }
    }
}