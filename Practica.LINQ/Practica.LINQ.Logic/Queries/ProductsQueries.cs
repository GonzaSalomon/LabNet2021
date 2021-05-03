using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica.LINQ.Data;
using Practica.LINQ.Entities;

namespace Practica.LINQ.Logic.Queries
{
    public class ProductsQueries
    {
        NorthwindContext db = new NorthwindContext();

        public void ProductsNoStock()
        {
            Console.WriteLine("2 - Productos sin stock: \n");

            var queryNoStock = from product in db.Products
                               where product.UnitsInStock == 0
                               select new
                               {
                                   product.ProductID,
                                   product.ProductName,
                                   product.UnitPrice,
                                   product.UnitsOnOrder
                               };

            foreach (var product in queryNoStock)
            {
                Console.WriteLine($"ID: {product.ProductID} - Nombre del producto: {product.ProductName} " +
                                  $"\n  Precio por unidad: {product.UnitPrice} - Unidades en espera: {product.UnitsOnOrder}");
            }
        }

        public void ProductsPlusThreeStock()
        {
            Console.WriteLine("3 - Productos en stock y que cuestan más de 3 por unidad: \n");

            var queryPlusThree = from product in db.Products
                                 where product.UnitsInStock != 0
                                    && product.UnitPrice > 3
                                 select new
                                 {
                                     product.UnitsInStock,
                                     product.ProductID,
                                     product.ProductName,
                                     product.UnitPrice
                                 };

            foreach (var product in queryPlusThree)
            {
                Console.WriteLine($"ID: {product.ProductID} - Nombre del producto: {product.ProductName} \n " +
                                  $"  Precio por unidad: {product.UnitPrice}\t- Cantidad en stock: {product.UnitsInStock}");
            }
        }

        public void ProductOrNull()
        {
            Console.WriteLine("5 - Primer producto con ID 789 o nulo: \n");

            var productOrNull = db.Products
                                  .FirstOrDefault(p => p.ProductID == 789);

            if (productOrNull == null) Console.WriteLine("\nNo se encontró ningún producto con id 789");
            else Console.WriteLine($"\nNombre del producto: {productOrNull.ProductName}\nPrecio: {productOrNull.UnitPrice}");
        }
    }
}
