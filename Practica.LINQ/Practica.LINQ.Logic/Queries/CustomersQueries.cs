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

            var queryFullCustomer = db.Customers
                                      .Take(1)
                                      .Select(c => c)
                                      .ToList();        

            return queryFullCustomer;
        }

        public List<CustomerWashington> CustomersFromWashington()
        {
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
            
            return queryFromWashington;
        }

        public List<CustomersName> CustomersToUpperToLow()
        {
            var queryToUpperToLow = db.Customers
                                      .Select(c => new CustomersName()
                                      {
                                          ContactName = c.ContactName
                                      });

            return queryToUpperToLow.ToList();
        }

        public List<CustomersOrders> CustomersWashington1997()
        {
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

            return queryWa1997.ToList();
        }

        public List<CustomersTop> CustomersTopThreeWashington()
        {
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

            return queryTopThree;
        }

        public List<Customers> CustomersCountOrders()
        {
            var queryCustomers = from customer in db.Customers
                                 select customer;
            
            return queryCustomers.ToList();
        }
    }
}
