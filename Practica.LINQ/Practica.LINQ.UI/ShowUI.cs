using Practica.LINQ.Entities;
using Practica.LINQ.Entities.CustomEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica.LINQ.Data;

namespace Practica.LINQ.UI
{
    public class ShowUI
    {
        public void Product(List<ProductsWStock> productList)
        {
            foreach (var product in productList)
            {
                Console.WriteLine($"ID: {product.ProductID} - " +
                                  $"Nombre: {product.ProductName}\n   " +
                                  $"Unidades en stock: {product.UnitsInStock} - " +
                                  $"Precio unitario: {product.UnitPrice}");
            }
        }

        public void FullCustomer(List<Customers> customersList)
        {
            foreach (Customers customer in customersList)
            {
                Console.WriteLine($"ID: {customer.CustomerID}\n   " +
                                  $"Compañía: {customer.CompanyName}\n   " +
                                  $"Nombre de contacto: {customer.ContactName}\n   " +
                                  $"Titulo de contacto: {customer.ContactTitle}\n   " +
                                  $"Dirección: {customer.Address}\n   " +
                                  $"Ciudad: {customer.City}, {customer.Region} - {customer.Country}\n   " +
                                  $"Código postal: {customer.PostalCode}\n   " +
                                  $"Nº de teléfono: {customer.Phone} - Nº de fax: {customer.Fax}");
            }
        }

        public void ProductBase(List<ProductsBase> productList)
        {
            foreach (var product in productList)
            {
                Console.WriteLine($"ID: {product.ProductID} - " +
                                  $"Nombre del producto: {product.ProductName}\n  " +
                                  $"Precio por unidad: {product.UnitPrice} - " +
                                  $"Unidades en espera: {product.UnitsOnOrder}");
            }
        }

        public void CustomerWashington(List<CustomerWashington> customerList)
        {
            foreach (var customer in customerList)
            {
                Console.WriteLine($"ID: {customer.CustomerID}\t " +
                                  $"Nombre: {customer.ContactName}\n   " +
                                  $"Dirección: {customer.Address}, {customer.City}\t " +
                                  $"Código postal: {customer.PostalCode}");
            }
        }

        public void ToUpperToLower(List<CustomersName> customerList)
        {
            foreach (var customer in customerList)
            {
                Console.WriteLine($"En mayúscula: {customer.ContactName.ToUpper()} \t- " +
                                  $"En minúsculas: {customer.ContactName.ToLower()}");
            }
        }

        public void Customers1997(List<CustomersOrders> customersList)
        {
            foreach (var item in customersList)
            {
                Console.WriteLine($"Id del cliente: {item.CustomerID} - " +
                                  $"Nombre: {item.ContactName}\n   " +
                                  $"Id de la orden: {item.OrderID} - " +
                                  $"Fecha de envío: {item.ShippedDate}\n   " +
                                  $"Dirección de entrega: {item.ShipAddress}, {item.ShipCity} - " +
                                  $"Código postal: {item.ShipPostalCode}");
            }
        }

        public void TopThreeWashington(List<CustomersTop> customerList)
        {
            foreach (var customer in customerList)
            {
                Console.WriteLine($"ID: {customer.CustomerID} - " +
                                  $"Nombre: {customer.ContactName} - " +
                                  $"Teléfono: {customer.Phone}\n   " +
                                  $"Dirección: {customer.Address}, {customer.City} - " +
                                  $"Código postal: {customer.PostalCode}");
            }
        }
        
        public void ProductAssociatedCategory(List<ProductCategory> productList)
        {
            foreach (var item in productList)
            {
                Console.WriteLine($"ID del producto: {item.ProductID} - " +
                                  $"Nombre del producto: {item.ProductName}\n   " +
                                  $"Categoría: {item.CategoryName}");
            }
        }

        public void FirstOrNull(Products product)
        {
            if (product == null) Console.WriteLine("\nNo se encontró ningún producto con id 789");
            else Console.WriteLine($"ID: {product.CategoryID} - " +
                                   $"Nombre del producto: {product.ProductName}\n" +
                                   $"Unidades en stock: {product.UnitsInStock} - " +
                                   $"Precio unitario: {product.UnitPrice}");
        }

        public void CustomerCountOrders(List<Customers> queryCustomers)
        {

            foreach (var customer in queryCustomers)
            {
                NorthwindContext db = new NorthwindContext();
                var queryCountOrders = db.Orders
                                         .Where(o => o.CustomerID == customer.CustomerID)
                                         .Count();
                Console.WriteLine($"ID: {customer.CustomerID} - " +
                                  $"Nombre del cliente: {customer.ContactName}\n   " +
                                  $"Cantidad de ordenes realizadas: {queryCountOrders}");
            }
        }
    }
}
