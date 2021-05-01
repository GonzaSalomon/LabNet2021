using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo.EF.Entities;
using Trabajo.EF.Logic;
using Trabajo.EF.Logic.Exceptions;

namespace Trabajo.EF.UI
{
    public class ProductsUI
    {
        public static void ShowProducts(ProductsLogic productsList)
        {
            foreach (Products product in productsList.GetAll())
            {
                Console.WriteLine($"Producto: {product.ProductID} - {product.ProductName} \n\tPrecio: " +
                                  $"{product.UnitPrice} - unidades disponibles: {product.UnitsInStock}");
            }
        }

        public static void InsertProducts(ProductsLogic productsList)
        {
            Console.WriteLine("\nIngrese el nombre del producto: ");
            string productNameVar = InsertException.ExceptionString();
            Console.WriteLine("\nIngrese el precio del producto: ");
            int unitPriceVar = InsertException.ExceptionInt();
            Console.WriteLine("\nIngrese la cantidad de stock disponible: ");
            short unitsInStockVar = InsertException.ExceptionSmallInt();

            productsList.Add(new Products
            {
                ProductName = productNameVar,
                UnitPrice = unitPriceVar,
                UnitsInStock = unitsInStockVar,
                Discontinued = false
            });

            Console.WriteLine("\n\nListado de productos actualizado: \n");
            ShowProducts(productsList);
        }

        public static void DeleteProducts(ProductsLogic productsList)
        {
            Console.WriteLine("Ingrese el id del producto que desea eliminar: ");
            int productIdVar = InsertException.ExceptionInt();
            productsList.Delete(productIdVar);
            Console.WriteLine("\n\nListado de productos actualizado: \n");
            ShowProducts(productsList);
        }
    }
}
