using Practica.LINQ.Logic;
using System;

namespace Practica.LINQ.UI
{
    public class StepMenu
    {
        public void StepByStep()
        {
            CommunicationLogic commu = new CommunicationLogic();
            
            Console.WriteLine("Este programa muestra por consola las diferentes queries" +
                              " solicitadas.\n\nPresione 'Enter' para continuar");
            Console.ReadLine();

            commu.CustomerQueryFull();
            AskContinue();

            commu.ProductsNoStock();
            AskContinue();

            commu.ProductsPlusThreeStock();
            AskContinue();

            commu.CustomersFromWashington();
            AskContinue();

            commu.ProductOrNull();
            AskContinue();

            commu.CustomersToUpperToLow();
            AskContinue();

            commu.CustomersWashington1997();
            AskContinue();

            commu.CustomersTopThreeWashington();
            AskContinue();

            commu.ProductsOrderedByName();
            AskContinue();

            commu.ProductsOrderedByUnitStock();
            AskContinue();

            commu.ProductsAssocitedCategory();
            AskContinue();

            commu.ProducsFirstList();
            AskContinue();

            commu.CustomersCountOrders();
            Console.WriteLine("\n\nPresione 'Enter para cerrar el programa'");
            Console.ReadLine();
            Environment.Exit(0);
        }

        public void AskContinue()
        {
            Console.WriteLine("\n\nPresione 'Enter' para continuar con la siguiente query\n");
            Console.ReadLine();
        }
    }
}
