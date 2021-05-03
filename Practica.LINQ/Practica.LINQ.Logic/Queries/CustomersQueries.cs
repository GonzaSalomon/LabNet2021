using Practica.LINQ.Data;
using Practica.LINQ.Entities;
using Practica.LINQ.Entities.CustomEntities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Practica.LINQ.Logic.Queries
{
    public class CustomersQueries
    {
        NorthwindContext db = new NorthwindContext();

        public List<Customers> CustomerQueryFull()
        {
            Console.WriteLine("1 - Objeto cliente:\n");

            var queryFullCustomer = db.Customers
                                      .Take(1)
                                      .Select(c => c)
                                      .ToList();        

            foreach (Customers customer in queryFullCustomer)
            {
                Console.WriteLine($"ID: {customer.CustomerID}\n   " +
                                  $"Compañía: {customer.CompanyName}\n   " +
                                  $"Nombre de contacto: {customer.ContactName}\n   " +
                                  $"Titulo de contacto: {customer.ContactTitle}\n   " +
                                  $"Dirección: {customer.Address}\n   " +
                                  $"Ciudad: {customer.City}, {customer.Region} - {customer.Country}\n   " +
                                  $"Código postal: {customer.PostalCode}\n   " +
                                  $"Nº de teléfono: {customer.Phone} - Nº de fax: {customer.Fax}");
            }

            return queryFullCustomer;
        }

        public List<CustomerWashington> CustomersFromWashington()
        {
            Console.WriteLine("4 - Todos los clientes de Washington: \n");

            var queryFromWashington = db.Customers
                                        .Where(c => c.Region == "WA")
                                        .Select(c => new CustomerWashington()
                                        {
                                            CustomerID = c.CustomerID,
                                            ContactName = c.ContactName,
                                            Address = c.Address,
                                            City = c.City,
                                            PostalCode = c.PostalCode
                                        })
                                        .ToList();

            foreach (var customer in queryFromWashington)
            {
                Console.WriteLine($"ID: {customer.CustomerID}\t " +
                                  $"Nombre: {customer.ContactName}\n   " +
                                  $"Dirección: {customer.Address}, {customer.City}\t " +
                                  $"Código postal: {customer.PostalCode}");
            }

            return queryFromWashington;
        }

        public List<CustomersName> CustomersToUpperToLow()
        {
            Console.WriteLine("6 - Nombres de los clientes: \n");

            var queryToUpperToLow = db.Customers
                                      .Select(c => new CustomersName()
                                      {
                                          ContactName = c.ContactName
                                      });
            foreach (var customer in queryToUpperToLow)
            {
                Console.WriteLine($"En mayúscula: {customer.ContactName.ToUpper()} \t- " +
                                  $"En minúsculas: {customer.ContactName.ToLower()}");
            }

            return queryToUpperToLow.ToList();
        }

        public List<CustomersOrders> CustomersWashington1997()
        {
            Console.WriteLine("7 - Clientes de Washington con ordenes desde 1997: \n");

            DateTime year = new DateTime(1997, 01, 01);
            var queryWa1997 = from customer in db.Customers
                              join order in db.Orders
                              on new { customer.CustomerID }
                                  equals new { CustomerID = order.CustomerID }
                              where customer.Region == "WA"
                                  && order.OrderDate >= year
                              select new CustomersOrders()
                              {
                                  CustomerID = customer.CustomerID,
                                  ContactName = customer.ContactName,
                                  OrderID = order.OrderID,
                                  ShippedDate = order.ShippedDate,
                                  ShipAddress = order.ShipAddress,
                                  ShipCity = order.ShipCity,
                                  ShipPostalCode = order.ShipPostalCode
                              };

            foreach (var item in queryWa1997)
            {
                Console.WriteLine($"Id del cliente: {item.CustomerID} - " +
                                  $"Nombre: {item.ContactName}\n   " +
                                  $"Id de la orden: {item.OrderID} - " +
                                  $"Fecha de envío: {item.ShippedDate}\n   " +
                                  $"Dirección de entrega: {item.ShipAddress}, {item.ShipCity} - " +
                                  $"Código postal: {item.ShipPostalCode}");
            }

            return queryWa1997.ToList();
        }

        public List<CustomersTop> CustomersTopThreeWashington()
        {
            Console.WriteLine("8 - Los 3 primeros clientes de Washington: \n");

            var queryTopThree = db.Customers
                                  .Where(c => c.Region == "WA")
                                  .Select(c => new CustomersTop()
                                  {
                                      CustomerID = c.CustomerID,
                                      ContactName = c.ContactName,
                                      Address = c.Address,
                                      City = c.City,
                                      PostalCode = c.PostalCode,
                                      Phone = c.Phone
                                  })
                                  .Take(3)
                                  .ToList();

            foreach (var customer in queryTopThree)
            {
                Console.WriteLine($"ID: {customer.CustomerID} - " +
                                  $"Nombre: {customer.ContactName} - " +
                                  $"Teléfono: {customer.Phone}\n   " +
                                  $"Dirección: {customer.Address}, {customer.City} - " +
                                  $"Código postal: {customer.PostalCode}");
            }

            return queryTopThree;
        }

        public List<Customers> CustomersCountOrders()
        {
            Console.WriteLine("13 - Clientes con la cantidad de ordenes asociadas: \n");

            var queryCustomers = from customer in db.Customers
                                 select customer;

            

            foreach (var customer in queryCustomers)
            {
                var queryCountOrders = db.Orders
                                         .Where(o => o.CustomerID == customer.CustomerID)
                                         .Count();
                Console.WriteLine($"ID: {customer.CustomerID} - " +
                                  $"Nombre del cliente: {customer.ContactName}\n   " +
                                  $"Cantidad de ordenes realizadas: {queryCountOrders}");
            }

            return queryCustomers.ToList();
        }
    }
}
