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

        public static void ShowEmployees()
        {
            EmployeesLogic employeesList = new EmployeesLogic();
            List<Employees> list = employeesList.GetAll();

            for (int i = 0; i < list.Count; i++)
            {
                Employees employee = list[i];
                Console.WriteLine($"Empleado: {employee.EmployeeID} - {employee.LastName}, " +
                                  $"{employee.FirstName}\t-\tTeléfono: {employee.HomePhone}" +
                                  $"\n  Código postal: {employee.PostalCode}");
            }
        }

        public static void UpdateEmployees()
        {
            EmployeesLogic employeesList = new EmployeesLogic();

            try
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
                ShowEmployees();
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nMensaje de error: " + ex.Message);
                Console.WriteLine("\nStackTrace" + ex.StackTrace);
            }
            
        }
    }
}
