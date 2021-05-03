using Practica.LINQ.Data;
using Practica.LINQ.Logic.Queries;
using System.Linq;

namespace Practica.LINQ.Logic
{
    public class CommunicationLogic
    {
        CustomersQueries custQ = new CustomersQueries();
        ProductsQueries proQ = new ProductsQueries();

        public void CustomerQueryFull()
        {
            var queryFullCustomer = custQ.CustomerQueryFull();
        }

        public void ProductsNoStock()
        {
            var queryNoStock = proQ.ProductsNoStock();
        }

        public void ProductsPlusThreeStock()
        {
            var queryPlusThree = proQ.ProductsPlusThreeStock();
        }

        public void CustomersFromWashington()
        {
            var queryCustomerWashington = custQ.CustomersFromWashington();
        }

        public void ProductOrNull()
        {
            NorthwindContext bd = new NorthwindContext();
            //A modo de ejemplo se le pasó Products de NorthwindContext
            proQ.ProductOrNull(bd.Products.ToList());
        }

        public void CustomersToUpperToLow()
        {
            var queryToUperToLow = custQ.CustomersToUpperToLow();
        }

        public void CustomersWashington1997()
        {
            var queryWashingtonOrder = custQ.CustomersWashington1997();
        }

        public void CustomersTopThreeWashington()
        {
            var queryCustomersTopThree = custQ.CustomersTopThreeWashington();
        }

        public void ProductsOrderedByName()
        {
            var queryOrderByName = proQ.ProductsOrderedByName();
        }

        public void ProductsOrderedByUnitStock()
        {
            var queryOrderByStock = proQ.ProductsOrderedByUnitStock();
        }

        public void ProductsAssocitedCategory()
        {
            var queryAssociation = proQ.ProductsAssociatedCategory();
        }

        public void ProducsFirstList()
        {
            NorthwindContext bd = new NorthwindContext();
            //A modo de prueba le pasamos Products de NorthwindContext
            var queryTop = proQ.ProductsFirstList(bd.Products.ToList());
        }

        public void CustomersCountOrders()
        {
            var queryCountOrders = custQ.CustomersCountOrders();
        }
    }
}
