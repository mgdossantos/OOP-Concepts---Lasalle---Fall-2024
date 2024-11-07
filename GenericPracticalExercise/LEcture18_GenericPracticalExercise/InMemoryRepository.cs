using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
//Implement the IRepository<T> interface in a class named InMemoryRepository<T>,
//where T must inherit from Entity.
//Use a List<T> to store the entities.

namespace Lecture18_GenericPracticalExercise
{
    public class InMemoryRepository<T> : IRepository<T> where T : Entity
    {
        private List<T> items = new List<T>();

        public void add(T entity) {
            int count = items.Count;
            entity.Id = count + 1;
            items.Add(entity);
        }
        
        public T get(int id){
            foreach(T entity in items)
            {
                if (entity.Id==id)
                    return entity;
            }

            return default(T);
          
        }

        public IEnumerable<T> getAll(){
            return items;
        }

        public void update(T entity)  {
            var existing = get(entity.Id);
            if (existing == null)
                throw new ArgumentException("Entity not found");
            items.Remove(existing);
            items.Add(entity);
        }
        public void delete(int id){
        
            var entity = get(id);
            if(entity == null) throw new ArgumentException("Entity not found");

            items.Remove(entity);
        }
    }
}
