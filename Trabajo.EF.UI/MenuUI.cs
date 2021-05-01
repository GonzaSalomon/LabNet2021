using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo.EF.Logic;
using Trabajo.EF.Entities;
using Trabajo.EF.Logic.Exceptions;

namespace Trabajo.EF.UI
{
    public class MenuUI
    {
        public void FunctionMenu(ProductsLogic productsList, EmployeesLogic employeesList, int optionMenu)
        {
            EmployeesUI employeesUI = new EmployeesUI();
            ProductsUI productUI = new ProductsUI();

            switch (optionMenu)
            {
                case 1:
                    Console.WriteLine("\n\nListado de productos: \n");
                    productUI.ShowProducts(productsList);
                    optionMenu = 0;
                    FunctionMenu(productsList, employeesList, optionMenu);
                    break;

                case 2:
                    Console.WriteLine("\n\nListado de empleados: \n");
                    employeesUI.ShowEmployees(employeesList);
                    optionMenu = 0;
                    FunctionMenu(productsList, employeesList, optionMenu);
                    break;

                case 3:
                    productUI.InsertProducts(productsList);
                    optionMenu = 0;
                    FunctionMenu(productsList, employeesList, optionMenu);
                    break;

                case 4:
                    employeesUI.UpdateEmployees(employeesList);
                    optionMenu = 0;
                    FunctionMenu(productsList, employeesList, optionMenu);
                    break;

                case 5:
                    productUI.DeleteProducts(productsList);
                    optionMenu = 0;
                    FunctionMenu(productsList, employeesList, optionMenu);
                    break;

                case 6:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("\n\n1 - Ver información de productos");
                    Console.WriteLine("2 - Ver información de empleados");
                    Console.WriteLine("3 - Cargar un nuevo producto");
                    Console.WriteLine("4 - Modificar información de un empleado");
                    Console.WriteLine("5 - Eliminar un producto de la lista");
                    Console.WriteLine("6 - Salir del programa");
                    Console.WriteLine("Elija que desea realizar:");
                    optionMenu = MenuExceptions.ExceptionSwitch();
                    FunctionMenu(productsList, employeesList, optionMenu);
                    break;
            }
        }

        public void AccessMenu()
        {
            ProductsLogic productsList = new ProductsLogic();
            EmployeesLogic employeesList = new EmployeesLogic();
            int optionMenu = 0;

            FunctionMenu(productsList, employeesList, optionMenu);
        }
    }
}
