using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo.EF.Entities;
using Trabajo.EF.Logic;
using Trabajo.EF.Logic.Exceptions;

namespace Trabajo.EF.UI
{
    public class CategoriesUI
    {
        public static void ShowCategories(CategoriesLogic categoriesList)
        {
            foreach (Categories categories in categoriesList.GetAll())
            {
                Console.WriteLine($"{categories.CategoryID} - Categoria: {categories.CategoryName}");
            }
        }

        public static void DeleteCategories(CategoriesLogic categoriesList, ProductsLogic productsList)
        {
            Console.WriteLine("\nIngrese el id de la categoría que desea eliminar: ");
            int categoriesIdVar = InsertException.ExceptionInt();

            productsList.Update(new Products
            {
                CategoryID = categoriesIdVar
            });

            categoriesList.Delete(categoriesIdVar);

            Console.WriteLine("\n\nCategorias actualizadas: ");
            ShowCategories(categoriesList);
        }
    }
}
