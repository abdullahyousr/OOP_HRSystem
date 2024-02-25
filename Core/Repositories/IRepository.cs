using OOP_HRSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HRSystem.Core.Repositories
{
    internal interface IRepository<T> where T : Entity
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Add(T entity);
    }
}
