using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo.EF.Logic
{
    interface IABMLogic<T>
    {
        List<T> GetAll();
        void Add(T newItem);
        void Delete(int id);
        void Update(T item);
    }
}
