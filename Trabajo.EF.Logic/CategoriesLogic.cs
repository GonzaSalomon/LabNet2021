using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo.EF.Data;
using Trabajo.EF.Entities;

namespace Trabajo.EF.Logic
{
    public class CategoriesLogic : IABMLogic<Categories>
    {
        private readonly NorthwindContextCategories context;

        public CategoriesLogic()
        {
            context = new NorthwindContextCategories();
        }

        public void Add(Categories newItem)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            var categorieToDelete = context.Categories.Find(id);
            context.Categories.Remove(categorieToDelete);
            context.SaveChanges();
        }

        public List<Categories> GetAll()
        {
            return context.Categories.ToList();
        }

        public void Update(Categories item)
        {
            throw new NotImplementedException();
        }
    }
}
