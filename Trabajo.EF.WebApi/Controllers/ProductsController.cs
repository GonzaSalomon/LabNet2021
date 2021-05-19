using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Trabajo.EF.Entities;
using Trabajo.EF.Logic;

namespace Trabajo.EF.WebApi.Controllers
{
    public class ProductsController : ApiController
    {
        ProductsLogic logic = new ProductsLogic();

        [HttpGet]
        public IEnumerable<Products> Get()
        {
            IEnumerable<Products> products = logic.GetAll();
            return products;
        }

        [HttpGet]
        public Products Get(int id)
        {
            var products = logic.Consult(id);
            return products;
        }

        [HttpPost]
        public HttpResponseMessage Post(Products product)
        {
            try
            {
                logic.Add(product);
                return Request.CreateResponse(HttpStatusCode.OK, product);
            }
            catch (Exception)
            {
                var message = string.Format("Ocurrió un error");
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, message);
            }
        }

        [HttpPut]
        public HttpResponseMessage Put(Products product)
        {
            Products productChecker = this.Get(product.ProductID);
            if (productChecker == null)
            {
                var message = string.Format("No existe un producto con el id {0}", product.ProductID);
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, message);
            }
            try
            {
                if (product.ProductID < 0 || product.ProductID > 2147483647) { throw new ArgumentOutOfRangeException(); }
                if (product.ProductName.Length > 40) { throw new ArgumentOutOfRangeException(); }
                if (product.UnitsInStock < 0 || product.UnitsInStock > 255) { throw new ArgumentOutOfRangeException(); }
                if (product.UnitPrice < 0 || product.UnitPrice > 922337203685477) { throw new ArgumentOutOfRangeException(); }
                
                logic.Update(product.ProductID, product);
                return Request.CreateResponse(HttpStatusCode.OK, product);
            }
            catch (Exception ex)
            {
                var message = string.Format("Explotó todo " + ex.Message);
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, message);
            }
        }

        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            Products product = this.Get(id);
            if (product == null)
            {
                var message = string.Format("No existe el producto con id {0}", id);
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, message);
            }
            else
            {
                logic.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, product);
            }
        }
    }
}
