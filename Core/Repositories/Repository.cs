using OOP_HRSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HRSystem.Core.Repositories
{
    internal class Repository<T> : IRepository<T> where T : Entity
    {
        private List<T> _entities = new();
        
        public IEnumerable<T> GetAll()
        {
            return _entities.AsReadOnly();
        }

        public T GetById(int id)
        {
            return _entities.FirstOrDefault(x => x.Id == id);
        }

        public void Add(T entity)
        {
            entity.Id = _entities.Count + 1;
            _entities.Add(entity);
        }

        public void Update(T entity)
        {
            var originalEntity = GetById(entity.Id);
            //copy new data
        }
        public void Delete(T entity)
        {
            _entities.Remove(entity);
        }




    }
}
