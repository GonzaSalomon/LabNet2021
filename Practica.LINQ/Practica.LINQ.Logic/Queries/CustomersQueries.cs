using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica.LINQ.Entities;
using Practica.LINQ.Data;

namespace Practica.LINQ.Logic.Queries
{
    public class CustomersQueries
    {
        NorthwindContext db = new NorthwindContext();

        public void CustomerQueryFull()
        {
            Console.WriteLine("1 - Objeto cliente:\n");

            var queryFullCustomer = db.Customers
                                      .Take(1)
                                      .Select(c => c)
                                      .ToList();        

            foreach (Customers customer in queryFullCustomer)
            {
                Console.WriteLine($"ID: {customer.CustomerID}\n   Compañía: {customer.CompanyName}\n   Nombre de contacto: " +
                                  $"{customer.ContactName} \n   Titulo de contacto: {customer.ContactTitle} \n   Dirección: " +
                                  $"{customer.Address} \n   Ciudad: {customer.City}, {customer.Region} - {customer.Country}\n   Códi" +
                                  $"go postal: {customer.PostalCode} \n   Nº de teléfono: {customer.Phone} - Nº de fax: {customer.Fax}");
            }
        }

        public void CustomersFromWashington()
        {
            Console.WriteLine("4 - Todos los clientes de Washington: \n");

            var queryFromWashington = db.Customers
                                        .Where(c => c.Region == "WA")
                                        .Select(c => new
                                        {
                                            c.CustomerID,
                                            c.ContactName,
                                            c.Address,
                                            c.City,
                                            c.PostalCode
                                        });

            foreach (var customer in queryFromWashington)
            {
                Console.WriteLine($"ID: {customer.CustomerID}\t Nombre: {customer.ContactName}\n   Dirección: {customer.Address}" +
                                  $", {customer.City}\t Código postal: {customer.PostalCode}");
            }
        }

        public void CustomersToUpperToLow()
        {
            Console.WriteLine("6 - Nombres de los clientes: \n");

            var queryTuUpperToLow = db.Customers
                                      .Select(c => new
                                      {
                                          c.ContactName
                                      });
            foreach (var customer in queryTuUpperToLow)
            {
                Console.WriteLine($"En mayúscula: {customer.ContactName.ToUpper()} " +
                    $"\t- En minúsculas: {customer.ContactName.ToLower()}");
            }
        }

        public void CustomersWashington1997()
        {
            Console.WriteLine("7 - Clientes de Washington con ordenes desde 1997: \n");

            var queryCustomers1997 = from customer in db.Customers
                                        join order in db.Orders
                                        on new { customer.CustomerID }
                                            equals new { CustomerID = order.CustomerID }
                                     where customer.Region == "WA"
                                        && order.OrderDate >= Convert.ToDateTime(01/01/1997)
                                     select new
                                     {
                                        customer.CustomerID,
                                        customer.ContactName,
                                        customer.
                                     };
        }

        public void CustomersTopThreeWashington()
        {

        }
    }
}
