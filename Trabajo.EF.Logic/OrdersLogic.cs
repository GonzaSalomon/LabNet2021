using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo.EF.Data;
using Trabajo.EF.Entities;

namespace Trabajo.EF.Logic
{
    public class OrdersLogic
    {
        protected readonly NorthwindContextOrderDetail context;

        public OrdersLogic()
        {
            context = new NorthwindContextOrderDetail();
        }

        public void Update(int id)
        {
            var orderUpdate = context.Order_Details.Where(o => o.ProductID == id).ToList();
            foreach (Order_Details orderD in orderUpdate)
            {
                orderD.ProductID = 0;
            }
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
            }
        }
    }
}
