using Practica.LINQ.Entities;
using Practica.LINQ.Entities.CustomEntities;
using Practica.LINQ.Logic;
using System;
using System.Collections.Generic;

namespace Practica.LINQ.UI
{
    public class StepMenu
    {
        public void StepByStep()
        {
            ShowUI show = new ShowUI();
            CommunicationLogic commu = new CommunicationLogic();
            var query1 = commu.CustomerQueryFull();
            var query2 = commu.ProductsNoStock();
            var query3 = commu.ProductsPlusThreeStock();
            var query4 = commu.CustomersFromWashington();
            var query5 = commu.ProductOrNull();
            var query6 = commu.CustomersToUpperToLow();
            var query7 = commu.CustomersWashington1997();
            var query8 = commu.CustomersTopThreeWashington();
            var query9 = commu.ProductsOrderedByName();
            var query10 = commu.ProductsOrderedByUnitStock();
            var query11 = commu.ProductsAssocitedCategory();
            var query12 = commu.ProducsFirstList();
            var query13 = commu.CustomersCountOrders();

            Console.WriteLine("Este programa muestra por consola las diferentes queries" +
                              " solicitadas.\n\nPresione 'Enter' para continuar");
            Console.ReadLine();


            Console.WriteLine("1 - Objeto cliente:\n");
            show.FullCustomer(query1);
            AskContinue();
            
            Console.WriteLine("2 - Productos sin stock: \n");
            show.ProductBase(query2);
            AskContinue();
            
            Console.WriteLine("3 - Productos en stock y que cuestan más de 3 por unidad: \n");
            show.Product(query3);
            AskContinue();

            Console.WriteLine("4 - Todos los clientes de Washington: \n");
            show.CustomerWashington(query4);
            AskContinue();

            Console.WriteLine("5 - Primer producto con ID 789 o nulo: \n");
            show.FirstOrNull(query5);
            AskContinue();

            Console.WriteLine("6 - Nombres de los clientes: \n");
            show.ToUpperToLower(query6);
            AskContinue();

            Console.WriteLine("7 - Clientes de Washington con ordenes desde 1997: \n");
            show.Customers1997(query7);
            AskContinue();

            Console.WriteLine("8 - Los 3 primeros clientes de Washington: \n");
            show.TopThreeWashington(query8);
            AskContinue();

            Console.WriteLine("9 - Listado de productos ordenados por el nombre: \n");
            show.Product(query9);
            AskContinue();

            Console.WriteLine("10 - Lista de productos ordenados por cantidad en stock de mayor a menor: \n");
            show.Product(query10);
            AskContinue();

            Console.WriteLine("11 - Lista de categorías asociadas a los productos: \n");
            show.ProductAssociatedCategory(query11);
            AskContinue();

            Console.WriteLine("12 - Primer elemento de una lista de productos: \n");
            show.Product(query12);
            AskContinue();

            Console.WriteLine("13 - Clientes con la cantidad de ordenes asociadas: \n");
            show.CustomerCountOrders(query13);

            Console.WriteLine("\n\nPresione 'Enter' para cerrar el programa");
            Console.ReadLine();
            Environment.Exit(0);
        }

        private void AskContinue()
        {
            Console.WriteLine("\n\nPresione 'Enter' para continuar con la siguiente query\n");
            Console.ReadLine();
        }

        
    }
}
