using Practica.LINQ.Data;
using Practica.LINQ.Entities;
using Practica.LINQ.Entities.CustomEntities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Practica.LINQ.Logic.Queries
{
    public class ProductsQueries
    {
        NorthwindContext db = new NorthwindContext();

        public List<ProductsBase> ProductsNoStock()
        {
            Console.WriteLine("2 - Productos sin stock: \n");

            var queryNoStock = from product in db.Products
                               where product.UnitsInStock == 0
                               select new ProductsBase()
                               {
                                   ProductID = product.ProductID,
                                   ProductName = product.ProductName,
                                   UnitPrice = product.UnitPrice,
                                   UnitsOnOrder = product.UnitsOnOrder
                               };

            foreach (var product in queryNoStock)
            {
                Console.WriteLine($"ID: {product.ProductID} - " +
                                  $"Nombre del producto: {product.ProductName}\n  " +
                                  $"Precio por unidad: {product.UnitPrice} - " +
                                  $"Unidades en espera: {product.UnitsOnOrder}");
            }

            return queryNoStock.ToList();
        }

        public List<ProductsWStock> ProductsPlusThreeStock()
        {
            Console.WriteLine("3 - Productos en stock y que cuestan más de 3 por unidad: \n");

            var queryPlusThree = from product in db.Products
                                 where product.UnitsInStock != 0
                                    && product.UnitPrice > 3
                                 select new ProductsWStock()
                                 {
                                     ProductID = product.ProductID,
                                     ProductName = product.ProductName,
                                     UnitPrice = product.UnitPrice,
                                     UnitsInStock = product.UnitsInStock
                                 };

            ShowProduct(queryPlusThree.ToList());

            return queryPlusThree.ToList();
        }

        public void ProductOrNull(List<Products> products)
        {
            Console.WriteLine("5 - Primer producto con ID 789 o nulo: \n");

            var productOrNull = products.FirstOrDefault(p => p.ProductID == 789);

            if (productOrNull == null) Console.WriteLine("\nNo se encontró ningún producto con id 789");
            else Console.WriteLine($"\nNombre del producto: {productOrNull.ProductName}\n" +
                                   $"Precio unitario: {productOrNull.UnitPrice}\n   " +
                                   $"Unidades en stock: {productOrNull.UnitsInStock} - " +
                                   $"Precio unitario: {productOrNull.UnitPrice}");
        }

        public List<ProductsWStock> ProductsOrderedByName()
        {
            Console.WriteLine("9 - Listado de productos ordenados por el nombre: \n");

            var queryProdByName = db.Products
                                    .Select(p => new ProductsWStock()
                                    {
                                        ProductName = p.ProductName,
                                        ProductID = p.ProductID,
                                        UnitPrice = p.UnitPrice,
                                        UnitsInStock = p.UnitsInStock
                                    })
                                    .OrderBy(p => p.ProductName)
                                    .ToList();

            ShowProduct(queryProdByName);

            return queryProdByName;
        }

        public List<ProductsWStock> ProductsOrderedByUnitStock()
        {
            Console.WriteLine("10 - Lista de productos ordenados por cantidad en stock de mayor a menor: \n");

            var queryProdByStock = db.Products
                                     .Select(p => new ProductsWStock()
                                     {
                                         UnitsInStock = p.UnitsInStock,
                                         ProductID = p.ProductID,
                                         ProductName = p.ProductName,
                                         UnitPrice = p.UnitPrice
                                     })
                                     .OrderByDescending(p => p.UnitsInStock)
                                     .ToList();

            ShowProduct(queryProdByStock);

            return queryProdByStock;
        }

        public List<ProductCategory> ProductsAssociatedCategory()
        {
            Console.WriteLine("11 - Lista de categorías asociadas a los productos: \n");

            var queryAssociation = from product in db.Products
                                   join category in db.Categories
                                   on new { product.CategoryID }
                                       equals new { CategoryID = (int?)category.CategoryID }
                                   select new ProductCategory()
                                   {
                                       ProductID = product.ProductID,
                                       ProductName = product.ProductName,
                                       CategoryID = category.CategoryID,
                                       CategoryName = category.CategoryName
                                   };

            foreach (var item in queryAssociation)
            {
                Console.WriteLine($"ID del producto: {item.ProductID} - " +
                                  $"Nombre del producto: {item.ProductName}\n   " +
                                  $"Categoría: {item.CategoryName}");
            }

            return queryAssociation.ToList();
        }

        public List<ProductsWStock> ProductsFirstList(List<Products> listaProd)
        {
            Console.WriteLine("12 - Primer elemento de una lista de productos: \n");

            var queryFirstProduct = from product in listaProd
                                    select new ProductsWStock()
                                    {
                                        ProductID = product.ProductID,
                                        ProductName = product.ProductName,
                                        UnitPrice = product.UnitPrice,
                                        UnitsInStock = product.UnitsInStock
                                    };

            var queryTop = queryFirstProduct.Take(1).ToList();

            ShowProduct(queryTop);

            return queryTop;
        } 

        private void ShowProduct(List<ProductsWStock> productList)
        {
            foreach (var product in productList)
            {
                Console.WriteLine($"ID: {product.ProductID} - " +
                                  $"Nombre: {product.ProductName}\n   " +
                                  $"Unidades en stock: {product.UnitsInStock} - " +
                                  $"Precio unitario: {product.UnitPrice}");
            }
        }
    }
}
