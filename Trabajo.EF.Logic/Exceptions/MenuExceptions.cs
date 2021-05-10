using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo.EF.Logic.Exceptions
{
    public class MenuExceptions
    {
        public static int ExceptionSwitch()
        {
            try
            {
                int optionMenu = Convert.ToInt32(Console.ReadLine());
                return optionMenu;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
