using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo.EF.Entities;
using Trabajo.EF.Logic;

namespace Trabajo.EF.UI
{
    public class EmployeesUI
    {
        public void ShowEmployees(EmployeesLogic employeesList)
        {
            foreach (Employees employee in employeesList.GetAll())
            {
                Console.WriteLine($"Empleado: {employee.EmployeeID} - {employee.LastName}, " +
                                  $"{employee.FirstName}\t-\tTeléfono: {employee.HomePhone}" +
                                  $"\n  Código postal: {employee.PostalCode}");
            }
        }

        public void UpdateEmployees(EmployeesLogic employeesList)
        {
            Console.WriteLine("Ingrese el id del empleado que desea modificar: ");
            int idVar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el nuevo código postal del empleado: ");
            string postalCodeVar = Console.ReadLine();

            employeesList.Update(new Employees
            {
                EmployeeID = idVar,
                PostalCode = postalCodeVar
            });

            Console.WriteLine("Lista actualizada de empleados: ");
            ShowEmployees(employeesList);
        }
    }
}
