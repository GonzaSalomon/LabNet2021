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
        public void FunctionMenu(ProductsLogic productsList, EmployeesLogic employeesList, CategoriesLogic categoriesList, int optionMenu)
        {
            switch (optionMenu)
            {
                case 1:
                    Console.WriteLine("\n\nListado de productos: \n");
                    ProductsUI.ShowProducts(productsList);
                    optionMenu = 0;
                    FunctionMenu(productsList, employeesList, categoriesList, optionMenu);
                    break;

                case 2:
                    Console.WriteLine("\n\nListado de empleados: \n");
                    EmployeesUI.ShowEmployees(employeesList);
                    optionMenu = 0;
                    FunctionMenu(productsList, employeesList, categoriesList, optionMenu);
                    break;

                case 3:
                    Console.WriteLine("\n\nListado de categorías: ");
                    CategoriesUI.ShowCategories(categoriesList);
                    optionMenu = 0;
                    FunctionMenu(productsList, employeesList, categoriesList, optionMenu);
                    break;

                case 4:
                    CategoriesUI.DeleteCategories(categoriesList, productsList);
                    optionMenu = 0;
                    FunctionMenu(productsList, employeesList, categoriesList, optionMenu);
                    break;

                case 5:
                    ProductsUI.InsertProducts(productsList);
                    optionMenu = 0;
                    FunctionMenu(productsList, employeesList, categoriesList, optionMenu);
                    break;

                case 6:
                    EmployeesUI.UpdateEmployees(employeesList);
                    optionMenu = 0;
                    FunctionMenu(productsList, employeesList, categoriesList, optionMenu);
                    break;

                case 7:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("\n\n1 - Ver información de productos");
                    Console.WriteLine("2 - Ver información de empleados");
                    Console.WriteLine("3 - Ver información de categorías");
                    Console.WriteLine("4 - Eliminar una categoría");
                    Console.WriteLine("5 - Cargar un nuevo producto");
                    Console.WriteLine("6 - Modificar información de un empleado");
                    Console.WriteLine("7 - Salir del programa");
                    Console.WriteLine("Elija que desea realizar:");
                    optionMenu = MenuExceptions.ExceptionSwitch();
                    FunctionMenu(productsList, employeesList, categoriesList, optionMenu);
                    break;
            }
        }

        public void AccessMenu()
        {
            ProductsLogic productsList = new ProductsLogic();
            EmployeesLogic employeesList = new EmployeesLogic();
            CategoriesLogic categoriesList = new CategoriesLogic();
            int optionMenu = 0;

            FunctionMenu(productsList, employeesList, categoriesList, optionMenu);
        }

    }
}
