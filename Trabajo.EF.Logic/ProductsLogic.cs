using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo.EF.Data;
using Trabajo.EF.Entities;

namespace Trabajo.EF.Logic
{
    public class ProductsLogic : BaseLogic, IABMLogic<Products>
    {
        public List<Products> GetAll()
        {
            return context.Products.ToList();
        }

        public void Add(Products newProduct)
        {
            context.Products.Add(newProduct);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var productToDelete = context.Products.Find(id);
            context.Products.Remove(productToDelete);
            context.SaveChanges();
        }

        public void Update(Products productList)
        {
            var productUpdate = context.Products.Where(p => p.CategoryID == productList.CategoryID).ToList();
            foreach (Products products in productUpdate)
            {
                products.CategoryID = null;
            }
            context.SaveChanges();
        }

        public void Update(int id, string productName, decimal unitPrice, short unitsStock)
        {
            var productUpdate = context.Products.FirstOrDefault(p => p.ProductID == id);
            productUpdate.ProductName = productName;
            if (unitPrice != 0) { productUpdate.UnitPrice = unitPrice; }
            if (unitsStock != 0) { productUpdate.UnitsInStock = unitsStock; }
            context.SaveChanges();
        }
    }
}
