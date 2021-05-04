using Practica.LINQ.Data;
using Practica.LINQ.Logic.Queries;
using System.Linq;
using Practica.LINQ.Entities;
using Practica.LINQ.Entities.CustomEntities;
using System;
using System.Collections.Generic;
using Practica.LINQ.Entities;

namespace Practica.LINQ.Logic
{
    public class CommunicationLogic
    {
        CustomersQueries custQ = new CustomersQueries();
        ProductsQueries proQ = new ProductsQueries();

        public List<Customers> CustomerQueryFull()
        {
            var queryFullCustomer = custQ.CustomerQueryFull();
            return queryFullCustomer;
        }

        public List<ProductsBase> ProductsNoStock()
        {
            var queryNoStock = proQ.ProductsNoStock();
            return queryNoStock;
        }

        public List<ProductsWStock> ProductsPlusThreeStock()
        {
            var queryPlusThree = proQ.ProductsPlusThreeStock();
            return queryPlusThree;
        }

        public List<CustomerWashington> CustomersFromWashington()
        {
            var queryCustomerWashington = custQ.CustomersFromWashington();
            return queryCustomerWashington;
        }

        public Products ProductOrNull()
        {
            NorthwindContext bd = new NorthwindContext();
            //A modo de ejemplo se le pasó Products de NorthwindContext
            var queryProductOrNull = proQ.ProductOrNull(bd.Products.ToList());
            return queryProductOrNull;
        }

        public List<CustomersName> CustomersToUpperToLow()
        {
            var queryToUperToLow = custQ.CustomersToUpperToLow();
            return queryToUperToLow;
        }

        public List<CustomersOrders> CustomersWashington1997()
        {
            var queryWashingtonOrder = custQ.CustomersWashington1997();
            return queryWashingtonOrder;
        }

        public List<CustomersTop> CustomersTopThreeWashington()
        {
            var queryCustomersTopThree = custQ.CustomersTopThreeWashington();
            return queryCustomersTopThree;
        }

        public List<ProductsWStock> ProductsOrderedByName()
        {
            var queryOrderByName = proQ.ProductsOrderedByName();
            return queryOrderByName;
        }

        public List<ProductsWStock> ProductsOrderedByUnitStock()
        {
            var queryOrderByStock = proQ.ProductsOrderedByUnitStock();
            return queryOrderByStock;
        }

        public List<ProductCategory> ProductsAssocitedCategory()
        {
            var queryAssociation = proQ.ProductsAssociatedCategory();
            return queryAssociation;
        }

        public List<ProductsWStock> ProducsFirstList()
        {
            NorthwindContext bd = new NorthwindContext();
            //A modo de prueba le pasamos Products de NorthwindContext
            var queryTop = proQ.ProductsFirstList(bd.Products.ToList());

            return queryTop;
        }

        public List<Customers> CustomersCountOrders()
        {
            var queryCountOrders = custQ.CustomersCountOrders();
            return queryCountOrders;
        }
    }
}
