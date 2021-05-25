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
        public static void ShowCategories()
        {
            CategoriesLogic categoriesList = new CategoriesLogic();
            foreach (Categories categories in categoriesList.GetAll())
            {
                Console.WriteLine($"{categories.CategoryID} - Categoria: {categories.CategoryName}");
            }
        }

        public static void DeleteCategories()
        {
            CategoriesLogic categoriesList = new CategoriesLogic();
            ProductsLogic productsList = new ProductsLogic();

            Console.WriteLine("\nIngrese el id de la categoría que desea eliminar: ");
            try
            {
                int categoriesIdVar = InsertException.ExceptionInt();
                productsList.Update(new Products
                {
                    CategoryID = categoriesIdVar
                });
                categoriesList.Delete(categoriesIdVar);

                Console.WriteLine("\n\nCategorias actualizadas: ");
                ShowCategories();
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nMensaje de error: " + ex.Message);
                Console.WriteLine("\nStackTrace" + ex.StackTrace);
            }
        }
    }
}
