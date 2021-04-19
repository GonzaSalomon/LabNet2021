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
    }
}