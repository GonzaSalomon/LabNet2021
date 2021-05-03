using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica.LINQ.Logic.Queries;
using Practica.LINQ.Data;

namespace Practica.LINQ.UI
{
    public class StepMenu
    {
        public void StepByStep()
        {
            CustomersQueries customerQ = new CustomersQueries();
            CategoriesQueries categorieQ = new CategoriesQueries();
            OrderQueries orderQ = new OrderQueries();
            ProductsQueries productQ = new ProductsQueries();
            
            Console.WriteLine("Este programa muestra por consola las diferentes queries" +
                              " solicitadas.\n\nPresione 'Enter' para continuar");
            //Console.ReadLine();

            //customerQ.CustomerQueryFull();
            //AskContinue();

            //productQ.ProductsNoStock();
            //AskContinue();

            //productQ.ProductsPlusThreeStock();
            //AskContinue();

            //customerQ.CustomersFromWashington();
            //AskContinue();

            //productQ.ProductOrNull();
            //AskContinue();

            //customerQ.CustomersToUpperToLow();
            //AskContinue();


        }

        public void AskContinue()
        {
            Console.WriteLine("\n\nPresione 'Enter' para continuar con la siguiente query");
            Console.ReadLine();
        }
    }
}
