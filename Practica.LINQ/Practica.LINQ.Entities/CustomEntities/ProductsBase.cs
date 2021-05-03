namespace Practica.LINQ.Entities.CustomEntities
{
    public class ProductsBase
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsOnOrder { get; set; }
    }
}
