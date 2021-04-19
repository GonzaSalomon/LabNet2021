using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesMateLogica.Exceptions
{
    public class ExcepcionNoSosChuckMaster : Exception
    {
        public ExcepcionNoSosChuckMaster() : base("Hermano, 4 veces te vamos diciendo que solo Chuck Norris puede doblar el 0, no te gastes")
        {

        }

        public static void ThrowChuckException()
        {
            throw new ExcepcionNoSosChuckMaster();
        }
    }
}
