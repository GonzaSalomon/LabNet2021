using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo.EF.Logic.Exceptions
{
    public class InsertException
    {
        public static int ExceptionInt()
        {
            try
            {
                int productInt = Convert.ToInt32(Console.ReadLine());
                return productInt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string ExceptionString()
        {
            try
            {
                string productString = Console.ReadLine();
                return productString;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Mensaje de error: " + ex.Message);
                Console.WriteLine("StackTrace" + ex.StackTrace);
                throw ex;
            }
        }

        public static short ExceptionSmallInt()
        {
            try
            {
                short productSmallInt = Convert.ToInt16(Console.ReadLine());
                return productSmallInt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Mensaje de error: " + ex.Message);
                Console.WriteLine("StackTrace" + ex.StackTrace);
                throw ex;
            }
        }
    }
}
