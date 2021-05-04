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
            var queryNoStock = from product in db.Products
                               where product.UnitsInStock == 0
                               select new ProductsBase()
                               {
                                   ProductID = product.ProductID,
                                   ProductName = product.ProductName,
                                   UnitPrice = product.UnitPrice,
                                   UnitsOnOrder = product.UnitsOnOrder
                               };

            return queryNoStock.ToList();
        }

        public List<ProductsWStock> ProductsPlusThreeStock()
        {
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
            
            return queryPlusThree.ToList();
        }

        public Products ProductOrNull(List<Products> products)
        {
            var productOrNull = db.Products.FirstOrDefault(p => p.ProductID == 789);
            
            return productOrNull;
        }

        public List<ProductsWStock> ProductsOrderedByName()
        {
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
            
            return queryProdByName;
        }

        public List<ProductsWStock> ProductsOrderedByUnitStock()
        {
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
            
            return queryProdByStock;
        }

        public List<ProductCategory> ProductsAssociatedCategory()
        {
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

            return queryAssociation.ToList();
        }

        public List<ProductsWStock> ProductsFirstList(List<Products> listaProd)
        {
            var queryFirstProduct = from product in listaProd
                                    select new ProductsWStock()
                                    {
                                        ProductID = product.ProductID,
                                        ProductName = product.ProductName,
                                        UnitPrice = product.UnitPrice,
                                        UnitsInStock = product.UnitsInStock
                                    };

            var queryTop = queryFirstProduct.Take(1).ToList();
            return queryTop;
        } 


    }
}
