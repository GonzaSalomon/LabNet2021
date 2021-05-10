using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trabajo.EF.Logic;
using Trabajo.EF.Entities;
using Trabajo.EF.MVC.Models;

namespace Trabajo.EF.MVC.Controllers
{
    public class ProductsController : Controller
    {
        ProductsLogic logic = new ProductsLogic();
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Insert(ProductsInsertView productsView)
        {
            try
            {
                if (productsView.ProductName.Length > 40){ throw new ArgumentOutOfRangeException(productsView.ProductName, "El nombre del producto es muy largo");}
                if (productsView.UnitsInStock < 0 || productsView.UnitsInStock > 255) { throw new ArgumentOutOfRangeException(); }
                if (productsView.UnitPrice < -922337203685477 || productsView.UnitPrice > 922337203685477) { throw new ArgumentOutOfRangeException(); }
                    var productsEntity = new Products
                {
                    ProductName = productsView.ProductName,
                    UnitPrice = productsView.UnitPrice,
                    UnitsInStock = productsView.UnitsInStock,
                    Discontinued = false
                };

                logic.Add(productsEntity);

                return RedirectToAction("Consult");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return RedirectToAction("Index", "Error", ex);
            }
            catch (NullReferenceException ex)
            {
                return RedirectToAction("Index", "Error", ex);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", ex);
            }
        }

        public ActionResult Consult()
        {
            List<Products> products = logic.GetAll();
            List<ProductsView> productsView = products.Select(p => new ProductsView
            {
                ProductID = p.ProductID,
                ProductName = p.ProductName,
                UnitPrice = p.UnitPrice,
                UnitsInStock = p.UnitsInStock
            }).ToList();
            return View(productsView);
        }

        [HttpPost]
        public ActionResult Modify(ProductsView productsView)
        {
            try
            {
                if (productsView.ProductID < -2147483648 || productsView.ProductID > 2147483647) { throw new ArgumentOutOfRangeException(); }
                if (productsView.ProductName.Length > 40) { throw new ArgumentOutOfRangeException(); }
                if (productsView.UnitsInStock < 0 || productsView.UnitsInStock > 255) { throw new ArgumentOutOfRangeException(); }
                if (productsView.UnitPrice < -922337203685477 || productsView.UnitPrice > 922337203685477) { throw new ArgumentOutOfRangeException(); }
                var productsEntity = new Products
                {
                    ProductName = productsView.ProductName,
                    UnitPrice = productsView.UnitPrice,
                    UnitsInStock = productsView.UnitsInStock,
                    Discontinued = false
                };

                logic.Update(productsView.ProductID, productsEntity);
                
                return RedirectToAction("Consult");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return RedirectToAction("Index", "Error", ex);
            }
            catch (NullReferenceException ex)
            {
                return RedirectToAction("Index", "Error", ex);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", ex);
            }
        }

        public ActionResult PreInsert()
        {
            return View();
        }

        public ActionResult Delete(int id)
        {
            logic.Delete(id);
            return RedirectToAction("Consult");
        }

        public ActionResult PreModify(int id, string name, decimal price, short stock)
        {
            ViewBag.Id = id;
            ViewBag.Name = name;
            ViewBag.Price = price;
            ViewBag.Stock = stock;
            return View();
        }
    }
}