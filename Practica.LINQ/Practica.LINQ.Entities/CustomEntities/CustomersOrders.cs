using System;

namespace Practica.LINQ.Entities.CustomEntities
{
    public class CustomersOrders
    {
        public string CustomerID { get; set; }
        public string ContactName { get; set; }
        public int OrderID { get; set; }
        public DateTime? ShippedDate { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipPostalCode { get; set; }
    }
}
