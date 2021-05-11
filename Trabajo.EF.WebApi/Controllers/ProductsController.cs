using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
        public void Post(string value)
        {

        }

        [HttpPut]
        public void Put(int id, string value)
        {

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
