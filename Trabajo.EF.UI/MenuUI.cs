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
        public void FunctionMenu(int optionMenu)
        {
            switch (optionMenu)
            {
                case 1:
                    Console.WriteLine("\n\nListado de productos: \n");
                    ProductsUI.ShowProducts();
                    optionMenu = 0;
                    FunctionMenu(optionMenu);
                    break;

                case 2:
                    Console.WriteLine("\n\nListado de empleados: \n");
                    EmployeesUI.ShowEmployees();
                    optionMenu = 0;
                    FunctionMenu(optionMenu);
                    break;

                case 3:
                    Console.WriteLine("\n\nListado de categorías: ");
                    CategoriesUI.ShowCategories();
                    optionMenu = 0;
                    FunctionMenu(optionMenu);
                    break;

                case 4:
                    CategoriesUI.DeleteCategories();
                    optionMenu = 0;
                    FunctionMenu(optionMenu);
                    break;

                case 5:
                    ProductsUI.InsertProducts();
                    optionMenu = 0;
                    FunctionMenu(optionMenu);
                    break;

                case 6:
                    EmployeesUI.UpdateEmployees();
                    optionMenu = 0;
                    FunctionMenu(optionMenu);
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
                    try
                    {
                        optionMenu = MenuExceptions.ExceptionSwitch();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("\nOcurrió un error. Por favor vuelva a intentar\n");
                    }
                    FunctionMenu(optionMenu);
                    break;
            }
        }

        public void AccessMenu()
        {
            ProductsLogic productsList = new ProductsLogic();
            EmployeesLogic employeesList = new EmployeesLogic();
            CategoriesLogic categoriesList = new CategoriesLogic();
            int optionMenu = 0;

            FunctionMenu(optionMenu);
        }

    }
}
