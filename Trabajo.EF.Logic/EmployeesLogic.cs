using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo.EF.Entities;
using Trabajo.EF.Data;

namespace Trabajo.EF.Logic
{
    public class EmployeesLogic : BaseLogic, IABMLogic<Employees>
    {
        public void Add(Employees newEmployee)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employees> GetAll()
        {
            return context.Employees.ToList();
        }

        public void Update(Employees employee)
        {
            var employeeUpdate = context.Employees.Find(employee.EmployeeID);
            employeeUpdate.PostalCode = employee.PostalCode;
        }
    }
}
