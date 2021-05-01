using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo.EF.Data;
using Trabajo.EF.Entities;

namespace Trabajo.EF.Logic
{
    public class BaseLogic
    {
        protected readonly NorthwindContext context;

        public BaseLogic()
        {
            context = new NorthwindContext();
        }
    }
}
