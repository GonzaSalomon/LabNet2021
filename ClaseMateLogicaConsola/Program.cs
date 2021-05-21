using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseMateLogicaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            UI arranca = new UI();
            arranca.Dividir_RompeIngresarUnNumero();
            arranca.Dividir_RompeIngresarDosNumeros();
            arranca.Logic_ExcepcionEnPresentacion();
            arranca.Logic_ExcepcionPersonalizada();
            Console.ReadLine();
        }
}
}
