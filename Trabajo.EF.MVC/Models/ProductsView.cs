using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trabajo.EF.MVC.Models
{
    public class ProductsView
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
    }

    public class ProductsInsertView
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public bool Discontinued { get; set; }
    }
}