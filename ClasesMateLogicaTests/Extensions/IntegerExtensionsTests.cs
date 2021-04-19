using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClasesMateLogica.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesMateLogica.Extensions.Tests
{
    [TestClass()]
    public class IntegerExtensionsTests
    {
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Dividir_RompeIngresarUnNumero()
        {
            //Arrange
            int dividendo = 100;

            //Act
            dividendo.Dividir();

            //Assert
        }

        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Dividir_RompeIngresarDosNumeros()
        {

            //Arrange
            int dividendo = 100;
            int divisor = 0;


            //Act
            dividendo.Dividir(divisor);

            //Assert
        }


    }


}