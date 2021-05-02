using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.LINQ.Logic.Interfaces
{
    interface IABMLogic<T>
    {
        List<T> GetAll();
        void Add(T item);
        void Delete(int id);
        void Update(T itm);
    }
}
